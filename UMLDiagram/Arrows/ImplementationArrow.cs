using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram.Arrows
{
    public class ImplementationArrow : AbstractArrow
    {
        public ImplementationArrow()
        {

        }
        public override void Draw(Point mCur, Point mStart, bool mouseDown, Graphics graphics, Pen pen)
        {
            throw new NotImplementedException();
        }

        public override void Draw(Point mCur, Point mStart, bool mouseDown, Graphics graphics, Pen penForLine, Pen penForF)
        {
            throw new NotImplementedException();
        }

        public override void DrawCurvedLine(Graphics graphics)
        {
            throw new NotImplementedException();
        }
    }
}
