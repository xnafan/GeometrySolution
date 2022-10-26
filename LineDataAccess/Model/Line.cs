using System.Drawing;

namespace LineDataAccess.Model
{
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
}