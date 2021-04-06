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
        protected Pen _pen;        

        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public Color ColorLine { get; set; }
        public int WidthLine { get; set; }

        public bool Flag { get; set; }

        public abstract void Draw(Graphics graphics);

    }
}
