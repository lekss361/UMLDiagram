using System.Drawing;
using UMLDiagram.Arrows.CapTypes;
using UMLDiagram.Arrows.LineTypes;

namespace UMLDiagram.Arrows.ArrowConection
{
    public abstract class AbstractFigure
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        protected AbstractCap _aCap;
        protected AbstractLine _aLine;

        public void DrawArrow(Graphics graphics, Pen pen)
        {
            _aLine.DrawLine(graphics, pen);
            _aCap.DrawCap(graphics, pen);
        }

    }
}
