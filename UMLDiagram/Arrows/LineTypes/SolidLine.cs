using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLDiagram.Arrows;


namespace UMLDiagram.Arrows.LineTypes
{
    class SolidLine : AbstractLine
    {
        public override void DrawLine(Graphics graphics, Pen pen, List<Point> points)
        {
            graphics.DrawLines(pen, points.ToArray());
        }
    }
}
