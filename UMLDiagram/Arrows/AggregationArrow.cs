using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram.Arrows
{
    public class AggregationArrow : AbstractArrow
    {
        public override void Draw(Graphics graphics, Pen pen)
        {
            double angle;
            double arrow_lenght = 25;
            double arrow_degrees = 0.5; // размах крыльев или острота угла 
            double x1, y1, x2, y2, x3, y3;

            angle = Math.Atan2(EndPoint.Y - StartPoint.Y, EndPoint.X - StartPoint.X) + Math.PI; // угол поворота линии

            x1 = EndPoint.X + arrow_lenght * Math.Cos(angle - arrow_degrees);
            y1 = EndPoint.Y + arrow_lenght * Math.Sin(angle - arrow_degrees);

            x2 = EndPoint.X + arrow_lenght * Math.Cos(angle + arrow_degrees);
            y2 = EndPoint.Y + arrow_lenght * Math.Sin(angle + arrow_degrees);

            x3 = EndPoint.X + arrow_lenght * 2 * Math.Cos(angle);
            y3 = EndPoint.Y + arrow_lenght * 2 * Math.Sin(angle);

            Point x1y1 = new Point(Convert.ToInt32(x1), Convert.ToInt32(y1));
            Point x2y2 = new Point(Convert.ToInt32(x2), Convert.ToInt32(y2));
            Point x3y3 = new Point(Convert.ToInt32(x3), Convert.ToInt32(y3));

            // тут рисуем линию 
            graphics.DrawLine(pen, StartPoint, x3y3);
            //graphics.DrawLines(pen, GetPoints().ToArray());

            //рисуем наконечник
            //graphics.DrawLine(pen, EndPoint, x1y1);
            //graphics.DrawLine(pen, x1y1, x3y3);
            //graphics.DrawLine(pen, x3y3, x2y2);
            //graphics.DrawLine(pen, x2y2, EndPoint);         
            Point[] diamondPoints = { EndPoint, x1y1, x3y3, x2y2 };
            graphics.DrawPolygon(pen, diamondPoints);

        }
    }
}
