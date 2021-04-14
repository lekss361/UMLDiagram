using System;
using System.Collections.Generic;
using System.Drawing;

namespace UMLDiagram.Arrows.LineTypes
{
    class DashLine : AbstractLine
    {
        public override void DrawLine(Graphics graphics, Pen pen)
        {
            Pen dashPen = new Pen(pen.Color,pen.Width);
            dashPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            graphics.DrawLine(dashPen, StartPoint, EndPoint);
        }
    }
}
