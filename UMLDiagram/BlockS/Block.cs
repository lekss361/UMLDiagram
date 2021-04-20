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

        public Block()
        {
            
        }
        public override void DrawBlock(Graphics graphics, Pen pen, Point start, string name, string atr,string met,float width,float heigth)
        {
           
            graphics.DrawRectangle(pen, start.X, start.Y,width*2, 200);
            graphics.DrawRectangle(pen, start.X, start.Y, width*2, 40);
            
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float x = start.X + 40;
            float y = start.Y + 10;
            graphics.DrawString(name, drawFont, drawBrush, start.X + 10, start.Y + 10);
            graphics.DrawString(atr, drawFont, drawBrush, start.X + 10, start.Y + 60);
            graphics.DrawString(met, drawFont, drawBrush, start.X + 10, start.Y + 120);
           // TextRenderer.DrawText(graphics, met, drawFont, start, Color.Red);
        }
    }
}
