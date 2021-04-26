using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram
{
    public enum ArrowLineType
    {
        DashLine = 0,
        SolidLine
    }

    public enum ArrowCapType
    {
        ArrowCap = 0,
        TriangleCap,
        RhombusCap,
        RhombusFillCap,
        TriangleFillCap
    }

    public enum FigureType
    {
        Arrow = 0,
        Class ,
        Interface
    }

}
