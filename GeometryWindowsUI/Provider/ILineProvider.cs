using GeometryWindowsUI.Model;

namespace GeometryWindowsUI.Provider
{
    public interface ILineProvider
    {
        IEnumerable<Line> GetLines();
        Line? GetLine(int id);
        bool DeleteLine(int id);
        bool UpdateLine(Line line);
        int AddLine(Line line);
    }
}