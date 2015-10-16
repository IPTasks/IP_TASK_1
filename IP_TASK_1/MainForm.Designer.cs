namespace IP_TASK_1
{
    partial class MainForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.bmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jpgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Crop = new System.Windows.Forms.Button();
            this.Flip = new System.Windows.Forms.Button();
            this.Shear = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.Scale = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Message = new System.Windows.Forms.Label();
            this.Rotate = new System.Windows.Forms.Button();
            this.HistogramPnl = new System.Windows.Forms.Panel();
            this.Histogram = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.dToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.Save});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // Save
            // 
            this.Save.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bmpToolStripMenuItem,
            this.pngToolStripMenuItem,
            this.jpgToolStripMenuItem});
            this.Save.Enabled = false;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(103, 22);
            this.Save.Text = "&Save";
            // 
            // bmpToolStripMenuItem
            // 
            this.bmpToolStripMenuItem.Name = "bmpToolStripMenuItem";
            this.bmpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.bmpToolStripMenuItem.Text = "bmp";
            this.bmpToolStripMenuItem.Click += new System.EventHandler(this.bmpToolStripMenuItem_Click);
            // 
            // pngToolStripMenuItem
            // 
            this.pngToolStripMenuItem.Name = "pngToolStripMenuItem";
            this.pngToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.pngToolStripMenuItem.Text = "png";
            this.pngToolStripMenuItem.Click += new System.EventHandler(this.pngToolStripMenuItem_Click);
            // 
            // jpgToolStripMenuItem
            // 
            this.jpgToolStripMenuItem.Name = "jpgToolStripMenuItem";
            this.jpgToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.jpgToolStripMenuItem.Text = "jpeg";
            this.jpgToolStripMenuItem.Click += new System.EventHandler(this.jpgToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scaleToolStripMenuItem,
            this.rotateToolStripMenuItem,
            this.shearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // scaleToolStripMenuItem
            // 
            this.scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            this.scaleToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.scaleToolStripMenuItem.Text = "Scale";
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.rotateToolStripMenuItem.Text = "Rotate";
            // 
            // shearToolStripMenuItem
            // 
            this.shearToolStripMenuItem.Name = "shearToolStripMenuItem";
            this.shearToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.shearToolStripMenuItem.Text = "Shear";
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayToolStripMenuItem});
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.dToolStripMenuItem.Text = "Image";
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.grayToolStripMenuItem.Text = "Gray";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
            // 
            // Crop
            // 
            this.Crop.Location = new System.Drawing.Point(18, 427);
            this.Crop.Name = "Crop";
            this.Crop.Size = new System.Drawing.Size(75, 23);
            this.Crop.TabIndex = 3;
            this.Crop.Text = "Crop";
            this.Crop.UseVisualStyleBackColor = true;
            this.Crop.Click += new System.EventHandler(this.Crop_Click);
            // 
            // Flip
            // 
            this.Flip.Location = new System.Drawing.Point(99, 427);
            this.Flip.Name = "Flip";
            this.Flip.Size = new System.Drawing.Size(75, 23);
            this.Flip.TabIndex = 4;
            this.Flip.Text = "Flip";
            this.Flip.UseVisualStyleBackColor = true;
            this.Flip.Click += new System.EventHandler(this.Flip_Click);
            // 
            // Shear
            // 
            this.Shear.Location = new System.Drawing.Point(180, 427);
            this.Shear.Name = "Shear";
            this.Shear.Size = new System.Drawing.Size(75, 23);
            this.Shear.TabIndex = 5;
            this.Shear.Text = "Shear";
            this.Shear.UseVisualStyleBackColor = true;
            this.Shear.Click += new System.EventHandler(this.Shear_Click_1);
            // 
            // sfd
            // 
            this.sfd.FileOk += new System.ComponentModel.CancelEventHandler(this.sfd_FileOk);
            // 
            // Scale
            // 
            this.Scale.Location = new System.Drawing.Point(261, 427);
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(75, 23);
            this.Scale.TabIndex = 6;
            this.Scale.Text = "Scale";
            this.Scale.UseVisualStyleBackColor = true;
            this.Scale.Click += new System.EventHandler(this.Scale_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 376);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.ForeColor = System.Drawing.Color.Red;
            this.Message.Location = new System.Drawing.Point(444, 27);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(0, 13);
            this.Message.TabIndex = 11;
            // 
            // Rotate
            // 
            this.Rotate.Location = new System.Drawing.Point(343, 426);
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(75, 23);
            this.Rotate.TabIndex = 12;
            this.Rotate.Text = "Rotate";
            this.Rotate.UseVisualStyleBackColor = true;
            this.Rotate.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // HistogramPnl
            // 
            this.HistogramPnl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HistogramPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HistogramPnl.Location = new System.Drawing.Point(555, 24);
            this.HistogramPnl.Name = "HistogramPnl";
            this.HistogramPnl.Size = new System.Drawing.Size(277, 185);
            this.HistogramPnl.TabIndex = 0;
            // 
            // Histogram
            // 
            this.Histogram.Location = new System.Drawing.Point(575, 215);
            this.Histogram.Name = "Histogram";
            this.Histogram.Size = new System.Drawing.Size(75, 23);
            this.Histogram.TabIndex = 13;
            this.Histogram.Text = "Histogram";
            this.Histogram.UseVisualStyleBackColor = true;
            this.Histogram.Click += new System.EventHandler(this.Histogram_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(832, 472);
            this.Controls.Add(this.Histogram);
            this.Controls.Add(this.HistogramPnl);
            this.Controls.Add(this.Rotate);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Scale);
            this.Controls.Add(this.Shear);
            this.Controls.Add(this.Flip);
            this.Controls.Add(this.Crop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.Button Crop;
        private System.Windows.Forms.Button Flip;
        private System.Windows.Forms.Button Shear;
        private System.Windows.Forms.ToolStripMenuItem bmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jpgToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button Scale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Button Rotate;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.Panel HistogramPnl;
        private System.Windows.Forms.Button Histogram;
    }
}

