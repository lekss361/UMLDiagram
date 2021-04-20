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
        public Point startPoint { get; set; } // like mCur
        public Point endPoint { get; set; }

        public Rectangle mainRect{ get; set; }
        public Rectangle second { get; set; }

        //public string nameClass { get; set; }
        //public string atributesText { get; set; }
        //public string methodsText { get; set; }



        public abstract void DrawBlock(Graphics graphics, Pen pen,Point start,string name,string atr, string met,float width,float heigth);

    }
}
