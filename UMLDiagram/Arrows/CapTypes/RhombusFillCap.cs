using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram.Arrows.CapTypes
{
    class RhombusFillCap : RhombusCap
    {
        protected override void DrawCap(Graphics graphics, Pen pen, List<Point> points, Point startPoint, Point endPoint)
        {
            SolidBrush solidBrush = new SolidBrush(pen.Color); 
            

            base.DrawCap(graphics, pen, points, startPoint,endPoint);

            graphics.FillPolygon(solidBrush, points.ToArray()); 
        }
    }
}
