using UMLDiagram.Arrows.ArrowConection;
using UMLDiagram.Arrows.CapTypes;
using UMLDiagram.Arrows.LineTypes;

namespace UMLDiagram.Arrows.Factory
{
    public class CompositionFactory : IFactory
    {
        public AbstractFigure GetFigure()
        {
            return new ConcretArrow(new RhombusFillCap(), new SolidLine());
        }
    }
}
