using GeometryWindowsUI.Model;

namespace GeometryWindowsUI.Provider
{
    public interface ILineProvider
    {
        IEnumerable<Line> GetLines();
        Line? GetLine(int id);
        bool DeleteLine(int id);
        void UpdateLine(Line line);
        int CreateLine(Line line);
    }
}