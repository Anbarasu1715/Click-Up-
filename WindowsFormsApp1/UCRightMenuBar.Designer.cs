namespace WindowsFormsApp1
{
    partial class UCRightMenuBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HomePB = new System.Windows.Forms.PictureBox();
            this.IssuePB = new System.Windows.Forms.PictureBox();
            this.TaskPB = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IssuePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Home";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Task";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Issue";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.HomePB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.IssuePB, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TaskPB, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(66, 645);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // HomePB
            // 
            this.HomePB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HomePB.Image = global::WindowsFormsApp1.Properties.Resources.HomeImg;
            this.HomePB.Location = new System.Drawing.Point(14, 71);
            this.HomePB.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.HomePB.Name = "HomePB";
            this.HomePB.Size = new System.Drawing.Size(37, 35);
            this.HomePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePB.TabIndex = 0;
            this.HomePB.TabStop = false;
            this.HomePB.MouseEnter += new System.EventHandler(this.HomePB_MouseEnter);
            this.HomePB.MouseLeave += new System.EventHandler(this.HomePB_MouseLeave);
            // 
            // IssuePB
            // 
            this.IssuePB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IssuePB.Image = global::WindowsFormsApp1.Properties.Resources.issueImg;
            this.IssuePB.Location = new System.Drawing.Point(14, 182);
            this.IssuePB.Name = "IssuePB";
            this.IssuePB.Size = new System.Drawing.Size(37, 37);
            this.IssuePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IssuePB.TabIndex = 2;
            this.IssuePB.TabStop = false;
            this.IssuePB.MouseEnter += new System.EventHandler(this.HomePB_MouseEnter);
            this.IssuePB.MouseLeave += new System.EventHandler(this.HomePB_MouseLeave);
            // 
            // TaskPB
            // 
            this.TaskPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TaskPB.Image = global::WindowsFormsApp1.Properties.Resources.taskImg;
            this.TaskPB.Location = new System.Drawing.Point(14, 125);
            this.TaskPB.Name = "TaskPB";
            this.TaskPB.Size = new System.Drawing.Size(37, 37);
            this.TaskPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TaskPB.TabIndex = 1;
            this.TaskPB.TabStop = false;
            this.TaskPB.Click += new System.EventHandler(this.TaskPB_Click);
            this.TaskPB.MouseEnter += new System.EventHandler(this.HomePB_MouseEnter);
            this.TaskPB.MouseLeave += new System.EventHandler(this.HomePB_MouseLeave);
            // 
            // UCRightMenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCRightMenuBar";
            this.Size = new System.Drawing.Size(66, 645);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UCRightMenuBar_Paint);
            this.Resize += new System.EventHandler(this.UCRightMenuBar_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IssuePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HomePB;
        private System.Windows.Forms.PictureBox TaskPB;
        private System.Windows.Forms.PictureBox IssuePB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
