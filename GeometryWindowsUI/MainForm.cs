using GeometryWindowsUI.Model;
using GeometryWindowsUI.Provider;
using System.ComponentModel;

namespace GeometryWindowsUI
{
    public partial class MainForm : Form
    {

        ILineProvider _lineProvider;
        public MainForm(ILineProvider lineProvider)
        {
            InitializeComponent();
            _lineProvider = lineProvider;
            lineVisualizerPanel.LineCollection = new BindingList<Line>();
            lstLines.DataSource = lineVisualizerPanel.LineCollection;
        }

        private void lstLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            lineVisualizerPanel.SelectedLines.Clear();
            lineVisualizerPanel.SelectedLines.Add((Line)lstLines.SelectedItem);
            lineVisualizerPanel.Refresh();
        }
    }
}