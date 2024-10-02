using LineDataAccess.Model;

namespace LineDataAccess.Providers;

public class InMemoryLineDAO : ILineDAO
{
    private List<Line> _lines = new List<Line>();
    private int _currentIndex = 0;
    public int Insert(Line line)
    {
        line.Id = GetNextId();
        _lines.Add(line);
        return line.Id;
    }
    public bool Delete(int id) => _lines.RemoveAll(line => line.Id == id) > 0;

    public Line? Get(int id) => _lines.FirstOrDefault(line => line.Id == id);

    public IEnumerable<Line> GetAll() => _lines;

    public bool Update(Line line)
    {
        Line? foundLine = Get(line.Id);
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