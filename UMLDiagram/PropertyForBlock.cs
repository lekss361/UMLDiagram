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
        public PropertyForBlock()
        {
            InitializeComponent();
        }
        public static string _nameOfBlock { get; set; }
        public static string _atributesOfBlock { get; set; }
        public static string _methodsOfBlock { get; set; }

        Font fon2;

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            _nameOfBlock = nameTextBox.Text;
            fon2 = nameTextBox.Font;



        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            _atributesOfBlock = richTextBox2.Text;
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            _methodsOfBlock = richTextBox3.Text;
        }
        private void PropertyForBlock_Load(object sender, EventArgs e)
        {

        }

        private void okey_Click(object sender, EventArgs e)
        {
            Form1.SetPropety(_nameOfBlock, _atributesOfBlock, _methodsOfBlock,fon2);
            Close();
        }
    }
}
