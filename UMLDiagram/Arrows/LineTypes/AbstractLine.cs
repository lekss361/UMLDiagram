using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLDiagram.Arrows;

namespace UMLDiagram.Arrows.LineTypes
{
   public abstract class AbstractLine
    {
        //public Point _startPoint { get; set; } // like mCur
        //public Point _endPoint { get; set; } 


        public abstract void DrawLine(Graphics graphics, Pen pen, Point end,Point start);
    }
}
