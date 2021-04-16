using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLDiagram.Arrows;


namespace UMLDiagram.Arrows.LineTypes
{
    class SolidLine:AbstractLine
    {
        //public SolidLine(Point endPoint, Point stPoint) // нужно ли?
        //{
        //    _endPoint = endPoint;
        //    _startPoint = stPoint;
        //}
        public override void DrawLine(Graphics graphics, Pen pen, Point end, Point start)
        {
            graphics.DrawLine(pen, end, start);
        }
    }
}
