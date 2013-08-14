namespace CSVcompare
{
    partial class FrmCSVcmpr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCSVcmpr));
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblFile1 = new System.Windows.Forms.Label();
            this.lblFile2 = new System.Windows.Forms.Label();
            this.txtbxFile1 = new System.Windows.Forms.TextBox();
            this.txtbxFile2 = new System.Windows.Forms.TextBox();
            this.chkbxExcel = new System.Windows.Forms.CheckBox();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCompare
            // 
            this.btnCompare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCompare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompare.Location = new System.Drawing.Point(8, 84);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(106, 53);
            this.btnCompare.TabIndex = 0;
            this.btnCompare.Text = "&Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Location = new System.Drawing.Point(304, 84);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(106, 53);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblFile1
            // 
            this.lblFile1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFile1.Location = new System.Drawing.Point(60, 3);
            this.lblFile1.Name = "lblFile1";
            this.lblFile1.Size = new System.Drawing.Size(87, 36);
            this.lblFile1.TabIndex = 2;
            this.lblFile1.Text = "Sunday";
            this.lblFile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFile2
            // 
            this.lblFile2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFile2.Location = new System.Drawing.Point(63, 39);
            this.lblFile2.Name = "lblFile2";
            this.lblFile2.Size = new System.Drawing.Size(84, 36);
            this.lblFile2.TabIndex = 3;
            this.lblFile2.Text = "Wednesday";
            this.lblFile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxFile1
            // 
            this.txtbxFile1.BackColor = System.Drawing.Color.White;
            this.txtbxFile1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxFile1.Location = new System.Drawing.Point(153, 13);
            this.txtbxFile1.Name = "txtbxFile1";
            this.txtbxFile1.ReadOnly = true;
            this.txtbxFile1.Size = new System.Drawing.Size(258, 20);
            this.txtbxFile1.TabIndex = 4;
            this.txtbxFile1.Text = "<Click here to browse for file>";
            this.txtbxFile1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbxFile1.Click += new System.EventHandler(this.txtbxFile1_Click);
            // 
            // txtbxFile2
            // 
            this.txtbxFile2.BackColor = System.Drawing.Color.White;
            this.txtbxFile2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxFile2.Location = new System.Drawing.Point(153, 49);
            this.txtbxFile2.Name = "txtbxFile2";
            this.txtbxFile2.ReadOnly = true;
            this.txtbxFile2.Size = new System.Drawing.Size(258, 20);
            this.txtbxFile2.TabIndex = 5;
            this.txtbxFile2.Text = "<Click here to browse for file>";
            this.txtbxFile2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbxFile2.Click += new System.EventHandler(this.txtbxFile2_Click);
            // 
            // chkbxExcel
            // 
            this.chkbxExcel.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkbxExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.chkbxExcel.Checked = true;
            this.chkbxExcel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxExcel.FlatAppearance.BorderSize = 2;
            this.chkbxExcel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.chkbxExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.chkbxExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.chkbxExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkbxExcel.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxExcel.Location = new System.Drawing.Point(156, 84);
            this.chkbxExcel.Name = "chkbxExcel";
            this.chkbxExcel.Size = new System.Drawing.Size(106, 53);
            this.chkbxExcel.TabIndex = 6;
            this.chkbxExcel.Text = "Open Excel  -  ✓";
            this.chkbxExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkbxExcel.UseVisualStyleBackColor = false;
            this.chkbxExcel.CheckedChanged += new System.EventHandler(this.chkbxExcel_CheckedChanged);
            // 
            // OpenFile
            // 
            this.OpenFile.AddExtension = false;
            this.OpenFile.DefaultExt = "csv";
            this.OpenFile.FileName = "YourList.csv";
            this.OpenFile.Title = "Choose a file to open:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSVcompare.Properties.Resources.note_accept;
            this.pictureBox1.Location = new System.Drawing.Point(8, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCSVcmpr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(422, 158);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkbxExcel);
            this.Controls.Add(this.txtbxFile2);
            this.Controls.Add(this.txtbxFile1);
            this.Controls.Add(this.lblFile2);
            this.Controls.Add(this.lblFile1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCompare);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCSVcmpr";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  CSV Compare";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblFile1;
        private System.Windows.Forms.Label lblFile2;
        private System.Windows.Forms.TextBox txtbxFile1;
        private System.Windows.Forms.TextBox txtbxFile2;
        private System.Windows.Forms.CheckBox chkbxExcel;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

