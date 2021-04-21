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
       //protected List<AbstactModule> _modules;
        public Point startPoint { get; set; } // like mCur
        public Point endPoint { get; set; }

        public Rectangle mainRect{ get; set; }
        public Rectangle secondRect { get; set; }

        public static string NameField { get; set; }
        public static string AtribureField { get; set; }
        public static string MethodField { get; set; }
        public static Font font { get; set; }

        public static float WidthRect { get; set; }
        public static float HeigthFont { get; set; }

        public static int NumOfAtributeLines { get; set; }
        public static int NumOfMethodLines { get; set; }





        



        public abstract void DrawBlock(Graphics graphics, Pen pen,Point start,string name,string atr, string met,float width,float heigth, int cAtrL,int cMetL);
        public abstract void DrawBlock(Graphics graphics, Pen pen, Point start);
    }
}
