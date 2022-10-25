using GeometryWindowsUI.Model;
using System.ComponentModel;

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
        public BindingList<Line> LineCollection { get; set; } = new();
        public List<Line> SelectedLines { get; set; } = new();
        #endregion
        
        #region Constructor
        public GeometryPanel()
        {
            DoubleBuffered = true;

        } 
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
            if(CurrentLine.GetLength() >= 5) {
             
                LineCollection.Add(CurrentLine);
              //  new BindingSource().ResetBindings(false);
            }
            CurrentLine = null;
        }

        private void BeginNewLine(Point location) => CurrentLine = new Line(location, location);

        #endregion

        #region Painting
        protected override void OnPaint(PaintEventArgs e)
        {
            int dotRadius = 5;
            base.OnPaint(e);
            e.Graphics.FillRegion(Brushes.Navy, new Region(Bounds));
            if (CurrentLine != null)
            {
                e.Graphics.DrawLine(_whitePen, CurrentLine.Point1, CurrentLine.Point2);
                e.Graphics.FillEllipse(Brushes.Blue, CurrentLine.Point1.X - dotRadius, CurrentLine.Point1.Y - dotRadius, dotRadius * 2, dotRadius * 2);
                e.Graphics.FillEllipse(Brushes.Blue, CurrentLine.Point2.X - dotRadius, CurrentLine.Point2.Y - dotRadius, dotRadius * 2, dotRadius * 2);
            }
            foreach (var line in LineCollection)
            {
                Pen penColor = SelectedLines.Contains(line) ? _redPen : _cyanPen;
                e.Graphics.DrawLine(penColor, line.Point1, line.Point2);
            }
        } 
        #endregion
    }
}