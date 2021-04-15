using UMLDiagram.Arrows.ArrowConection;
using UMLDiagram.Arrows.CapTypes;
using UMLDiagram.Arrows.LineTypes;

namespace UMLDiagram.Arrows.Factory
{
    public class ImplementationArrow : IFactory
    {
        public AbstractFigure GetFigure()
        {
            return new ConcretArrow(new TriangleCap(), new DashLine());
        }
    }
}
