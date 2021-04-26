using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLDiagram.Arrows.CapTypes;

namespace UMLDiagram.Factory
{
    public class FactoryForCap
    {
        public AbstractCap createCap(ArrowCapType type)
        {
            AbstractCap cap = null;

            switch (type)
            { 
                case ArrowCapType.ArrowCap:
                    cap = new ArrowCap();
                    break;
                case ArrowCapType.TriangleCap:
                    cap = new TriangleCap();
                    break;
                case ArrowCapType.RhombusCap:
                    cap = new RhombusCap();
                    break;
                case ArrowCapType.RhombusFillCap:
                    cap = new RhombusFillCap();
                    break;
                case ArrowCapType.TriangleFillCap:
                    cap = new TriangleFillCap();
                    break;
                default:
                    break;
            }

            return cap;

        }

    }
}
