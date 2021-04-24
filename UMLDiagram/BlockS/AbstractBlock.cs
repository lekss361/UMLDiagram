﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace UMLDiagram.BlockS
{
    public abstract class AbstractBlock 
    {
       //protected List<AbstactModule> _modules;
        public Point startPoint { get; set; } // like mCur
        public Point endPoint { get; set; }

        public Rectangle mainRect{ get; set; }
        public Rectangle secondRect { get; set; }

        public string NameField { get; set; }
        public string AtribureField { get; set; }
        public string MethodField { get; set; }

        public Point _startName;
        public Point _startAtr;
        public Point _startMet;

        public Font drawFont { get; set; }

        public float WidthRect { get; set; }
        public float HeigthFont { get; set; }

        public int NumOfAtributeLines { get; set; }
        public int NumOfMethodLines { get; set; }
        //public  void Move(Graphics graphics, MouseEventArgs e, Pen pen)
        //{
          
        //   startPoint = e.Location;
        //   DrawBlock(graphics, pen, e.Location);
            

        //}
        public abstract void DrawBlock(Graphics graphics, Pen pen,Point start,string name,string atr, string met,float width,float heigth, int cAtrL,int cMetL);
        public abstract void DrawBlock(Graphics graphics, Pen pen, Point start);
    }
}
