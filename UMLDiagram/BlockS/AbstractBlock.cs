using UMLDiagram.Arrows.CapTypes;
using UMLDiagram.Arrows.LineTypes;
using System.Drawing;
using System.Collections.Generic;
using System;

namespace UMLDiagram.BlockS
{
    public abstract class AbstractBlock : IFigure
    {
       //protected List<AbstactModule> _modules;
        public Point startPoint { get; set; } // like mCur
        public Point endPoint { get; set; }

        public Rectangle mainRect{ get; set; }
        public Rectangle secondRect { get; set; }

        public string NameField { get; set; }
        public string AtribureField { get; set; }
        public string MethodField { get; set; }
        public Font drawFont { get; set; }

        public float WidthRect { get; set; }
        public float HeigthFont { get; set; }

        public int NumOfAtributeLines { get; set; }
        public int NumOfMethodLines { get; set; }

        public Pen PenFigure { get; set; }

        public Region RegionBlock { get; set; }

        public abstract void DrawBlock(Graphics graphics, Pen pen,Point start,string name,string atr, string met,float width,float heigth, int cAtrL,int cMetL);
        //public abstract void DrawBlock(Graphics graphics, Pen pen, Point start);
        public abstract void Draw(Graphics graphics, Pen pen);

        public bool SelectFigure(Point point)
        {
            //if ()
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return true;
        }

        public void Move(int deltaX, int deltaY)
        {
            //startPoint = new Point(startPoint.X + deltaX, startPoint.Y + deltaY);
            //endPoint = new Point(endPoint.X + deltaX, endPoint.Y + deltaY);
        }

    }
}
