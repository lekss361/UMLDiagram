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
            //Point x1y1, x2y2, x3y3, x4y4;
            //СalculationOfAngles(EndPoint, StartPoint, out x1y1, out x2y2, out x3y3, out x4y4);
            
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


        //protected void СalculationOfAngles( Point mCur,  Point mStart, out Point x1y1, out Point x2y2, out Point x3y3, out Point x4y4)
        //{
        //    arrow_lenght = 15;
        //    arrow_degrees = 300;
        //    //double x1, y1, x2, y2, x3, y3, x4, y4;

        //    int hightTriangle = Convert.ToInt32(arrow_lenght * Math.Sqrt(3) / 2);

        //    angle = Math.Atan2(mCur.Y - mStart.Y, mCur.X - mStart.X) + Math.PI; // угол поворота линии

        //    x1 = mCur.X + arrow_lenght * Math.Cos(angle - arrow_degrees);
        //    y1 = mCur.Y + arrow_lenght * Math.Sin(angle - arrow_degrees);

        //    x2 = mCur.X + arrow_lenght * Math.Cos(angle + arrow_degrees);
        //    y2 = mCur.Y + arrow_lenght * Math.Sin(angle + arrow_degrees);

        //    x3 = mCur.X - 30 * Math.Cos(angle);
        //    y3 = mCur.Y - 30 * Math.Sin(angle);

        //    x4 = mCur.X + 30 * Math.Cos(angle);
        //    y4 = mCur.Y + 30 * Math.Sin(angle);

        //    x1y1 = new Point(Convert.ToInt32(x1), Convert.ToInt32(y1));
        //    x2y2 = new Point(Convert.ToInt32(x2), Convert.ToInt32(y2));
        //    x3y3 = new Point(Convert.ToInt32(x3), Convert.ToInt32(y3));
        //    x4y4 = new Point(Convert.ToInt32(x4), Convert.ToInt32(y4));
        //}
    }
}
