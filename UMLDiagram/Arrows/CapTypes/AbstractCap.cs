using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace UMLDiagram.Arrows.CapTypes
{
    public abstract class AbstractCap
    {
        public Point StartPoint { get; set; }// начало рисования наконечника
         public List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();

            double arrow_lenght = 15;
            double arrow_degrees = 300;

            double x1, y1, x2, y2, x3, y3, x4, y4;

            int hightTriangle = Convert.ToInt32(arrow_lenght * Math.Sqrt(3) / 2);

            double angle = Math.Atan2(StartPoint.Y - StartPoint.Y, StartPoint.X - StartPoint.X) + Math.PI; // угол поворота линии

            x1 = StartPoint.X + arrow_lenght * Math.Cos(angle - arrow_degrees);
            y1 = StartPoint.Y + arrow_lenght * Math.Sin(angle - arrow_degrees);
            x2 = StartPoint.X + arrow_lenght * Math.Cos(angle + arrow_degrees);
            y2 = StartPoint.Y + arrow_lenght * Math.Sin(angle + arrow_degrees);
            x3 = StartPoint.X - 30 * Math.Cos(angle);
            y3 = StartPoint.Y - 30 * Math.Sin(angle);

            x4 = StartPoint.X + 30 * Math.Cos(angle);
            y4 = StartPoint.Y + 30 * Math.Sin(angle);

            points.Add(new Point(Convert.ToInt32(x1), Convert.ToInt32(y1)));
            points.Add(new Point(Convert.ToInt32(x2), Convert.ToInt32(y2)));
            points.Add(new Point(Convert.ToInt32(x3), Convert.ToInt32(y3)));
            points.Add(new Point(Convert.ToInt32(x4), Convert.ToInt32(y4)));

            return points;
        }

        public void Draw(Graphics graphics, Pen pen, List<Point> points)
        {
            graphics.DrawLines(pen,points.ToArray());
        }
    }
}
