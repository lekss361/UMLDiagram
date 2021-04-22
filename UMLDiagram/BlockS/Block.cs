using System;
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
        //static float width;
        //static float heigth;

        static Point _startName;
        static Point _startAtr;
        static Point _startMet;

        //public static void SetPointForLines(Point st, float heigth, int cAtrL, int cMetL)
        //{
        //    _startName.X = st.X + 10;
        //    _startName.Y = st.Y;

        //    _startAtr.X = st.X + 10;
        //    _startAtr.Y = st.Y + (int)heigth + 20 ;
           
        //    _startMet.Y = st.Y  + (int)heigth + 20 + (cAtrL * (int)heigth + 20);
        //    _startMet.X = st.X + 10;
        //}
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
        //public override void DrawBlock(Graphics graphics, Pen pen, Point start, string name, string atr,string met,float width,float heigth, int cAtrL, int cMetL)
        //{

        //    float mult = (cAtrL + cMetL) * heigth + 60;



        //    graphics.DrawRectangle(pen, start.X, start.Y,width+10, mult); //основной 
        //    graphics.DrawRectangle(pen, start.X, start.Y, width+10 , heigth+10); //heigth+10 - высота с именем  

        //    Font drawFont = new Font("Arial", 8);
        //    SolidBrush drawBrush = new SolidBrush(Color.Black);


        //    graphics.DrawString(name, drawFont, drawBrush, _startName.X , _startName.Y);
        //    graphics.DrawString(atr, drawFont, drawBrush, _startAtr.X, _startAtr.Y );
        //    graphics.DrawString(met, drawFont, drawBrush, _startMet.X , _startMet.Y );

        //}
        public override void DrawBlock(Graphics graphics, Pen pen, Point start)
        {

            float totaLength = (NumOfAtributeLines + NumOfMethodLines) * HeigthFont + 60;

            graphics.DrawRectangle(pen, start.X, start.Y, WidthRect + 10, totaLength); //основной 
            graphics.DrawRectangle(pen, start.X, start.Y, WidthRect + 10, HeigthFont + 10); //heigth+10 - высота с именем  

            //Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            graphics.DrawString(NameField, drawFont, drawBrush, _startName.X, _startName.Y);
             graphics.DrawString(AtribureField, drawFont, drawBrush, _startAtr.X, _startAtr.Y);
            graphics.DrawString(MethodField, drawFont, drawBrush, _startMet.X, _startMet.Y);
        }

        public override void DrawBlock(Graphics graphics, Pen pen, Point start, string name, string atr, string met, float width, float heigth, int cAtrL, int cMetL)
        {
            throw new NotImplementedException();
        }
    }
}
