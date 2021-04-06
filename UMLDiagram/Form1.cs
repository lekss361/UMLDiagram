using UMLDiagram.Arrows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace UMLDiagram
{
    public partial class Form1 : Form
    {
        Bitmap _mainBitmap;
        Bitmap _tmpBitmap;
        Graphics _graphics;
        Pen MinePen = new Pen(Color.Black, 9);
        
        private bool IsMouseDown = false;
        private Point m_Start;
        private Point m_Cur;

        private List<LineList> MyLines = new List<LineList>();

        AbstractArrow _associationArrow;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;

            _associationArrow = new AssociationArrow();

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;

            m_Start = e.Location;
            _associationArrow.StartPoint = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);

                m_Cur = e.Location;  
                _associationArrow.EndPoint = e.Location;

                _associationArrow.Draw(_graphics);

                pictureBox1.Image = _tmpBitmap;

                GC.Collect();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            IsMouseDown = false;
            
            _mainBitmap = _tmpBitmap;
            MyLines.Add(new LineList(m_Start,m_Cur,MinePen.Color,MinePen.Width, MinePen.DashStyle));        
        }

        private void SwitchColorPaintig(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();          

            //MinePen.Color = colorDialog1.Color;
            _associationArrow.ColorLine = colorDialog1.Color;
            _associationArrow.Flag = true;
            //colorLineButton.BackColor = colorDialog1.Color;
        }

        private void SwitchWeightPaintig(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
                //MinePen.Width = Convert.ToInt32(toolStripMenuItem.Text);
                _associationArrow.WidthLine= Convert.ToInt32(toolStripMenuItem.Text);
            }
        }


        private void associationButton_Click(object sender, EventArgs e)
        {
            _associationArrow = new AssociationArrow();
        }


    }
}
