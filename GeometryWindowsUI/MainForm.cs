using GeometryWindowsUI.Model;
using GeometryWindowsUI.Provider;
using System.ComponentModel;

namespace GeometryWindowsUI
{
    public partial class MainForm : Form
    {
        public bool HasUnsavedChanges { get; private set; }
        ILineProvider _lineProvider;
        public MainForm(ILineProvider lineProvider)
        {
            InitializeComponent();
            _lineProvider = lineProvider;
            lineVisualizerPanel.LineCollection = lstLines.Items;
            lineVisualizerPanel.LineDrawn += LineVisualizerPanel_LineAdded;
            lstLines.SelectedIndexChanged += LstLines_SelectedIndexChanged;
        }

        private void LineVisualizerPanel_LineAdded(object? sender, CustomControls.LineEventArgs e)
        {
            AddLine(e.Line);
        }

        private void AddLine(Line line)
        {
            if (_lineProvider.AddLine(line) > 0) {lstLines.Items.Add(line);}
            else { MessageBox.Show($"Error saving new line: {line}"); }
        }

        private void LstLines_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lineVisualizerPanel.SelectedLine = (Line)lstLines.SelectedItem;
            lineVisualizerPanel.Refresh();
        }

        private void deleteSelectedLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedLine();
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

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Delete) { DeleteSelectedLine(); }
        }
    }
}