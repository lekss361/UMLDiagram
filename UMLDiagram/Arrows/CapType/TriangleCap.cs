using System;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace UMLDiagram.Arrows.CapType
{
    public class TriangleCap : AbstractCup
    {
        public override void Draw(Graphics graphics, Pen pen)
        {
            Point[] capPoints = GetPoints().ToArray();
            graphics.DrawLine(pen, capPoints[2], capPoints[0]);
            graphics.DrawLine(pen, capPoints[2], capPoints[1]);
            graphics.DrawLine(pen, capPoints[0], capPoints[1]);
        }
    }
}
