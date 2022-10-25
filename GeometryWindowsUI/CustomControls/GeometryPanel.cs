using GeometryWindowsUI.Model;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace GeometryWindowsUI.CustomControls
{
    internal class GeometryPanel : Panel
    {
        #region Properties and variables
        private static readonly int _lineWidth = 3;
        private Pen _cyanPen = new Pen(Brushes.Cyan, _lineWidth);
        private Pen _whitePen = new Pen(Brushes.White, _lineWidth);
        private Pen _redPen = new Pen(Brushes.Red, _lineWidth);
        public Line? CurrentLine { get; set; }
        public ListBox.ObjectCollection? LineCollection { get; set; }
        public Line? SelectedLine { get; set; } = null;

        public event EventHandler<LineEventArgs> LineDrawn;
        #endregion
        
        #region Constructor
        public GeometryPanel() => DoubleBuffered = true;
        #endregion
       
        #region Eventhandling for mouse down, move, up
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            BeginNewLine(e.Location);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (CurrentLine != null) { CurrentLine.Point2 = e.Location; }
            Refresh();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            AddCurrentLineIfLongEnough();
            CurrentLine = null;
        }

        private void AddCurrentLineIfLongEnough()
        {
            if (CurrentLine != null && CurrentLine.GetLength() >= 5) 
            {
                LineDrawn?.Invoke(this, new LineEventArgs(CurrentLine));
            }
        }

        private void BeginNewLine(Point location) => CurrentLine = new Line(location, location);

        #endregion

        #region Painting
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.FillRegion(Brushes.Navy, new Region(Bounds));
            if (CurrentLine != null)
            {
                e.Graphics.DrawLine(_whitePen, CurrentLine.Point1, CurrentLine.Point2);
            }
            if (LineCollection != null)
            {
                foreach (var line in LineCollection)
                {
                    Pen penColor = (SelectedLine == line) ? _redPen : _cyanPen;
                    e.Graphics.DrawLine(penColor, ((Line)line).Point1, ((Line)line).Point2);
                } 
            }
        } 
        #endregion
    }
}