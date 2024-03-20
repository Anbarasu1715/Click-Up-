using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
         
        private static UCOptionBox optionBox;

        public Form1()
        {
            InitializeComponent();
        }

        public void GenerateOptionBox() 
        {
            int height=ucR;
            optionBox?.Dispose();
            optionBox = new UCOptionBox();
            optionBox.Location = new Point(Width, LabelHeight / 2 + LabelY - (optionBox.Height / 2));
            optionBox.Show();
            optionBox.BringToFront();
        }

        private void ucOptionBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
