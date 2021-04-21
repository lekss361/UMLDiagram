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
        static float width;
        static float heigth;

        static Point _startName;
        static Point _startAtr;
        static Point _startMet;

        public static void SetPointForLines(Point st, float heigth, int cAtrL, int cMetL)
        {
            _startName.X = st.X + 10;
            _startName.Y = st.Y;

            int outp = (int)heigth + 20;

            _startAtr.X = st.X + 10;
            _startAtr.Y = st.Y + (int)heigth + 20 ;

            int metP = outp + (cAtrL * (int)heigth + 20);
            _startMet.Y = st.Y  + (int)heigth + 20 + (cAtrL * (int)heigth + 20);
            _startMet.X = st.X + 10;
        }

        public Block()
        {
            
        }
        public Block(Point st, float heigth, int cAtrL, int cMetL)
        {
            SetPointForLines(st, heigth, cAtrL, cMetL);
        }
        public override void DrawBlock(Graphics graphics, Pen pen, Point start, string name, string atr,string met,float width,float heigth, int cAtrL, int cMetL)
        {

            float mult = (cAtrL + cMetL) * heigth + 60;
            float par = mult + 40 + 50 + 70;


            graphics.DrawRectangle(pen, start.X, start.Y,width+10, mult); //основной 
            graphics.DrawRectangle(pen, start.X, start.Y, width+10 , heigth+10); //heigth+10 - высота с именем  

            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
           
            
            graphics.DrawString(name, drawFont, drawBrush, _startName.X , _startName.Y);
            graphics.DrawString(atr, drawFont, drawBrush, _startAtr.X, _startAtr.Y );
            graphics.DrawString(met, drawFont, drawBrush, _startMet.X , _startMet.Y );
            
        }
    }
}
