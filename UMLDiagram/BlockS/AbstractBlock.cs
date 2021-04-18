using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UMLDiagram.BlockS
{
    public abstract class AbstractBlock 
    {
        public Point _startPoint { get; set; } // like mCur
        public Point _endPoint { get; set; }

        public Rectangle _mainRect{ get; set; }
        public Rectangle _second { get; set; }

        public string _nameClass { get; set; }



        public abstract void DrawBlock(Graphics graphics, Pen pen,  Point start);

    }
}
