using System.Drawing;
using UMLDiagram.Arrows.ArrowConection;

namespace UMLDiagram.Arrows.LineTypes
{

    public abstract class AbstractLine
    {
        protected AbstractFigure aFigure;

        public abstract void DrawLine(Graphics graphics, Pen pen);
    }
}
