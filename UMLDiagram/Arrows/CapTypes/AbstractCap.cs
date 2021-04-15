using System;
using System.Collections.Generic;
using System.Drawing;
using UMLDiagram.Arrows.ArrowConection;


namespace UMLDiagram.Arrows.CapTypes
{
    public abstract class AbstractCap
    {
        protected AbstractFigure aFigure;

        public abstract void DrawCap(Graphics graphics, Pen pen);

        public List<Point> GetPoints()
        {

            List<Point> points = new List<Point>();

            double arrow_lenght = 15;
            double arrow_degrees = 300;

            double x1, y1, x2, y2, x3, y3, x4, y4;

            double angle = Math.Atan2(aFigure.EndPoint.Y - aFigure.StartPoint.Y, aFigure.EndPoint.X - aFigure.StartPoint.X) + Math.PI; // угол поворота линии

            x1 = aFigure.EndPoint.X + arrow_lenght * Math.Cos(angle - arrow_degrees);
            y1 = aFigure.EndPoint.Y + arrow_lenght * Math.Sin(angle - arrow_degrees);
            x2 = aFigure.EndPoint.X + arrow_lenght * Math.Cos(angle + arrow_degrees);
            y2 = aFigure.EndPoint.Y + arrow_lenght * Math.Sin(angle + arrow_degrees);
            x3 = aFigure.EndPoint.X - 30 * Math.Cos(angle);
            y3 = aFigure.EndPoint.Y - 30 * Math.Sin(angle);

            x4 = aFigure.EndPoint.X + 30 * Math.Cos(angle);
            y4 = aFigure.EndPoint.Y + 30 * Math.Sin(angle);

            points.Add(new Point(Convert.ToInt32(x1), Convert.ToInt32(y1)));
            points.Add(new Point(Convert.ToInt32(x2), Convert.ToInt32(y2)));
            points.Add(new Point(Convert.ToInt32(x3), Convert.ToInt32(y3)));
            points.Add(new Point(Convert.ToInt32(x4), Convert.ToInt32(y4)));

            return points;
        }

    }
}
