using LineDataAccess.Model;

namespace GeometryWindowsUI.Tools
{
    public static class ExtensionMethods
    {
        public static double GetLength(this Line line)
        {
            return Math.Sqrt(Math.Pow(line.Point1.X - line.Point2.X, 2) 
                + Math.Pow(line.Point1.Y - line.Point2.Y, 2));
        }
    }
}