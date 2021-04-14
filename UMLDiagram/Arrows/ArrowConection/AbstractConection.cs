using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram.Arrows.ArrowConection
{
    public abstract class AbstractConection
    {
        public Point StartPoint { get; set; }// начало рисования наконечника
        public Point EndPoint { get; set; }
    }
}
