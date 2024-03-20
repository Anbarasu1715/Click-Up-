using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UCOptionBox : UserControl
    {


        private Graphics graphics;

        public UCOptionBox()
        {
            InitializeComponent();
            BackColor = ColorTranslator.FromHtml(ThemeManager.GetThemeColor("color2"));
            label1.ForeColor = ColorTranslator.FromHtml(ThemeManager.GetThemeColor("Light"));
            label2.ForeColor = ColorTranslator.FromHtml(ThemeManager.GetThemeColor("Light"));
            label3.ForeColor = ColorTranslator.FromHtml(ThemeManager.GetThemeColor("Light"));
            label4.ForeColor = ColorTranslator.FromHtml(ThemeManager.GetThemeColor("Light"));   

            label1.BackColor = ColorTranslator.FromHtml(ThemeManager.GetThemeColor("Dark"));
            label2.BackColor = ColorTranslator.FromHtml(ThemeManager.GetThemeColor("Dark"));
            label3.BackColor = ColorTranslator.FromHtml(ThemeManager.GetThemeColor("Dark"));
            label4.BackColor = ColorTranslator.FromHtml(ThemeManager.GetThemeColor("Dark"));
            panel1.BackColor = ColorTranslator.FromHtml(ThemeManager.GetThemeColor("Dark"));
            panel2.BackColor = ColorTranslator.FromHtml(ThemeManager.GetThemeColor("Dark"));
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Label senderObject = sender as Label;
            senderObject.BackColor = ColorTranslator.FromHtml(ThemeManager.GetThemeColor("color3"));
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Label senderObject = sender as Label;
            senderObject.BackColor = ColorTranslator.FromHtml(ThemeManager.GetThemeColor("Dark"));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            graphics.DrawLine(new Pen(ColorTranslator.FromHtml(ThemeManager.GetThemeColor("color2")), 5), 0, 0, panel1.Width, 0);
        }
    }
}
