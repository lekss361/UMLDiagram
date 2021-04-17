using UMLDiagram.Arrows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UMLDiagram.Factory;

using UMLDiagram.BlockS;

namespace UMLDiagram
{
    public partial class Form1 : Form
    {
        Bitmap _mainBitmap;
        Bitmap _tmpBitmap;
        Graphics _graphics;        

        Pen MinePen = new Pen(Color.Black, 3);

        private bool IsMouseDown = false;
        private Point m_End;
        private Point m_Cur;

        ArrowsBuilder builder;
        AbstractArrow aArrow;

        Block block;

        ArrowLineType typeOfLine;
        ArrowCapType typeOfCap;

        //private List<AbstractArrow> MyLines = new List<AbstractArrow>();
        //List<IFigure> listOfFigure = new List<IFigure>();
        List<AbstractArrow> listOfArrows = new List<AbstractArrow>();


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

            builder = new ArrowsBuilder();
            aArrow = builder.CreateArrow(typeOfCap, typeOfLine);

            aArrow._startPoint = e.Location;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                m_Cur = e.Location;
                aArrow._endPoint = e.Location;

                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);

                aArrow.Draw(_graphics, MinePen);
                //aArrow.Draw(_graphics, MinePen, m_End, m_Cur);

                pictureBox1.Image = _tmpBitmap;

                GC.Collect();
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
            _mainBitmap = _tmpBitmap;
            listOfArrows.Add(aArrow);
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
            typeOfLine = ArrowLineType.SolidLine;
            typeOfCap = ArrowCapType.ArrowCap;
        }

        private void aggregationButton_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.SolidLine;
            typeOfCap = ArrowCapType.RhombusCap;
        }

        private void InheritanceArrow_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.SolidLine;
            typeOfCap = ArrowCapType.TriangleCap;
        }       

        private void implementationButton_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.DashLine;
            typeOfCap = ArrowCapType.TriangleCap;
        }

        private void compositionButton_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.SolidLine;
            typeOfCap = ArrowCapType.RhombusFillCap;
        }

        private void addictionButton_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.SolidLine;
            typeOfCap = ArrowCapType.TriangleFillCap;
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

        private void button2_Click(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);

            foreach (AbstractArrow a in listOfArrows)
            {
                a.Draw(_graphics, MinePen);
            }

            pictureBox1.Image = _mainBitmap;
        }
    }
}
