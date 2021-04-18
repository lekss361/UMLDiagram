using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram.Factory
{
    public interface IFactory
    {
        AbstractArrow CreateArrow(ArrowLineType arrowType);
    }
}
