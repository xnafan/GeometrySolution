# GeometrySolution - a persistence-agnostic line drawing UI

The complete Geometry solution consists of: 
* Windows Forms UI which allows the user to draw lines on a Panel using the mouse and deleting them in a listbox
* REST service (ASP.NET Web API) which has the CRUD functionality for line storage
* Data Access Layer (class library talking to MS SQL Server using Dapper)

<img width="677" alt="image" src="https://user-images.githubusercontent.com/3811290/197964168-0d438c1e-43ea-4deb-ab25-f9a38505d945.png">

Everything has been kept as simple as possible, to focus on the functionality and swappable architecture, so there is no exception handling nor a big focus on using specific http response status codes beyond Ok() and NotFound().

# Architecture overview

All layers and tiers are separated from the layers below them using dependency injection of a ILineProvider implementation:

    public interface ILineProvider
    {
        IEnumerable<Line> GetLines();
        Line? GetLine(int id);
        bool DeleteLine(int id);
        bool UpdateLine(Line line);
        int AddLine(Line line);
    }

These implementations already exist: 
* MS SQL server (using Dapper)
* In-memory store (for testing).
* REST client for communicating with the REST service (using RestSharp)

![image](https://user-images.githubusercontent.com/3811290/198127597-9b72b942-2c90-47ed-b143-ae8f43e1bc6c.png)

This architecture means that the Windows UI can run alone with just an In-memory store, or directly communicate with a database locally.
Alternately, it can communicate with a REST service (LinesController), and the persistence medium for this service can, again, be either database, memory, or even a new REST server 😄


## Model data

The core model object in this solution is a Line.
A Line is merely two Points and an Id (key):
  
    public class Line
    {
        public Line(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public int Id { get; set; }
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public override string ToString() => $"Line {Id} : {Point1} to {Point2}";
    }


## Windows Forms UI
The UI itself can be seen here
<img width="603" alt="image" src="https://user-images.githubusercontent.com/3811290/198128425-fbb815fe-3cd7-4a69-a2e7-6fd8e7a264c4.png">

It is a simple window with two main elements:
* A listbox which has a list of the Line objects retrieved from the data source (any ILineProvider implementation), and which shows the Line objects using their custom ToString() implementation.
* A custom control [LineDrawingPanel]([url](https://github.com/xnafan/GeometrySolution/blob/master/GeometryWindowsUI/CustomControls/LineDrawingPanel.cs)), which is a very compact control which subscribes to the mouse events (down, move, up) and has a custom Paint implementation to draw all the lines in the ListBox, with the currently selected in a different color.

### LineDrawingPanel core implementation

This is the constructor of the LineDrawingPanel, where you can see that 
* a MouseDown event means "begin a new line"
* a MouseMove event means "move the end of the current line, if we're drawing)
* a MouseUp event means "We're done, if that drew a line (it's long enough to not be a single click), save it"

      public LineDrawingPanel()
    {
        DoubleBuffered = true; //to avoid flicker when drawing the background
        MouseDown += (object? sender, MouseEventArgs e) => BeginNewLine(e.Location);
        MouseMove += (object? sender, MouseEventArgs e) => MoveCurrentLineEndPointToMousePointer(e);
        MouseUp += (object? sender, MouseEventArgs e) => AddCurrentLineIfLongEnough();
    }


### Data consistency across ListBox, Panel and storage medium
To ensure that the LineDrawingPanel, the ListBox and the persistence medium (the ILineProvider implementation used) are all in sync, the LineDrawingPanel has a custom LineDrawn event, which the main form subscribes to. The event is raised whenever a new line is drawn and the main form then persists the new line, and if successful, adds it to the ListBox.

## Line editor dialog
If a user doubleclicks a Line in the listbox or selects one and either clicks Edit or ENTER, then the LineDialog is shown
<img width="242" alt="image" src="https://user-images.githubusercontent.com/3811290/198130476-e25febac-0034-4c90-ad23-85926ab7536d.png">

Here the user can edit the values of the Line or accept or cancel using ENTER or ESC.
Any changes are updated in the underlying ILineProvider immediately and in the ListBox.
    
# REST API (LinesController)
Simple CRUD service using default read/write controller implementation in VS.NET:

    public class LinesController : ControllerBase
    {
        ILineProvider _lineProvider;

        public LinesController(ILineProvider lineProvider) => _lineProvider = lineProvider;

        [HttpGet]
        public ActionResult<IEnumerable<Line>?> Get() => Ok(_lineProvider.GetLines());

        [HttpGet("{id}")]
        public ActionResult<Line> Get(int id) => Ok(_lineProvider.GetLine(id));

        [HttpPost]
        public int Post([FromBody] Line value) => _lineProvider.AddLine(value);

        [HttpPut()]
        public ActionResult<bool> Put([FromBody] Line value) => _lineProvider.UpdateLine(value);

        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id) => _lineProvider.DeleteLine(id) ? Ok(true) : NotFound  (false);
    }


# Data access project

[to be continued... 😉]
