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
    public partial class UCRightMenuBar : UserControl
    {
        public UCRightMenuBar()
        {
            InitializeComponent();
            label1.Hide();
            label2.Hide();
            label3.Hide();
        }

        private Graphics graphics;    

        private void UCRightMenuBar_Paint(object sender, PaintEventArgs e)
        {
            BackColor = ColorTranslator.FromHtml(ThemeManager.GetThemeColor("Dark"));
            graphics = e.Graphics;

            label1.ForeColor = ColorTranslator.FromHtml(ThemeManager.GetThemeColor("Light"));
            label2.ForeColor = ColorTranslator.FromHtml(ThemeManager.GetThemeColor("Light"));
            label3.ForeColor = ColorTranslator.FromHtml(ThemeManager.GetThemeColor("Light")); 
        }

        private void UCRightMenuBar_Resize(object sender, EventArgs e)
        { 
            //HomePB.Location = new Point((int)(Width/5.45),(int)(Height/6.14));
            //TaskPB.Location = new Point((int)(Width / 5.45), (int)(Height / 3.5));
            //IssuePB.Location = new Point((int)(Width / 5.45), (int)(Height / 2.5));
        }

        private void HomePB_MouseEnter(object sender, EventArgs e)
        {
            PictureBox senderObject = sender as PictureBox;
            if (senderObject.Name == "HomePB")
            {
                label1.Show();
            }
            else if (senderObject.Name=="TaskPB") 
            {
                label2.Show();  
            }
            else if (senderObject.Name == "IssuePB")
            {
                label3.Show();
            }   
        }

        private void HomePB_MouseLeave(object sender, EventArgs e)
        {
            PictureBox senderObject = sender as PictureBox;
            if (senderObject.Name == "HomePB")
            {
                label1.Hide();
            }
            else if (senderObject.Name == "TaskPB")
            {
                label2.Hide();
            }
            else if (senderObject.Name == "IssuePB")
            {
                label3.Hide();
            }
        }

        private void TaskPB_Click(object sender, EventArgs e)
        {
            
        }
    }
}
