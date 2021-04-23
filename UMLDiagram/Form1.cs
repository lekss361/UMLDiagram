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
        Mode mode;

        Block block1;
        public static float  width1{ get; set; }
        public static float height1 { get; set; }

        public static int LinesAtr { get; set; }
        public static int LinesMet { get; set; }

        //private List<AbstractArrow> MyLines = new List<AbstractArrow>();
        //List<IFigure> listOfFigure = new List<IFigure>();
        List<AbstractArrow> listOfArrows = new List<AbstractArrow>();

        bool isMove = false;
        Point p;

        List<Point> startAndEndLinePoints = new List<Point>();
        //bool pointFocused = false;
        //Point pointFocus;        

        //Point newStartPointFocus;
        //Point newEndPointFocus;

        //string mode;
        

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
            //block1.SetPointForLines(e.Location);
            IsMouseDown = true;
            m_End = e.Location;

            if (isMove)
            //if (Mode.Moving)
            {
                foreach (AbstractArrow a in listOfArrows)
                {
                    if (a.SelectPointLine(e.Location))
                    {
                        aArrow = a;
                        break;
                    }
                }

                if (aArrow != null)
                {
                    listOfArrows.Remove(aArrow);

                    _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    _graphics = Graphics.FromImage(_mainBitmap);
                    _graphics.Clear(Color.White);

                    foreach (AbstractArrow a in listOfArrows)
                    {
                        a.Draw(_graphics, MinePen);
                    }

                    pictureBox1.Image = _mainBitmap;

                    p = e.Location;
                }
            }
            else
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
                //if (isMove)
                //{
                //    //MovePointOfLine(e.Location.X - p.X, e.Location.Y - p.Y);
                //    //p = e.Location;
                //    MovePointOfLine(10, 10);
                //}
                if (isMove && (aArrow != null))
                {
                    aArrow.Move(e.X - p.X, e.Y - p.Y);
                    p = e.Location;
                }
                else
                {
                    aArrow._endPoint = e.Location;
                }

                m_Cur = e.Location;
                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);

                //block1.startPoint = e.Location;
                aArrow.Draw(_graphics, MinePen);
                
                Pen FocusPen = new Pen(Color.Red, 5);
                //_graphics.DrawEllipse(FocusPen, e.Location.X - 5, e.Location.Y - 5, 10, 10);
                _graphics.DrawEllipse(FocusPen, aArrow._startPoint.X - 5, aArrow._startPoint.Y - 5, 10, 10);


                //block1.SetPointForLines(e.Location);
                //block1.DrawBlock(_graphics, MinePen, e.Location, nameClass, atributes , methods,width1 , height1, LinesAtr, LinesMet);
                //block1.DrawBlock(_graphics, MinePen, e.Location);

                pictureBox1.Image = _tmpBitmap;
                if (GC.GetTotalMemory(true) > 1073741824)
                {
                    GC.Collect();
                }


                //// Поиск точки
                //pointFocused = false;
                ////pointFocus = new Point();
                //newStartPointFocus = new Point();
                //newEndPointFocus = new Point();

                //for (int i = 0; i < startAndEndLinePoints.Count; i++)
                //{
                //    if (Math.Abs(startAndEndLinePoints[i].X - e.Location.X) < 5
                //            && Math.Abs(startAndEndLinePoints[i].Y - e.Location.Y) < 5)
                //        //if (startAndEndLinePoints.Contains(e.Location))
                //    {
                //        pointFocused = true;
                //        pointFocus = e.Location;

                //        if (i % 2 == 0)
                //        {
                //            newStartPointFocus = e.Location;
                //        }
                //        else
                //        {
                //            newEndPointFocus = e.Location;
                //        }                        

                //    }

                //}

                // Отрисовка круга вокруг найденной точки
                //if (SelectPointLine(e.Location))
                //if (pointFocused)
                //if (aArrow.SelectPointLine(e.Location))
                //{
                //    _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                //    _graphics = Graphics.FromImage(_tmpBitmap);

                //    Pen FocusPen = new Pen(Color.Red, 5);

                //    _graphics.DrawEllipse(FocusPen, e.Location.X - 5, e.Location.Y - 5, 10, 10);

                //    pictureBox1.Image = _tmpBitmap;
                //    GC.Collect();
                //}
            }
            //builder = new ArrowsBuilder();
            //aArrow = builder.CreateArrow(typeOfCap, typeOfLine);

            //if ( isMove && aArrow != null
            //    && aArrow.SelectPointLine(e.Location))
            //{
            //    _tmpBitmap = (Bitmap)_mainBitmap.Clone();
            //    _graphics = Graphics.FromImage(_tmpBitmap);

            //    Pen FocusPen = new Pen(Color.Red, 5);

            //    _graphics.DrawEllipse(FocusPen, e.Location.X - 5, e.Location.Y - 5, 10, 10);

            //    pictureBox1.Image = _tmpBitmap;
            //    GC.Collect();
            //}

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
            _mainBitmap = _tmpBitmap;

            //block1.NameField = null;
            //block1.AtribureField = null;
            //block1.MethodField = null;

            listOfArrows.Add(aArrow);

            startAndEndLinePoints.Add(aArrow._startPoint);
            startAndEndLinePoints.Add(aArrow._endPoint);
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
            //mode = Mode.Drawing;
            isMove = false;
        }

        private void aggregationButton_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.SolidLine;
            typeOfCap = ArrowCapType.RhombusCap;
            //mode = Mode.Drawing;
            isMove = false;
        }

        private void InheritanceArrow_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.SolidLine;
            typeOfCap = ArrowCapType.TriangleCap;
            //mode = Mode.Drawing;
            isMove = false;
        }

        private void implementationButton_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.DashLine;
            typeOfCap = ArrowCapType.TriangleCap;
            //mode = Mode.Drawing;
            isMove = false;
        }

        private void compositionButton_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.SolidLine;
            typeOfCap = ArrowCapType.RhombusFillCap;
            //mode = Mode.Drawing;
            isMove = false;
        }

        private void addictionButton_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.SolidLine;
            typeOfCap = ArrowCapType.TriangleFillCap;
            //mode = Mode.Drawing;
            isMove = false;
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

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            aArrow = null;
            //mode = Mode.Moving;
            isMove = true;
        }

        private void buttonStack_Click(object sender, EventArgs e)
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

        private void buttonRemoveTheLast_Click(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);

            listOfArrows.RemoveAt(listOfArrows.Count - 1);

            foreach (AbstractArrow a in listOfArrows)
            {
                a.Draw(_graphics, MinePen);
            }

            pictureBox1.Image = _mainBitmap;
        }
    }
}
