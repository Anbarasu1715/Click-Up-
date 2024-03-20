namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucOptionBox1 = new WindowsFormsApp1.UCOptionBox();
            this.ucNavbar1 = new WindowsFormsApp1.UCNavbar();
            this.ucRightMenuBar1 = new WindowsFormsApp1.UCRightMenuBar();
            this.SuspendLayout();
            // 
            // ucOptionBox1
            // 
            this.ucOptionBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(177)))), ((int)(((byte)(190)))));
            this.ucOptionBox1.Location = new System.Drawing.Point(81, 66);
            this.ucOptionBox1.Name = "ucOptionBox1";
            this.ucOptionBox1.Size = new System.Drawing.Size(293, 138);
            this.ucOptionBox1.TabIndex = 2;
            this.ucOptionBox1.Load += new System.EventHandler(this.ucOptionBox1_Load);
            // 
            // ucNavbar1
            // 
            this.ucNavbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.ucNavbar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucNavbar1.Location = new System.Drawing.Point(75, 0);
            this.ucNavbar1.Name = "ucNavbar1";
            this.ucNavbar1.Size = new System.Drawing.Size(1166, 60);
            this.ucNavbar1.TabIndex = 1;
            // 
            // ucRightMenuBar1
            // 
            this.ucRightMenuBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.ucRightMenuBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucRightMenuBar1.Location = new System.Drawing.Point(0, 0);
            this.ucRightMenuBar1.Name = "ucRightMenuBar1";
            this.ucRightMenuBar1.Size = new System.Drawing.Size(75, 646);
            this.ucRightMenuBar1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 646);
            this.Controls.Add(this.ucOptionBox1);
            this.Controls.Add(this.ucNavbar1);
            this.Controls.Add(this.ucRightMenuBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UCRightMenuBar ucRightMenuBar1;
        private UCNavbar ucNavbar1;
        private UCOptionBox ucOptionBox1;
    }
}

