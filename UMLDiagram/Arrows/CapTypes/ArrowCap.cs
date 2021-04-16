using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram.Arrows.CapTypes
{
    class ArrowCap : AbstractCap
    {

        public override void DrawCap(Graphics graphics, Pen pen,Point start,Point end)
        {
            List<Point> points = GetPoints(start,end);
            graphics.DrawLine(pen, points[0], points[1]);
            graphics.DrawLine(pen, points[1], points[2]);
        }
    }
}
