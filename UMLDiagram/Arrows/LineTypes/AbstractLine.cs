using System;
using System.Collections.Generic;
using System.Drawing;

namespace UMLDiagram.Arrows.LineTypes
{
   public abstract class AbstractLine
    {
        public abstract void DrawLine(Graphics graphics, Pen pen, Point end,Point start);
    }
}
