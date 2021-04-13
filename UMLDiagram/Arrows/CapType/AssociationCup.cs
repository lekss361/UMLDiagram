using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace UMLDiagram.Arrows.CapType
{
    public class AssociationCup : AbstractCup
    {
        public override void Draw(Graphics graphics, Pen pen)
        {
            Point[] capPoints = GetPoints().ToArray();
            graphics.DrawLine(pen, capPoints[2], capPoints[0]);
            graphics.DrawLine(pen, capPoints[2], capPoints[1]);
        }
    }
}
