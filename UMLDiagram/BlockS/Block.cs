﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMLDiagram.BlockS
{
    public class Block : AbstractBlock
    {
      

        static Point _startName;
        static Point _startAtr;
        static Point _startMet;

      
        public void SetPointForLines(Point st )
        {
            _startName.X = st.X + 10;
            _startName.Y = st.Y + 5;

            _startAtr.X = st.X + 10;
            _startAtr.Y = st.Y + (int)HeigthFont + 20;

            _startMet.Y = st.Y + (int)HeigthFont + 20 + (NumOfAtributeLines * (int)HeigthFont + 20);
            _startMet.X = st.X + 10;
        }
        

        public Block()
        {
            
        }
        public Block(Point st)
        {
            SetPointForLines(st);
        }
        
        public override void Draw(Graphics graphics, Pen pen)
        {
            PenFigure = pen;
            Point start = startPoint;
            
            float totaLength = ((NumOfAtributeLines + NumOfMethodLines) * HeigthFont) + 80;
            graphics.DrawRectangle(pen, start.X, start.Y, WidthRect + 10, totaLength); //основной 
            graphics.DrawRectangle(pen, start.X, start.Y, WidthRect + 10, HeigthFont + 10); //heigth+10 - высота с именем  

            
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            graphics.DrawString(NameField, drawFont, drawBrush, _startName.X, _startName.Y);
            graphics.DrawString(AtribureField, drawFont, drawBrush, _startAtr.X, _startAtr.Y);
            graphics.DrawString(MethodField, drawFont, drawBrush, _startMet.X, _startMet.Y);
            RegionBlock = new Region(new Rectangle(startPoint.X, startPoint.Y, (int)WidthRect, (int)totaLength));
        }

        public override void DrawBlock(Graphics graphics, Pen pen, Point start, string name, string atr, string met, float width, float heigth, int cAtrL, int cMetL)
        {
            throw new NotImplementedException();
        }
    }
}
