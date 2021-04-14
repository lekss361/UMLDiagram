using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLDiagram.Arrows.ArrowConection;


namespace UMLDiagram.Arrows.LineTypes
{
    class SolidLine:AbstractLine
    {
        public override void DrawLine(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, StartPoint, EndPoint);
        }
    }
}
