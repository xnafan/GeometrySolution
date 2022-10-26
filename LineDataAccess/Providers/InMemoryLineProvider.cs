using LineDataAccess.Model;

namespace LineDataAccess.Providers
{
    public class InMemoryLineProvider : ILineProvider
    {
        private List<Line> _lines = new List<Line>();
        private int _currentIndex = 0;
        public int AddLine(Line line)
        {
            line.Id = GetNextId();
            _lines.Add(line);
            return line.Id;
        }
        public bool DeleteLine(int id) => _lines.RemoveAll(line => line.Id == id) > 0;

        public Line? GetLine(int id) => _lines.FirstOrDefault(line => line.Id == id);

        public IEnumerable<Line> GetLines() => _lines;

        public bool UpdateLine(Line line)
        {
            Line? foundLine = GetLine(line.Id);
            if (foundLine != null)
            {
                foundLine.Point1 = line.Point1;
                foundLine.Point2 = line.Point2;
                return true;
            }
            return false;
        }
        private int GetNextId() => ++_currentIndex;
    }
}