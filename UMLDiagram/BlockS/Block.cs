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

        static SizeF nameSize;
        static SizeF atributeSize;
        static SizeF methodSize;

        private static void GetSizeOfBlock(string name, string atr, string met, Font strFont, PaintEventArgs e)
        {
            
            Font stringFont = strFont;
            nameSize = new SizeF();
            nameSize = e.Graphics.MeasureString(name, stringFont);
            atributeSize = new SizeF();
            atributeSize = e.Graphics.MeasureString(atr, stringFont);
            methodSize = new SizeF();
            methodSize = e.Graphics.MeasureString(met, stringFont);

        }
        //static string _nameClass = "Class";
        private static float GetWidth(SizeF name,SizeF atr,SizeF met)
        {
            float with;
            if((name.Width >= atr.Width) && (name.Width > met.Width)) // может быть поставить >=  ?
            {
                with = name.Width;
            }
            else if((atr.Width >= met.Width) &&(atr.Width>= name.Width))
            {
                with = atr.Width;
            }
            else
            {
                with = met.Width;
            }
            return with;
        }
        public static float CalculateSizeBlock(string name, string atr, string met, Font strFont, PaintEventArgs e)
        {
            float with;
            GetSizeOfBlock(name, atr, met, strFont, e);
            with = GetWidth(nameSize, atributeSize, methodSize);
            return with;
        }


        public Block()
        {
            nameClass = "Class";
        }
        public override void DrawBlock(Graphics graphics, Pen pen,  Point start, string name, string atr,string met,float width)
        {
           
            graphics.DrawRectangle(pen, start.X, start.Y,width*2,200);
            graphics.DrawRectangle(pen, start.X, start.Y, width*2, 40);
            
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float x = start.X + 40;
            float y = start.Y + 10;
            graphics.DrawString(name, drawFont, drawBrush, start.X + 10, start.Y + 10);
            graphics.DrawString(atr, drawFont, drawBrush, start.X + 10, start.Y + 60);
            graphics.DrawString(met, drawFont, drawBrush, start.X + 10, start.Y + 120);
        }
    }
}
