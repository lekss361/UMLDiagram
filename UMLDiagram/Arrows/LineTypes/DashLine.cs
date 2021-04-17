using System;
using System.Collections.Generic;
using System.Drawing;

using UMLDiagram.Arrows.LineTypes;

namespace UMLDiagram.Arrows.LineTypes
{
    class DashLine : AbstractLine
    {
        
        public override void DrawLine(Graphics graphics, Pen pen, Point end, Point start)
        {
            Pen dashPen = new Pen(pen.Color,pen.Width);
            dashPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            graphics.DrawLine(dashPen, end, start);
        }
       
    }
}
