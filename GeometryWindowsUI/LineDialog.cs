using LineDataAccess.Model;

namespace GeometryWindowsUI
{
    public partial class LineDialog : Form
    {
        private Line line;

        public Line Line { get => line; 
            set { 
                line = value;
                CopyValuesFromLineToControls();
            } }

        public LineDialog(Line line = null)
        {
            InitializeComponent();
            SetNumericOnlyInput(new NumericUpDown[] { numPoint1_X, numPoint1_Y, numPoint2_X, numPoint2_Y });
            Line = line ?? new Line(new Point(), new Point());
        }

        private void SetNumericOnlyInput(IEnumerable<NumericUpDown> controls)
        {
            foreach (var numericUpDown in controls)
            {
                numericUpDown.KeyPress += (object? sender, KeyPressEventArgs e) => { if (".,".Contains(e.KeyChar)) { e.Handled = true; } };
            }
        }

        private void CopyValuesFromLineToControls()
        {
            if (Line == null) { return; }
            numPoint1_X.Value = Line.Point1.X;
            numPoint1_Y.Value = Line.Point1.Y;
            numPoint2_X.Value = Line.Point2.X;
            numPoint2_Y.Value = Line.Point2.Y;
        }

        private void btnOk_Click(object sender, EventArgs e) => CopyValuesFromControlsToLine();

        private void CopyValuesFromControlsToLine()
        {
            if (Line != null)
            {
                Line.Point1 = new Point((int)numPoint1_X.Value, (int)numPoint1_Y.Value);
                Line.Point2 = new Point((int)numPoint2_X.Value, (int)numPoint2_Y.Value); 
            }
        }
    }
}