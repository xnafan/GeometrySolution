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
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                    _lineProvider.AddLine((Line)lstLines.Items[e.NewIndex]);
                    lineVisualizerPanel.LineCollection.ResetItem(e.NewIndex);
                    break;
                case ListChangedType.ItemDeleted:
                    _lineProvider.DeleteLine()
                    break;
                case ListChangedType.ItemChanged:
                default:
                    break;
            }
        }

        private void LstLines_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lineVisualizerPanel.SelectedLine = null;
            lineVisualizerPanel.SelectedLine = (Line)lstLines.SelectedItem;
            lineVisualizerPanel.Refresh();
            deleteSelectedLine.Enabled = lstLines.SelectedIndex > -1;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDrawing();
        }

        private void NewDrawing()
        {
            // if(HasUnsavedChanges && lstLines                         )
        }

        private void deleteSelectedLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedLine();
        }

        private void DeleteSelectedLine()
        {
            if(_lineProvider.DeleteLine(((Line)lstLines.SelectedItem).Id))
            {
                lineVisualizerPanel.LineCollection.Remove((Line)lstLines.SelectedItem);
            }
        }
    }
}