using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLDiagram.Arrows.CapTypes;

namespace UMLDiagram.Factory
{
   public  class FactoryForCap
    {
        public AbstractCap createCap(string type) //как передавать тип?

        {
            AbstractCap cap = null;

            switch (type)
            {
                case "ArrowCap":
                    cap = new ArrowCap(); 
                    break;
                case "TriangleCap":
                    cap = new TriangleCap();
                    break;
                case "RhombusCap":
                    cap = new RhombusCap();
                    break;
                case "RhombusFillCap":
                    cap = new RhombusFillCap();
                    break;
                case "TriangleFillCap":
                    cap = new TriangleFillCap();
                    break;
                default:
                    break;
            }

            return cap;

        }

    }
}
