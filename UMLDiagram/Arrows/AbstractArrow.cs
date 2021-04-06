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
        public Point StartPoint { get; set; }
        public Point EndtPoint { get; set; }

        public abstract void Draw(Graphics graphics);
    }
}
