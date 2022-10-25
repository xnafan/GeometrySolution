using GeometryWindowsUI.Provider;

namespace GeometryWindowsUI
{
    public partial class MainForm : Form
    {

        ILineProvider _lineProvider;
        public MainForm(ILineProvider lineProvider)
        {
            InitializeComponent();
            _lineProvider = lineProvider;
        }
    }
}