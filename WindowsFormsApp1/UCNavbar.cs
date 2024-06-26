﻿using System;
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
    public partial class UCNavbar : UserControl
    {
        public UCNavbar()
        {
            InitializeComponent();
        }

        private void UCNavbar_Load(object sender, EventArgs e)
        {
            label1.ForeColor = ColorTranslator.FromHtml(ThemeManager.GetThemeColor("Light"));
        }

        private void UCNavbar_Paint(object sender, PaintEventArgs e)
        {
            BackColor = ColorTranslator.FromHtml(ThemeManager.GetThemeColor("Dark"));
        }
    }
}
