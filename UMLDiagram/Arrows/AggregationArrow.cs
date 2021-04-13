using System;
using System.Drawing;


namespace UMLDiagram.Arrows
{
    public class AggregationArrow : AbstractArrow
    {
        public override void Draw(Graphics graphics, Pen pen)
        {
            DrawAggregationArrow(graphics, pen);
        }

        public void DrawAggregationArrow(Graphics graphics, Pen pen)
        {

            Point[] capPoints = GetPoints().ToArray();
            
            graphics.DrawLine(pen, StartPoint, capPoints[3]); // тут рисуем линию 
                //graphics.DrawLine(pen, x3y3, x1y1);
                //graphics.DrawLine(pen, x3y3, x2y2);
                //graphics.DrawLine(pen, x1y1, x4y4);
                //graphics.DrawLine(pen, x2y2, x4y4);
            
            graphics.DrawLine(pen, capPoints[2], capPoints[0]);
            graphics.DrawLine(pen, capPoints[2], capPoints[1]);
            graphics.DrawLine(pen, capPoints[0], capPoints[3]);
            graphics.DrawLine(pen, capPoints[1], capPoints[3]);
        }

    }
}
