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
        public override void DrawCap(Graphics graphics, Pen pen, Point start, Point end)
        {
            List<Point> points = GetPoints(start,end);
            SolidBrush solidBrush = new SolidBrush(pen.Color); // стоит ли вынести в абстрактный класс ?
            

            base.DrawCap(graphics, pen, start,end);

            graphics.FillPolygon(solidBrush, points.ToArray()); // как использовать точки базового класса?
        }
    }
}
