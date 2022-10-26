# GeometrySolution - a persistence-agnostic line drawing UI

The Geometry Solution will consist of: 
* Windows Forms UI which allows the user to draw lines on a Panel using the mouse and deleting them in a listbox
* REST service (ASP.NET Web API) which has the CRUD functionality (not yet implemented)
* Data Access Layer (class library talking to MS SQL Server using Dapper) (not yet implemented)

<img width="521" alt="image" src="https://user-images.githubusercontent.com/3811290/197883633-cf406364-f295-4927-9745-3112c2fd08b3.png">

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
