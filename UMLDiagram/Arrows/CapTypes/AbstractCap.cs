using System;
using System.Collections.Generic;
using System.Drawing;


namespace UMLDiagram.Arrows.CapTypes
{
    public abstract class AbstractCap
    {
        public Point _startPoint { get; set; } 
        public Point _endPoint { get; set; }

        public List<Point> Draw(Graphics graphics, Pen pen, Point startPoint, Point endPoint)
        {
            var points = CalculatePoints(startPoint, endPoint);
            DrawCap(graphics, pen, points, startPoint, endPoint);
            return points;
        }

        protected abstract void DrawCap(Graphics graphics, Pen pen, List<Point> points, Point startPoint, Point endPoint);


        private List<Point> CalculatePoints(Point _startPoint , Point _endPoint)
        {
            List<Point> points = new List<Point>();

            double arrow_lenght = 15;
            double arrow_degrees = 300;

            double x1, y1, x2, y2, x3, y3, x4, y4;


            double angle = Math.Atan2(_startPoint.Y - _endPoint.Y, _startPoint.X - _endPoint.X) + Math.PI; // угол поворота линии

            x1 = _startPoint.X + arrow_lenght * Math.Cos(angle - arrow_degrees);
            y1 = _startPoint.Y + arrow_lenght * Math.Sin(angle - arrow_degrees);

            x2 = _startPoint.X + arrow_lenght * Math.Cos(angle + arrow_degrees);
            y2 = _startPoint.Y + arrow_lenght * Math.Sin(angle + arrow_degrees);

            x3 = _startPoint.X - 30 * Math.Cos(angle);
            y3 = _startPoint.Y - 30 * Math.Sin(angle);

            x4 = _startPoint.X + 30 * Math.Cos(angle);
            y4 = _startPoint.Y + 30 * Math.Sin(angle);

            points.Add(new Point(Convert.ToInt32(x1), Convert.ToInt32(y1)));
            points.Add(new Point(Convert.ToInt32(x3), Convert.ToInt32(y3)));
            points.Add(new Point(Convert.ToInt32(x2), Convert.ToInt32(y2)));
            points.Add(new Point(Convert.ToInt32(x4), Convert.ToInt32(y4)));

            return new List<Point>(points);
        }
    }
}
