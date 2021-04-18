using UMLDiagram.Arrows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UMLDiagram.Factory;
using UMLDiagram.Arrows;

using UMLDiagram.BlockS;

namespace UMLDiagram
{
    public partial class Form1 : Form
    {
        Bitmap _mainBitmap;
        Bitmap _tmpBitmap;
        Graphics _graphics;
        List<IFigure> listOfFigure = new List<IFigure> ();

        Pen MinePen = new Pen(Color.Black, 3);

        private bool IsMouseDown = false;
        private Point m_End;
        private Point m_Cur;
        ArrowsBuilder builder;

        string typeOfLine = "";
        string typeOfCap = "";
        Block block;






        private List<AbstractArrow> MyLines = new List<AbstractArrow>();

        

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

           
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            m_End = e.Location;
            //_tmpBitmap = (Bitmap)_mainBitmap.Clone();
            //_graphics = Graphics.FromImage(_tmpBitmap);

            //block.DrawBlock(_graphics, MinePen, m_End);
            //pictureBox1.Image = _tmpBitmap;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                m_Cur = e.Location;

                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);

                //block.DrawBlock(_graphics, MinePen, m_End, m_Cur);



                //builder = new ArrowsBuilder();
                //var arrow = builder.CreateArrow(typeOfCap, typeOfLine);
                //arrow.Draw(_graphics, MinePen, m_End, m_Cur);
                //block.DrawBlock(_graphics, MinePen, m_End);
                block.DrawBlock(_graphics, MinePen, e.Location);


                //listOfFigure.Add(arrow);

                pictureBox1.Image = _tmpBitmap;


                GC.Collect();
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
            //_tmpBitmap = (Bitmap)_mainBitmap.Clone();
            //_graphics = Graphics.FromImage(_tmpBitmap);

            //block.DrawBlock(_graphics, MinePen, m_End, m_Cur);
            //pictureBox1.Image = _tmpBitmap;
            var form = new PropertyForBlock();
            form.Show();
            block._nameClass = form.GetName();
            _mainBitmap = _tmpBitmap;
        }

        private void SwitchColorPaintig(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();          

            MinePen.Color = colorDialog1.Color;
        }

        private void SwitchWeightPaintig(object sender, EventArgs e)
        {
            MinePen.Width = trackBarWidth.Value;
        }




        private void associationButton_Click(object sender, EventArgs e)
        {
            typeOfLine = "SolidLine";
            typeOfCap = "ArrowCap";




        }

        private void aggregationButton_Click(object sender, EventArgs e)
        {
            typeOfLine = "SolidLine";
            typeOfCap = "RhombusCap";
        }

        private void InheritanceArrow_Click(object sender, EventArgs e)
        {
            
            typeOfLine = "SolidLine";
            typeOfCap = "TriangleCap";
        }       

        private void implementationButton_Click(object sender, EventArgs e)
        {
            typeOfLine = "DashLine";
            typeOfCap = "TriangleCap";
        }

        private void compositionButton_Click(object sender, EventArgs e)
        {
            typeOfLine = "SolidLine";
            typeOfCap = "RhombusFillCap";
        }

        private void addictionButton_Click(object sender, EventArgs e)
        {
            typeOfLine = "SolidLine";
            typeOfCap = "TriangleFillCap";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;
        }

        private void buttonClass_Click(object sender, EventArgs e)
        {
             block = new Block();
        }
    }
}
