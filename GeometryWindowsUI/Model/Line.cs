namespace GeometryWindowsUI.Model
{
    internal class Line
    {
        public int Id { get; set; }
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public override string ToString() => $"Line {Id} - from {Point1} to {Point2}";
    }
}