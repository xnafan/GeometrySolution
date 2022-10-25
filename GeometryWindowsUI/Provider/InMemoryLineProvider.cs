using GeometryWindowsUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryWindowsUI.Provider
{
    public class InMemoryLineProvider : ILineProvider
    {
        private List<Line> _lines = new List<Line>();
        private int _nextIndex = 0;
        public int CreateLine(Line line)
        {
            _nextIndex++;
            line.Id = _nextIndex;
            _lines.Add(line);
            return _nextIndex;
        }

        public bool DeleteLine(int id)
        {
            return _lines.Remove(line => line.i)
        }

        public Line? GetLine(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Line> GetLines()
        {
            throw new NotImplementedException();
        }

        public void UpdateLine(Line line)
        {
            throw new NotImplementedException();
        }
    }
}
