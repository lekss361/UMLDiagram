using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UMLDiagram.Arrows
{
    public abstract class AbstractArrow
    {
        Point StartPoint { get; set; }
        Point EndPoint { get; set; }
        public abstract void Draw(Graphics graphics);


        
        
    }
}
