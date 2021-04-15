﻿using System.Drawing;

namespace UMLDiagram.Arrows.CapTypes
{
    public class AssociationCap : AbstractCap
    {
        public override void DrawCap(Graphics graphics, Pen pen)
        {
            //graphics.DrawLines(pen, GetPoints().ToArray());
            Point[] capPoints = GetPoints().ToArray();
            graphics.DrawLine(pen, capPoints[2], capPoints[0]);
            graphics.DrawLine(pen, capPoints[2], capPoints[1]);
        }

    }
}
