using GeometryWindowsUI.Model;

namespace GeometryWindowsUI.Provider
{
    internal interface ILineProvider
    {
        IEnumerable<Line> GetLines();
        Line? GetLine(int id);
        bool DeleteLine(int id);
        void UpdateLine(Line line);
        Line CreateLine(Line line);
    }
}