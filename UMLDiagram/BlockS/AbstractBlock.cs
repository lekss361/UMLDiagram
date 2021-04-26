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


        public abstract void SetPointForLines(Point st);
        public abstract void Draw(Graphics graphics, Pen pen);

        public bool SelectFigure(Point point)
        {
            int height = (int)((NumOfAtributeLines + NumOfMethodLines) * HeigthFont) + 80;
            int width = (int)(WidthRect + 10);

            if (point.X <= (startPoint.X + width) && point.X >= startPoint.X
             && point.Y <= (startPoint.Y + height) && point.Y >= startPoint.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public void Move(int deltaX, int deltaY)
        //{
        //    startPoint = new Point(startPoint.X + deltaX, startPoint.Y + deltaY);
        //}

        public void MoveStartPoint(int deltaX, int deltaY)
        {
            startPoint = new Point(startPoint.X + deltaX, startPoint.Y + deltaY);
        }

        public void MoveEndPoint(int deltaX, int deltaY)
        {
            //endPoint = new Point(endPoint.X + deltaX, endPoint.Y + deltaY);
        }
    }
}
