using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram.Arrows
{
    public class CompositionArrow : AbstractArrow
    {

        public override void Draw(Graphics graphics, Pen pen)
        {
            DrawAggregationArrow(graphics, pen);
        }


        public void DrawAggregationArrow(Graphics graphics, Pen pen)
        {

            graphics.DrawLine(pen, EndPoint, StartPoint); // тут рисуем линию 
            //graphics.DrawLine(pen, x3y3, x1y1);
            //graphics.DrawLine(pen, x3y3, x2y2);

            //graphics.DrawLine(pen, x1y1, x4y4);
            //graphics.DrawLine(pen, x2y2, x4y4);

            Point[] capPoints = GetPoints().ToArray();
            graphics.DrawLine(pen, capPoints[2], capPoints[0]);
            graphics.DrawLine(pen, capPoints[2], capPoints[1]);
            graphics.DrawLine(pen, capPoints[0], capPoints[3]);
            graphics.DrawLine(pen, capPoints[1], capPoints[3]);

            SolidBrush solidBrush = new SolidBrush(pen.Color); // кисть для закрашивания треуголника
            //Point[] pointF = new Point[] { x3y3, x2y2, x1y1, x4y4, x2y2, x1y1}; // массив точек для закрашивания треугольника 
            Point[] pointF = new Point[] { capPoints[2], capPoints[1], capPoints[0], capPoints[3], capPoints[1], capPoints[0] }; // массив точек для закрашивания треугольника 
            graphics.FillPolygon(solidBrush, pointF); // закрашиваем треуголник 

        }

    }
}
