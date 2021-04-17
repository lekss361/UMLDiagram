
using UMLDiagram.Arrows.CapTypes;
using UMLDiagram.Arrows.LineTypes;
using System.Drawing;

namespace UMLDiagram
{
    public abstract class AbstractArrow
    {
        protected AbstractCap cap;
        protected AbstractLine line;

        public Point _startPoint { get; set; } 
        public Point _endPoint { get; set; }

        public AbstractArrow(AbstractCap absCap, AbstractLine absLine)
        {
            cap = absCap;
            line = absLine;
        }

        public abstract void Draw(Graphics graphics, Pen pen);

    }
}
