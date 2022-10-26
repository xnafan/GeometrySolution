# GeometrySolution - a persistence-agnostic line drawing UI

The Geometry Solution will consist of: 
* Windows Forms UI which allows the user to draw lines on a Panel using the mouse and deleting them in a listbox
* REST service (ASP.NET Web API) which has the CRUD functionality 
* Data Access Layer (class library talking to MS SQL Server using Dapper) 

<img width="677" alt="image" src="https://user-images.githubusercontent.com/3811290/197964168-0d438c1e-43ea-4deb-ab25-f9a38505d945.png">


## Windows Forms UI
Currently the Windows Forms UI is implemented, and can communicate with a persistence layer using the ILineProvider interface:

    public interface ILineProvider
    {
        IEnumerable<Line> GetLines();
        Line? GetLine(int id);
        bool DeleteLine(int id);
        bool UpdateLine(Line line);
        int AddLine(Line line);
    }

This interface is currently implemented in a class InMemoryLineProvider, which emulates stores in a List<Line> in memory.
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

        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(Point1.X - Point2.X, 2) + Math.Pow(Point1.Y - Point2.Y, 2));
        }
    }

## REST API 
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
