using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram.Arrows.CapTypes
{
    public class ArrowCap : AbstractCap
    {

        protected override void DrawCap(Graphics graphics, Pen pen, List<Point> points, Point startPoint, Point endPoint)
        {
            graphics.DrawLine(pen, points[0], points[1]);
            graphics.DrawLine(pen, points[1], points[2]);
        }
    }
}
