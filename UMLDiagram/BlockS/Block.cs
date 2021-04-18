using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagram.BlockS
{
    public class Block : AbstractBlock
    {
        int weigth;
        int heigth;
        //static string _nameClass = "Class";
        public Block()
        {
            nameClass = "Class";
        }
        public override void DrawBlock(Graphics graphics, Pen pen,  Point start, string name, string atr,string met)
        {
           
            graphics.DrawRectangle(pen, start.X, start.Y,150,200);
            graphics.DrawRectangle(pen, start.X, start.Y, 150, 40);
            
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float x = start.X + 40;
            float y = start.Y + 10;
            graphics.DrawString(name, drawFont, drawBrush, start.X + 10, start.Y + 10);
            graphics.DrawString(atr, drawFont, drawBrush, start.X + 10, start.Y + 60);
            graphics.DrawString(atr, drawFont, drawBrush, start.X + 10, start.Y + 120);
        }
    }
}
