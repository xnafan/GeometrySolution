using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryWindowsUI.CustomControls
{
    internal class GeometryPanel : Panel
    {

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRegion(Brushes.Navy, new Region(Bounds));
        }
    }
}
