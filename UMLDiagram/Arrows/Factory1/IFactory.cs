
using UMLDiagram.Arrows.ArrowConection;


namespace UMLDiagram.Arrows.Factory
{
    public interface IFactory
    {
        AbstractFigure GetFigure();
    }
}
