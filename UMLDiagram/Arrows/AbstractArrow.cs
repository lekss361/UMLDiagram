using System;
using System.Drawing;
using System.Collections.Generic;

namespace UMLDiagram.Arrows
{
    public abstract class AbstractArrow
    {

        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public double angle { get; set; }
        public double arrow_lenght { get; set; }

        public double arrow_degrees { get; set; }// размах крыльев или острота угла 

        //public double x1 { get; set; }
        //public double y1 { get; set; }
        //public double x2 { get; set; }
        //public double y2 { get; set; }
        //public double x3 { get; set; }
        //public double y3 { get; set; }
        //public double x4 { get; set; }
        //public double y4 { get; set; }

        public List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();

            arrow_lenght = 15;
            arrow_degrees = 300;

            double x1, y1, x2, y2, x3, y3, x4, y4;

            int hightTriangle = Convert.ToInt32(arrow_lenght * Math.Sqrt(3) / 2);

            angle = Math.Atan2(EndPoint.Y - StartPoint.Y, EndPoint.X - StartPoint.X) + Math.PI; // угол поворота линии

            x1 = EndPoint.X + arrow_lenght * Math.Cos(angle - arrow_degrees);
            y1 = EndPoint.Y + arrow_lenght * Math.Sin(angle - arrow_degrees);
            x2 = EndPoint.X + arrow_lenght * Math.Cos(angle + arrow_degrees);
            y2 = EndPoint.Y + arrow_lenght * Math.Sin(angle + arrow_degrees);
            x3 = EndPoint.X - 30 * Math.Cos(angle);
            y3 = EndPoint.Y - 30 * Math.Sin(angle);

            x4 = EndPoint.X + 30 * Math.Cos(angle);
            y4 = EndPoint.Y + 30 * Math.Sin(angle);

            points.Add(new Point(Convert.ToInt32(x1), Convert.ToInt32(y1)));
            points.Add(new Point(Convert.ToInt32(x2), Convert.ToInt32(y2)));
            points.Add(new Point(Convert.ToInt32(x3), Convert.ToInt32(y3)));
            points.Add(new Point(Convert.ToInt32(x4), Convert.ToInt32(y4)));

            return points;
        }

        public abstract void Draw( Graphics graphics, Pen pen);

    }
}
