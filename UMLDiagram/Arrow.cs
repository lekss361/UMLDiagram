using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLDiagram.Factory;
using UMLDiagram.Arrows.CapTypes;
using UMLDiagram.Arrows.LineTypes;
using System.Drawing;

namespace UMLDiagram
{
    class Arrow : AbstractArrow
    {
        public Arrow(AbstractCap absCap, AbstractLine absLine)
            : base(absCap, absLine)
        {

        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            Point end = _endPoint;
            Point start = _startPoint;

            cap.Draw(graphics, pen, end, start);
            line.DrawLine(graphics, pen, end, start);
        }
    }
}
