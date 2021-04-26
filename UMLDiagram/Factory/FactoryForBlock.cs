using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLDiagram.BlockS;

namespace UMLDiagram.Factory
{
    class FactoryForBlock
    {
        public AbstractBlock createBlock(FigureType type)
        {
            AbstractBlock absBlock = null;

            switch (type)
            {
                
                case FigureType.Class:
                    absBlock = new Block();
                    break;
                case FigureType.Interface:
                    absBlock = new InterfaceBlock();
                    break;
                default:
                    break;
            }
            return absBlock;
        }
    }
}
