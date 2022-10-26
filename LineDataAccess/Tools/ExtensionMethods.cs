using LineDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineDataAccess.Tools
{
    public static class ExtensionMethods
    {
        public static dynamic Flatten (this Line line)
        {
            return new
            {
                Id = line.Id,
                Point1_x = line.Point1.X,
                Point1_y = line.Point1.X,
                Point2_x = line.Point2.X,
                Point2_y = line.Point2.X
            };
        }
    }
}
