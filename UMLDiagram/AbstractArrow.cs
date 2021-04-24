
using UMLDiagram.Arrows.CapTypes;
using UMLDiagram.Arrows.LineTypes;
using System.Drawing;
using System.Windows.Forms;

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

        //public void Move(Graphics graphics , MouseEventArgs e, Pen pen)
        //{
        //    _endPoint = e.Location;
        //     Draw(graphics, pen);

        //}

    }
}
