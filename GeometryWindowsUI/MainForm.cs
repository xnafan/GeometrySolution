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
                gmtpnlLineVisualizer.LineCollection = new BindingList<Line>();
                lstLines.DataSource = gmtpnlLineVisualizer.LineCollection; 
            }

        private void lstLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            gmtpnlLineVisualizer.SelectedLines.Clear();
            gmtpnlLineVisualizer.SelectedLines.Add((Line)lstLines.SelectedItem );
            gmtpnlLineVisualizer.Refresh();
        }
    }
}