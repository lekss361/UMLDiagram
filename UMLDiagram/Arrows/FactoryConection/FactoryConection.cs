using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLDiagram.Arrows.ArrowConection;

namespace UMLDiagram.Arrows.FactoryConection
{
    class FactoryConection
    {
        public Figur figur = new Figur();
        public Graphics graphics;
        public Pen pen;
        public void AssociationConection()
        {
            AbstractConection associationConection = new AssociationConection();
            associationConection.Draws(graphics,pen);
            figur = associationConection;
        }
    }
}
