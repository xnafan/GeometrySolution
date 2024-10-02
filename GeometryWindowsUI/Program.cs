using GeometryWindowsUI.Provider;
using LineDataAccess.Providers;

namespace GeometryWindowsUI;
internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        //we inject the Form's dependency on a storage medium
        //into the constructor of the MainForm:
        //Application.Run(new MainForm(new InMemoryLineProvider()));
        Application.Run(new MainForm(new RestServiceLineDAO("https://localhost:7026/api/v1/lines")));
        //Application.Run(new MainForm(new RestServiceLineProvider("https://lines.codesamples.dk/api/v1/lines")));
    }
}