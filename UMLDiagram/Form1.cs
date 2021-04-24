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
        
        ArrowsBuilder builder;
        AbstractArrow aArrow;

        ArrowLineType typeOfLine;
        ArrowCapType typeOfCap;
        FigureType typeOfFigure;
        Mode mode;

        Block block1;
        public static float  width1{ get; set; }
        public static float height1 { get; set; }

        public static int LinesAtr { get; set; }
        public static int LinesMet { get; set; }

        //List<IFigure> listOfFigure = new List<IFigure>();
        List<AbstractArrow> listOfArrows = new List<AbstractArrow>();

        Point p;    

       

        public Form1()
        {
            InitializeComponent();
        }

        public void SetPropety(string nameF, string atributF,string methodsF,Font font)
        {
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

            switch (typeOfFigure)
            {
                case FigureType.Class:
                    block1 = new Block();
                    var form = new PropertyForBlock(this);
                    form.Show();
                    block1.SetPointForLines(e.Location);
                    break;
                case FigureType.Arrow:
                    switch (mode)
                    {
                    case Mode.Moving:
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
                        break;
                    case Mode.Drawing:
                        builder = new ArrowsBuilder();
                        aArrow = builder.CreateArrow(typeOfCap, typeOfLine);
                        aArrow._startPoint = e.Location;
                        break;
                    }
                break;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {  
                switch (mode)
                {
                    case Mode.Moving:
                        if (aArrow != null)
                        {
                            aArrow.Move(e.X - p.X, e.Y - p.Y);
                            p = e.Location;
                        }
                        break;
                    case Mode.Drawing:
                        aArrow._endPoint = e.Location;
                        break;
                }

                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);

                //block1.startPoint = e.Location;
                //aArrow.Draw(_graphics, MinePen);

                switch (typeOfFigure)
                {
                    case FigureType.Class:
                        block1.startPoint = e.Location;
                        block1.SetPointForLines(e.Location);
                        block1.DrawBlock(_graphics, MinePen, e.Location);
                        break;
                    case FigureType.Arrow:
                        aArrow.Draw(_graphics, MinePen);
                        break;
                }

                    //block1.SetPointForLines(e.Location);
                    //block1.DrawBlock(_graphics, MinePen, e.Location, nameClass, atributes , methods,width1 , height1, LinesAtr, LinesMet);
                    //block1.DrawBlock(_graphics, MinePen, e.Location);

                pictureBox1.Image = _tmpBitmap;

                if (GC.GetTotalMemory(true) > 1073741824)
                {
                    GC.Collect();
                }
            }

            else
            {
                builder = new ArrowsBuilder();
                aArrow = builder.CreateArrow(typeOfCap, typeOfLine);

                foreach (AbstractArrow a in listOfArrows)
                {
                    if (a.SelectPointLine(e.Location))
                    {
                        _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                        _graphics = Graphics.FromImage(_tmpBitmap);

                        Pen FocusPen = new Pen(Color.Red, 3);
                        _graphics.DrawEllipse(FocusPen, e.Location.X - 5, e.Location.Y - 5, 10, 10);

                        pictureBox1.Image = _tmpBitmap;
                        GC.Collect();
                        break;
                    }
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
            _mainBitmap = _tmpBitmap;

            switch (typeOfFigure)
            {
                case FigureType.Class:
                    block1.NameField = null;
                    block1.AtribureField = null;
                    block1.MethodField = null;
                    break;
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
            mode = Mode.Drawing;
            typeOfFigure = FigureType.Arrow;
        }

        private void aggregationButton_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.SolidLine;
            typeOfCap = ArrowCapType.RhombusCap;
            mode = Mode.Drawing;
            typeOfFigure = FigureType.Arrow;
        }

        private void InheritanceArrow_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.SolidLine;
            typeOfCap = ArrowCapType.TriangleCap;
            mode = Mode.Drawing;
            typeOfFigure = FigureType.Arrow;
        }

        private void implementationButton_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.DashLine;
            typeOfCap = ArrowCapType.TriangleCap;
            mode = Mode.Drawing;
            typeOfFigure = FigureType.Arrow;
        }

        private void compositionButton_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.SolidLine;
            typeOfCap = ArrowCapType.RhombusFillCap;
            mode = Mode.Drawing;
            typeOfFigure = FigureType.Arrow;
        }

        private void addictionButton_Click(object sender, EventArgs e)
        {
            typeOfLine = ArrowLineType.SolidLine;
            typeOfCap = ArrowCapType.TriangleFillCap;
            mode = Mode.Drawing;
            typeOfFigure = FigureType.Arrow;
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
            //block1 = new Block();
            //var form = new PropertyForBlock(this);
            //form.Show();

            typeOfFigure = FigureType.Class;
            //mode = Mode.Drawing;
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
            mode = Mode.Moving;
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
