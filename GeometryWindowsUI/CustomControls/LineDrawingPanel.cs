using GeometryWindowsUI.Tools;
using LineDataAccess.Model;
using System.Drawing.Drawing2D;

namespace GeometryWindowsUI.CustomControls
{
    internal class LineDrawingPanel : Panel
    {
        #region Properties and variables
        private static readonly int _lineWidth = 5;
        private readonly Pen _cyanPen = new Pen(Brushes.Cyan, _lineWidth);
        private readonly Pen _whitePen = new Pen(Brushes.White, _lineWidth);
        private readonly Pen _redPen = new Pen(Brushes.Red, _lineWidth);
        public Line? LineCurrentlyBeingDrawnWithMouse { get; set; }
        public ListBox.ObjectCollection? LineCollection { get; set; }
        public Line? SelectedLine { get; set; } = null;

        public event EventHandler<LineEventArgs>? LineDrawn;
        #endregion

        #region Constructor
        public LineDrawingPanel()
        {
            DoubleBuffered = true; //to avoid flicker when drawing the background
            MouseDown += (object? sender, MouseEventArgs e) => BeginNewLine(e.Location);
            MouseMove += (object? sender, MouseEventArgs e) => MoveCurrentLineEndPointToMousePointer(e);
            MouseUp += (object? sender, MouseEventArgs e) => AddCurrentLineIfLongEnough();
        }
        #endregion

        #region Methods for drawing lines
        private void MoveCurrentLineEndPointToMousePointer(MouseEventArgs e)
        {
            if (LineCurrentlyBeingDrawnWithMouse != null) { LineCurrentlyBeingDrawnWithMouse.Point2 = e.Location; }
            Refresh();
        }

        private void AddCurrentLineIfLongEnough()
        {
            if (LineCurrentlyBeingDrawnWithMouse != null && LineCurrentlyBeingDrawnWithMouse.GetLength() >= 5)
            {
                LineDrawn?.Invoke(this, new LineEventArgs(LineCurrentlyBeingDrawnWithMouse));
            }
            LineCurrentlyBeingDrawnWithMouse = null;
        }

        private void BeginNewLine(Point location) => LineCurrentlyBeingDrawnWithMouse = new Line(location, location);

        #endregion

        #region Repainting the Panel surface
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            
            //draw background
            e.Graphics.FillRegion(Brushes.Navy, new Region(Bounds));

            //draw currentline there is one
            if (LineCurrentlyBeingDrawnWithMouse != null)
            {
                e.Graphics.DrawLine(_whitePen, LineCurrentlyBeingDrawnWithMouse.Point1, LineCurrentlyBeingDrawnWithMouse.Point2);
            }
            //draw all lines
            if (LineCollection != null)
            {
                foreach (Line line in LineCollection)
                {
                    //use another color (red pen) if the line is the selected one
                    Pen penColor = (SelectedLine == line) ? _redPen : _cyanPen;
                    e.Graphics.DrawLine(penColor, line.Point1, line.Point2);
                } 
            }
        } 
        #endregion
    }
}