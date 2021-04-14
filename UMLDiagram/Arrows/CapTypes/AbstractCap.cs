﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using UMLDiagram.Arrows.ArrowConection;



namespace UMLDiagram.Arrows.CapTypes
{
    public abstract class AbstractCap:AbstractConection
    {
        
        abstract public void GetPoints();
       
        protected List<Point> RealisationGetPoints(Point startPoint)
        {
            List<Point> points = new List<Point>();

            double arrow_lenght = 15;
            double arrow_degrees = 300;

            double x1, y1, x2, y2, x3, y3, x4, y4;


            double angle = Math.Atan2(EndPoint.Y - StartPoint.Y, EndPoint.X - StartPoint.X) + Math.PI; // угол поворота линии

            x1 = EndPoint.X + arrow_lenght * Math.Cos(angle - arrow_degrees);
            y1 = EndPoint.Y + arrow_lenght * Math.Sin(angle - arrow_degrees);
            x2 = EndPoint.X + arrow_lenght * Math.Cos(angle + arrow_degrees);
            y2 = EndPoint.Y + arrow_lenght * Math.Sin(angle + arrow_degrees);
            x3 = EndPoint.X - 30 * Math.Cos(angle);
            y3 = EndPoint.Y - 30 * Math.Sin(angle);

            x4 = EndPoint.X + 30 * Math.Cos(angle);
            y4 = EndPoint.Y + 30 * Math.Sin(angle);

            points.Add(new Point(Convert.ToInt32(x1), Convert.ToInt32(y1)));
            points.Add(new Point(Convert.ToInt32(x3), Convert.ToInt32(y3)));
            points.Add(new Point(Convert.ToInt32(x2), Convert.ToInt32(y2)));
            points.Add(new Point(Convert.ToInt32(x4), Convert.ToInt32(y4)));

            return points;
        }

        public void RealisationDraw(Graphics graphics, Pen pen, List<Point> points)
        {
            graphics.DrawLines(pen,points.ToArray());
        }
    }
}
