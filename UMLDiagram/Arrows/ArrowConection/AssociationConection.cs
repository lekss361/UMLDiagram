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
   public class AssociationConection:AbstractConection
    {
        SolidLine solidLine = new SolidLine();
        ArrowCap arrowCap = new ArrowCap();

       
        public override void Draws(Graphics graphics, Pen pen)
        {
            arrowCap.GetPoints();
            solidLine.DrawLine(graphics, pen);
            arrowCap.Draw(graphics, pen);
        }
    }
}
