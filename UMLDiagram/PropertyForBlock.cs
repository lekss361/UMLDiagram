using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMLDiagram
{
    public partial class PropertyForBlock : Form
    {
        public PropertyForBlock(MainForm form)
        {
            this.mainForm = form;
            InitializeComponent();
        }
        public string _nameOfBlock { get; set; }
        public  string _atributesOfBlock { get; set; }
        public  string _methodsOfBlock { get; set; }

        static SizeF nameSize { get; set; }
        static SizeF atributeSize { get; set; }
        static SizeF methodSize { get; set; }

        public static float widthParam { get; set; }
        public static float heightFont { get; set; }
        public static int countLinesAtr { get; set; }
        public static int countLinesMet { get; set; }

        private MainForm mainForm;

        public static Font fontOfText { get; set; }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            _nameOfBlock = nameTextBox.Text;
           
            fontOfText = nameTextBox.Font;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            _atributesOfBlock = richTextBox2.Text;
            countLinesAtr = richTextBox2.Lines.Count();
            heightFont = richTextBox2.Font.Height;
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            _methodsOfBlock = richTextBox3.Text;
            countLinesMet = richTextBox3.Lines.Count();
        }
        private void PropertyForBlock_Load(object sender, EventArgs e)
        {
            

        }

        private void okey_Click(object sender, EventArgs e)
        {
            mainForm.SetPropety(_nameOfBlock, _atributesOfBlock, _methodsOfBlock,fontOfText);
            mainForm.SetCountLines(countLinesAtr, countLinesMet);
            Close();
        }
        private static void GetParametersForBlock(string name, string atr, string met, Font strFont, PaintEventArgs e)
        {

            Font stringFont = strFont;
            nameSize = new SizeF();
            nameSize = e.Graphics.MeasureString(name, stringFont);
            atributeSize = new SizeF();
            atributeSize = e.Graphics.MeasureString(atr, stringFont);
            methodSize = new SizeF();
            methodSize = e.Graphics.MeasureString(met, stringFont);

        }
        private static float GetWidth(SizeF name, SizeF atr, SizeF met)
        {
            float with;
            if ((name.Width >= atr.Width) && (name.Width >= met.Width)) // может быть поставить >=  ?
            {
                with = name.Width;
            }
            else if ((atr.Width >= met.Width) && (atr.Width >= name.Width))
            {
                with = atr.Width;
            }
            else
            {
                with = met.Width;
            }
            return with;
        }
        
        private static float CalculateWidthBlock(string name, string atr, string met, Font strFont, PaintEventArgs e)
        {
            float with;
            GetParametersForBlock(name, atr, met, strFont, e);
            with = GetWidth(nameSize, atributeSize, methodSize);
            return with;
        }
       
        private void PropertyForBlock_Paint(object sender, PaintEventArgs e)
        {
            widthParam = CalculateWidthBlock(_nameOfBlock, _atributesOfBlock, _methodsOfBlock, fontOfText, e);
            //heightFont = heightFont;
            mainForm.SetWidthAndHeist(widthParam,heightFont);
            
        }

        private void chooseFont_Click(object sender, EventArgs e)
        {
            if ( (fontDialog1.ShowDialog()== DialogResult.OK))
            {
                nameTextBox.Font = fontDialog1.Font;
                richTextBox2.Font = fontDialog1.Font;
                richTextBox3.Font = fontDialog1.Font;
                
            }
        }
    }
}
