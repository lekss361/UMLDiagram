    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLDiagram.Arrows.LineTypes;

namespace UMLDiagram.Factory
{
    class FactoryForLine
    {
        public AbstractLine createLine(string type)
        {
            AbstractLine line = null;
            switch (type)
            {
                case "DashLine":
                    line = new DashLine();
                    break;
                case "SolidLine":
                    line = new SolidLine();
                    break;
                default:
                    break;
            }



            return line;
        }
    }
}
