using System.Drawing.Imaging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UMLDiagram.Factory;


using UMLDiagram.BlockS;
using System.Diagnostics;

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

        ArrowLineType typeOfLine;
        ArrowCapType typeOfCap;

        string action = "";

        Block block1;
        public static float  width1{ get; set; }
        public static float height1 { get; set; }

        public static int LinesAtr { get; set; }
        public static int LinesMet { get; set; }

        //private List<AbstractArrow> MyLines = new List<AbstractArrow>();
        //List<IFigure> listOfFigure = new List<IFigure>();
        List<AbstractArrow> listOfArrows = new List<AbstractArrow>();

        public Form1()
        {
            InitializeComponent();
        }
        public void SetPropety(string nameF, string atributF,string methodsF,Font font)
        {
            // block1.NameField = nameF;
            block1.NameField = nameF;

            block1.AtribureField = atributF;
            block1.MethodField = methodsF;
            block1.drawFont = font;

        }
       

        public void SetWidthAndHeist(float wid, float heig)
        {
            block1.WidthRect = wid;
            block1.HeigthFont = heig;
        }

        public void SetCountLines(int atr, int met)
        {
            block1.NumOfAtributeLines = atr;
            block1.NumOfMethodLines = met;
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
            if (action.Equals("Class"))
            {
                block1.SetPointForLines(e.Location);
            }
            else if (action.Equals("Arrow"))
            {

                builder = new ArrowsBuilder();
                aArrow = builder.CreateArrow(typeOfCap, typeOfLine);

                aArrow._startPoint = e.Location;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                m_Cur = e.Location;
                // block1.SetPointForLines(e.Location);

                //switch (action)
                //{
                //    case "Class":


                //        block1.SetPointForLines(e.Location);
                //        block1.DrawBlock(_graphics, MinePen, m_Cur);

                //        break;
                //    case "Arrow":


                //        aArrow._endPoint = e.Location;
                //        aArrow.Draw(_graphics, MinePen);

                //        break;

                //    default:
                //        break;
                //}

                aArrow.Draw(_graphics, MinePen);
                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);

               

               
               //block1.DrawBlock(_graphics, MinePen, e.Location);
                pictureBox1.Image = _tmpBitmap;
                if (GC.GetTotalMemory(true) > 1073741824)
                {
                    GC.Collect();
                }
                
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
            _mainBitmap = _tmpBitmap;
            if (action.Equals("Class"))
            {
                block1.NameField = null;
                block1.AtribureField = null;
                block1.MethodField = null;
            }
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
            action = "Arrow";
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
            action = "Arrow";
        }

        private void implementationButton_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.DashLine;
            typeOfCap = ArrowCapType.TriangleCap;
            action = "Arrow";
        }

        private void compositionButton_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.SolidLine;
            typeOfCap = ArrowCapType.RhombusFillCap;
            action = "Arrow";
        }

        private void addictionButton_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.SolidLine;
            typeOfCap = ArrowCapType.TriangleFillCap;
            action = "Arrow";
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
            action = "Class";
            block1 = new Block();
            var form = new PropertyForBlock(this);
            form.Show();
        }
            

        private void button2_Click(object sender, EventArgs e)
        {
            //var form = new PropertyForBlock(this);
            //form.Show();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Class Diagram Files|*.umldiagram|JPeg Image|*.jpg";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        _mainBitmap.Save(saveFileDialog1.FileName);
                        break;

                    case 2:
                        _mainBitmap.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                        break;
                }
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                _mainBitmap = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = _mainBitmap;
            }
        }


    }
}
