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
        public AbstractLine createLine(ArrowLineType type)
        {
            AbstractLine line = null;

            switch (type)
            {
                case ArrowLineType.DashLine:
                    line = new DashLine();
                    break;
                case ArrowLineType.SolidLine:
                    line = new SolidLine();
                    break;
                default:
                    break;
            }

            return line;
        }
    }
}
