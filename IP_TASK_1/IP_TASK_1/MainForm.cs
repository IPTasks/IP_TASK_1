using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IP_TASK_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        ImageFormat imageFormat;
        int height, width;
        Bitmap bm;
        string AllFile, type;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png,*.ppm) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.ppm;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Save.Enabled = true;
                Shear.Enabled = true;
                if (ofd.FileName.Contains(".ppm"))
                {
                    try
                    {
                       
                        using (StreamReader sr = new StreamReader(ofd.FileName))
                        {
                            type = sr.ReadLine();
                            string laststring;
                            while (true)
                            {
                                laststring = sr.ReadLine();
                                if (laststring[0] == '#')
                                    continue;
                                else
                                    break;
                            }
                            string[] line = laststring.Split();
                            width = Convert.ToInt32(line[0]);
                            height = Convert.ToInt32(line[1]);
                            sr.ReadLine();
                            AllFile = sr.ReadToEnd();
                        }
                        bm = new Bitmap(width, height);
               
                        if (type == "P3")
                        {
                            //g.DrawImage(, new Point(10, 50));
                            pictureBox1.Image=(Functions.ReadP3(width, height, bm, AllFile));

                            
                        }
                        else
                        {
                            bm=Functions.ReadP6(width,height,ofd.FileName);
                            pictureBox1.Image = bm;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                 
                     bm = new Bitmap(ofd.FileName);
                     pictureBox1.Image = bm;
                }

               
            }
        }
       
    


        private bool _selecting;
        private Rectangle _selection;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _selecting = true;
                _selection = new Rectangle(new Point(e.X, e.Y), new Size());
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_selecting)
            {
                _selection.Width = e.X - _selection.X;
                _selection.Height = e.Y - _selection.Y;

                // Redraw the picturebox:
                pictureBox1.Refresh();
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (_selecting)
            {
                // Draw a rectangle displaying the current selection
                Pen pen = Pens.GreenYellow;
                e.Graphics.DrawRectangle(pen, _selection);
            }
        }
        private void Crop_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap CroppedImage = Functions.CropImage((Bitmap)pictureBox1.Image, _selection);
                pictureBox1.Image = CroppedImage;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {        
            this.Refresh();
        }
        private void Flip_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                pictureBox1.Refresh();
            } 
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left &&_selecting &&_selection.Size != new Size())
            {
                _selecting = false;
            }
            else
                _selecting = false;
        }
        private void bmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageFormat = ImageFormat.Bmp;
            sfd.FileName = "default.bmp";
            sfd.DefaultExt = "bmp";
            sfd.Filter = "Bitmap files|*.bmp";
            sfd.Title = "Saving current image as bitmap...";
            sfd.ShowDialog();
        }
        private void sfd_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
              pictureBox1.Image.Save(sfd.FileName,imageFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageFormat = ImageFormat.Png;
            sfd.FileName = "default.png";
            sfd.DefaultExt = "png";
            sfd.Filter = "PNG files|*.png";
            sfd.Title = "Saving current image as png...";
            sfd.ShowDialog();
        }
        private void jpgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageFormat = ImageFormat.Jpeg;
            sfd.FileName = "default.jpg";
            sfd.DefaultExt = "jpg";
            sfd.Filter = "JPEG files|*.jpg";
            sfd.Title = "Saving current image as jpeg..."; 
            sfd.ShowDialog();
        }

        private void Scale_Click(object sender, EventArgs e)
        {

            if (bm != null)
            {
                Message.Text = "";
                Color[,] OldBuffer = Functions.Fill_Buffer(bm);
                Color[,] NewBuffer = Functions.Scale(OldBuffer, bm.Width, bm.Height);
                bm = Functions.Load_Buffer(NewBuffer);
                pictureBox1.Image = bm;
            }
            else
            {
                Message.Text = "Please Load Image";

            }
     

        }

        private void Shear_Click_1(object sender, EventArgs e)
        {
            if (bm != null)
            {
                Message.Text = "";
                Color[,] OldBuffer = Functions.Fill_Buffer(bm);
                Color[,] NewBuffer = Functions.Shear(OldBuffer, bm.Width, bm.Height);
                bm = Functions.Load_Buffer(NewBuffer);
                pictureBox1.Image = bm;
            }
            else
            {
                Message.Text = "Please Load Image";

            }
        }
        private void Rotate_Click(object sender, EventArgs e)
        {
            if (bm != null)
            {
                Message.Text = "";
             Color[,] OldBuffer = Functions.Fill_Buffer(bm);
             Color[,] NewBuffer = Functions.Rotate(OldBuffer,bm.Width,bm.Height, 90);
            bm = Functions.Load_Buffer(NewBuffer);
            pictureBox1.Image = bm;
            }
            else
            {
                Message.Text = "Please Load Image";

            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bm != null)
            {
                Message.Text = "";
                Color[,] OldBuffer = Functions.Fill_Buffer(bm);
                Color[,] NewBuffer = Functions.Rotate(OldBuffer, bm.Width, bm.Height, 180);
                Color[,] NewBufferScale = Functions.Scale(NewBuffer, bm.Width, bm.Height);
                Color[,] NewBufferShear = Functions.Shear(NewBufferScale, bm.Width, bm.Height);
                bm = Functions.Load_Buffer(NewBufferShear);
                pictureBox1.Image = bm;

            }
            else
            {
                Message.Text = "Please Load Image";

            }
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {

           pictureBox1.Image= Functions.ToGray(bm);
        }

       
    

        private void Histogram_Click_1(object sender, EventArgs e)
        {
            Functions.CalculateHistogram(bm, HistogramPnl);
        }

     

        }
    }



