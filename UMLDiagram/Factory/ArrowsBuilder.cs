using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLDiagram.Arrows.CapTypes;
using UMLDiagram.Arrows.LineTypes;

namespace UMLDiagram.Factory
{
    class ArrowsBuilder
    {
        private FactoryForCap factoryForCap;
        private FactoryForLine factoryForLine;

        public ArrowsBuilder()
        {
            factoryForCap = new FactoryForCap();
            factoryForLine = new FactoryForLine();
        }

        public AbstractArrow CreateArrow(ArrowCapType typeForCap, ArrowLineType typeForLine)
        {
            AbstractCap cap = factoryForCap.createCap(typeForCap);
            AbstractLine line = factoryForLine.createLine(typeForLine);

            return new Arrow(cap, line);
        }
    }
}