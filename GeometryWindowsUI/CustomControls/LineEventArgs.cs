using GeometryWindowsUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryWindowsUI.CustomControls
{
    public class LineEventArgs : EventArgs
    {
        public Line Line { get; set; }

        public LineEventArgs(Line line)
        {
            Line = line;
        }
    }
}
