using GeometryWindowsUI.Provider;

namespace GeometryWindowsUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            
            //we inject the Form's dependency on a storage medium
            //into the constructor of the MainForm:
            Application.Run(new MainForm(new InMemoryLineProvider()));
        }
    }
}