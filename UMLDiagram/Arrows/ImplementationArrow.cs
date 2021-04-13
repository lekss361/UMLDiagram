﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace UMLDiagram.Arrows
{
    public class ImplementationArrow : AbstractArrow
    {

        public override void Draw(Graphics graphics, Pen pen)
        {
            DrawAssociationLine(graphics, pen);
        }

        private void DrawAssociationLine(Graphics graphics, Pen pen)
        {

            Pen dashPen = new Pen(pen.Color, pen.Width);
            dashPen.DashStyle = DashStyle.Dash;

            graphics.DrawLine(dashPen, EndPoint, StartPoint); // тут рисуем линию 
            //graphics.DrawLine(pen, x3y3, x1y1);
            //graphics.DrawLine(pen, x3y3, x2y2);
            //graphics.DrawLine(pen, x1y1, x2y2);

            Point[] capPoints = GetPoints().ToArray();
            graphics.DrawLine(pen, capPoints[2], capPoints[0]);
            graphics.DrawLine(pen, capPoints[2], capPoints[1]);
            graphics.DrawLine(pen, capPoints[0], capPoints[1]);

        }

    }
}
