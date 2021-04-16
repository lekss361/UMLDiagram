using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram.Arrows.CapTypes
{
    class TriangleFillCap : TriangleCap
    {
        public override void DrawCap(Graphics graphics, Pen pen, Point start,Point end)
        {
            List<Point> points = GetPoints(start,end);
            SolidBrush solidBrush = new SolidBrush(pen.Color);
            Point[] pointF = new Point[] { points[0], points[1], points[2], points[0] };

            base.DrawCap(graphics, pen, start,end);

            graphics.FillPolygon(solidBrush, pointF); // можем ли мы тут написать points.ToArray() , какой лист он использует
        }
    }
}
