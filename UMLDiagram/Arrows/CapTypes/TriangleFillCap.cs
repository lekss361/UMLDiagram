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
        protected override void DrawCap(Graphics graphics, Pen pen, List<Point> points, Point startPoint, Point endPoint)
        {
            base.DrawCap(graphics, pen, points, startPoint, endPoint); 

            SolidBrush solidBrush = new SolidBrush(pen.Color);
            Point[] pointF = new Point[] { points[0], points[1], points[2], points[0] };


            graphics.FillPolygon(solidBrush, pointF); 
        }
    }
}
