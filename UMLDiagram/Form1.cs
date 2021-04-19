using System.Drawing.Imaging;
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

        ArrowLineType typeOfLine;
        ArrowCapType typeOfCap;

        Block block1;

        public static string nameClass { get; set; }
        public static string atributes { get; set; }
        public static string methods { get; set; }


        static string classN;

        //private List<AbstractArrow> MyLines = new List<AbstractArrow>();
        //List<IFigure> listOfFigure = new List<IFigure>();
        List<AbstractArrow> listOfArrows = new List<AbstractArrow>();

        List<Point> startAndEndLinePoints = new List<Point>();
        bool pointFocused;
        Point pointFocus;

        public Form1()
        {
            InitializeComponent();
            pointFocused = false;
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

                //block1.DrawBlock(_graphics, MinePen, e.Location, classN, atributes , methods);

                pictureBox1.Image = _tmpBitmap;
                GC.Collect();
            }
            else
            {
                pointFocused = false;
                pointFocus = new Point();

                for (int i=0; i < startAndEndLinePoints.Count; i++)
                {
                    if (Math.Abs(startAndEndLinePoints[i].X - e.Location.X) < 2 
                        & Math.Abs(startAndEndLinePoints[i].Y - e.Location.Y) < 2)
                    //if (startAndEndLinePoints.Contains(e.Location))
                    {
                        pointFocused = true;
                        pointFocus = e.Location;
                    }
                }
            }
            if (pointFocused == true)
            {
                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);

                Pen FocusPen = new Pen(Color.Red, 5);
                int focusWidth = trackBarWidth.Value;

                //_graphics.DrawRectangle(FocusPen, pointFocus.X-3, pointFocus.Y - 3, 6, 6);
                //_graphics.DrawRectangle(FocusPen, pointFocus.X - 3, pointFocus.Y - 3, 2*focusWidth, 2*focusWidth);
                _graphics.DrawEllipse(FocusPen, pointFocus.X - 3, pointFocus.Y - 3, 2 * 6, 2 * 6);

                pictureBox1.Image = _tmpBitmap;
                GC.Collect();

            }


        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
            _mainBitmap = _tmpBitmap;
            listOfArrows.Add(aArrow);

            startAndEndLinePoints.Add(m_End);
            startAndEndLinePoints.Add(m_Cur);
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
             block1 = new Block();
        }
            
        public static void SetPropety(string nameM, string atributesM,string methodsM)
        {
         
            classN = nameM;

            atributes = atributesM;
            methods = methodsM;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new PropertyForBlock();
            form.Show();
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
