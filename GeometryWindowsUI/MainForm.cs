using GeometryWindowsUI.Model;
using GeometryWindowsUI.Provider;

namespace GeometryWindowsUI
{
    public partial class MainForm : Form
    {
        #region Properties
        ILineProvider _lineProvider;
        #endregion

        #region Constructor
        public MainForm(ILineProvider lineProvider)
        {
            InitializeComponent();
            _lineProvider = lineProvider;
            lineVisualizerPanel.LineCollection = lstLines.Items;
            lineVisualizerPanel.LineDrawn += LineVisualizerPanel_LineAdded;
            lstLines.SelectedIndexChanged += LstLines_SelectedIndexChanged;
        }
        #endregion

        #region Event handling
        private void LineVisualizerPanel_LineAdded(object? sender, CustomControls.LineEventArgs e)
        {
            AddLine(e.Line);
        }


        private void LstLines_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lineVisualizerPanel.SelectedLine = (Line)lstLines.SelectedItem;
            lineVisualizerPanel.Refresh();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) { DeleteSelectedLine(); }
            else if (e.KeyCode == Keys.Enter) { EditSelectedLine(); }
        }

        private void lstLines_DoubleClick(object sender, EventArgs e) => EditSelectedLine();
        #endregion

        #region CRUD methods
        private void AddLine(Line line)
        {
            if (_lineProvider.AddLine(line) > 0) { lstLines.Items.Add(line); }
            else { MessageBox.Show($"Error saving new line: {line}"); }
        }

        private void DeleteSelectedLine()
        {
            if (lstLines.SelectedIndex == -1) { return; }
            if (_lineProvider.DeleteLine(((Line)lstLines.SelectedItem).Id))
            {
                lineVisualizerPanel.LineCollection?.Remove((Line)lstLines.SelectedItem);
            }
            else
            {
                MessageBox.Show($"Line {lstLines.SelectedItem} not deleted.");
            }
        }
        private void EditSelectedLine()
        {
            if (lstLines.SelectedIndex != -1)
            {
                LineDialog lineEditor = new LineDialog((Line)lstLines.SelectedItem);
                if (lineEditor.ShowDialog() == DialogResult.OK)
                {
                    _lineProvider.UpdateLine(lineEditor.Line);
                }
                //to force refresh of the Line's text in the listbox,
                //we reinsert it at the same spot:
                lstLines.Items[lstLines.SelectedIndex] = lstLines.Items[lstLines.SelectedIndex];
                
                //and ask the line panel to redraw
                lineVisualizerPanel.Refresh();
            }
        }
        #endregion

    }
}