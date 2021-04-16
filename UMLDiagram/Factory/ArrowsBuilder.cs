using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLDiagram.Arrows.CapTypes;
using UMLDiagram.Arrows.LineTypes;

namespace UMLDiagram.Factory
{
    public class ArrowsBuilder : IFactory
    {
        //public AbstractArrow GetFigure()
        //{
        //    //return new ConcretArrow(new AssociationCap(), new SolidLine());
        //    return new Arrow(cap, line);
        //}

        public AbstractArrow CreateArrow(ArrowLineType arrowType)
        {
            AbstractCap cap = null;
            AbstractLine line = null;

            switch (arrowType)
            {
                case ArrowLineType.inheritanceArrow:
                    cap = new TriangleCap();
                    line = new SolidLine();
                    break;
                case ArrowLineType.associationArrow:
                    cap = new ArrowCap();
                    line = new SolidLine();
                    break;
                case ArrowLineType.addictionArrow:
                    cap = new ArrowCap();
                    line = new DashLine();
                    break;
                case ArrowLineType.aggregationArrow:
                    cap = new RhombusCap();
                    line = new SolidLine();
                    break;
                case ArrowLineType.implementationArrow:
                    cap = new TriangleCap();
                    line = new DashLine();
                    break;
                case ArrowLineType.composition:
                    cap = new RhombusFillCap();
                    line = new SolidLine();
                    break;
                default:
                    break;
            }

            return new Arrow(cap, line);
        }


    }
}
