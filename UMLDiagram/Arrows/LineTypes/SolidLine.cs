using System;
using System.Collections.Generic;
using System.Drawing;


namespace UMLDiagram.Arrows.LineTypes
{
    class SolidLine:AbstractLine
    {
        public override void DrawLine(Graphics graphics, Pen pen, Point end, Point start)
        {
            graphics.DrawLine(pen, end, start);
        }
    }
}
