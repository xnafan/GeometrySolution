using LineDataAccess.Model;

namespace GeometryWindowsUI.CustomControls
{
    public class LineEventArgs : EventArgs
    {
        public Line Line { get; set; }

        public LineEventArgs(Line line)
        {
            Line = line;
        }
    }
}
