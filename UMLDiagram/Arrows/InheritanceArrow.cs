﻿using System;
using System.Drawing;


namespace UMLDiagram.Arrows
{
    public class InheritanceArrow : AbstractArrow
    {

        public override void Draw(Graphics graphics, Pen pen)
        {
            DrawAssociationLine(graphics, pen);
        }


        private void DrawAssociationLine(Graphics graphics, Pen pen)
        {
            Point x1y1, x2y2, x3y3;

            СalculationOfAngles(EndPoint, StartPoint, out x1y1, out x2y2, out x3y3);

            graphics.DrawLine(pen, EndPoint, StartPoint); // тут рисуем линию 
            graphics.DrawLine(pen, x3y3, x1y1);
            graphics.DrawLine(pen, x3y3, x2y2);
            graphics.DrawLine(pen, x1y1, x2y2);

        }

        protected void СalculationOfAngles(Point mCur, Point mStart, out Point x1y1, out Point x2y2, out Point x3y3)
        {
            arrow_lenght = 15;
            arrow_degrees = 300;
            int hightTriangle = Convert.ToInt32(arrow_lenght * Math.Sqrt(3) / 2);

            angle = Math.Atan2(mCur.Y - mStart.Y, mCur.X - mStart.X) + Math.PI; // угол поворота линии

            x1 = mCur.X + arrow_lenght * Math.Cos(angle - arrow_degrees);
            y1 = mCur.Y + arrow_lenght * Math.Sin(angle - arrow_degrees);
            x2 = mCur.X + arrow_lenght * Math.Cos(angle + arrow_degrees);
            y2 = mCur.Y + arrow_lenght * Math.Sin(angle + arrow_degrees);
            x3 = mCur.X - 30 * Math.Cos(angle);
            y3 = mCur.Y - 30 * Math.Sin(angle);

            x1y1 = new Point(Convert.ToInt32(x1), Convert.ToInt32(y1));
            x2y2 = new Point(Convert.ToInt32(x2), Convert.ToInt32(y2));
            x3y3 = new Point(Convert.ToInt32(x3), Convert.ToInt32(y3));
        }
    }
}
