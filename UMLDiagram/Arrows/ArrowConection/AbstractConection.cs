using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLDiagram.Arrows.FactoryConection;
using UMLDiagram.Arrows.CapTypes;
using UMLDiagram.Arrows.LineTypes;

namespace UMLDiagram.Arrows.ArrowConection
{
    public abstract class AbstractConection: Figur
    {
        public Point StartPoint { get; set; }// начало рисования наконечника
        public Point EndPoint { get; set; }

        public abstract void Draws(Graphics graphics, Pen pen);

        
    }
}
