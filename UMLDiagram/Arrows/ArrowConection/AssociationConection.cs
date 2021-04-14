using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLDiagram.Arrows.LineTypes;
using UMLDiagram.Arrows.CapTypes;

namespace UMLDiagram.Arrows.ArrowConection
{
    class AssociationConection:AbstractConection
    {
        SolidLine solidLine = new SolidLine();
        ArrowCap arrowCap = new ArrowCap();
        
        
        public void  DrawAssociationConection(Graphics graphics, Pen pen)
        {
            solidLine.DrawLine(graphics, pen);
            arrowCap.Draw(graphics, pen);
        }
    }
}
