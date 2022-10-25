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
            lineVisualizerPanel.LineCollection.ListChanged += LineCollection_ListChanged;
            lstLines.SelectedIndexChanged += LstLines_SelectedIndexChanged;
        }

       
        //HACK: when adding data items to BindingList<T>
        //the first item does not trigger the selected index changed
        //This workaround fixes it.
        private void LineCollection_ListChanged(object? sender, ListChangedEventArgs e)
        {
            lstLines.SelectedIndex = -1;
            lstLines.SelectedItem = lineVisualizerPanel.LineCollection.LastOrDefault();
        }

        private void LstLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            lineVisualizerPanel.SelectedLines.Clear();
            lineVisualizerPanel.SelectedLines.Add((Line)lstLines.SelectedItem);
            lineVisualizerPanel.Refresh();
        }
    }
}