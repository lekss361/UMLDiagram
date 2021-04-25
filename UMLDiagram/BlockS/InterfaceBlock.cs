using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram.BlockS
{
    class InterfaceBlock : AbstractBlock
    {
        static Point _startName;
        static Point _startAtr;
        static Point _startMet;
        static Point _interfaceStringPoint;
        string interf = "Interface";
        public InterfaceBlock()
        {

        }
        public override void Draw(Graphics graphics, Pen pen)
        {
            Point start = startPoint;
            

            float totaLength = ((NumOfAtributeLines + NumOfMethodLines) * HeigthFont) + 100;
            graphics.DrawRectangle(pen, start.X, start.Y, WidthRect + 10, totaLength); //основной 
            graphics.DrawRectangle(pen, start.X, start.Y, WidthRect + 10, (HeigthFont * 2)+ 10); //heigth+10 - высота с именем  


            SolidBrush drawBrush = new SolidBrush(Color.Black);
            graphics.DrawString(interf, drawFont, drawBrush, _interfaceStringPoint.X, _interfaceStringPoint.Y);
            graphics.DrawString(NameField, drawFont, drawBrush, _startName.X, _startName.Y);
            graphics.DrawString(AtribureField, drawFont, drawBrush, _startAtr.X, _startAtr.Y);
            graphics.DrawString(MethodField, drawFont, drawBrush, _startMet.X, _startMet.Y);
        }

        public override void SetPointForLines(Point st)
        {
            _interfaceStringPoint.X = st.X + 10;
            _interfaceStringPoint.Y = st.Y + 5;

            _startName.X = st.X + 10;
            _startName.Y = st.Y + (int)HeigthFont + 5 ;

            _startAtr.X = st.X + 10;
            _startAtr.Y = st.Y + ((int)HeigthFont *2 ) + 20;

            _startMet.Y = st.Y + ((int)HeigthFont * 2) + 20 + (NumOfAtributeLines * (int)HeigthFont + 20);
            _startMet.X = st.X + 10;
        }
    }
}
