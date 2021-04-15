using UMLDiagram.Arrows.CapTypes;
using UMLDiagram.Arrows.LineTypes;


namespace UMLDiagram.Arrows.ArrowConection
{
    class ConcretArrow : AbstractFigure
    {
        public ConcretArrow(AbstractCap aCap, AbstractLine aLine)
        {
            _aCap = aCap;
            _aLine = aLine;
        }
    }
}
//SolidLine solidLine = new SolidLine();
//AssociationCap arrowCap = new AssociationCap();


//public void  DrawAssociationConection(Graphics graphics, Pen pen)
//{
//    solidLine.DrawLine(graphics, pen);
//    arrowCap.Draw(graphics, pen);
//}