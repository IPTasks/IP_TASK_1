using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_TASK_1
{
   public static class Functions
    {


        
       public static Color[,] Fill_Buffer(Bitmap Image)
       {

           Color[,] Buff = new Color[Image.Width, Image.Height];
           for (int i = 0; i < Image.Height; i++)
           {
               for (int j = 0; j < Image.Width; j++)
               {

                   Buff[j, i] = Image.GetPixel(j, i);

               }
           }
           return Buff;
       }

       public static Bitmap Load_Buffer(Color[,] Buffer)
       {

           Bitmap newImage = new Bitmap(Buffer.GetLength(0), Buffer.GetLength(1));  
           for (int i = 0; i < newImage.Height; i++)
           {
               for (int j = 0; j < newImage.Width; j++)
               {

                   newImage.SetPixel(j,i,Buffer[j,i]);

               }
           }
           return newImage;
       }
       public static  Color[,] Rotate (Color[,] sourceBuffer , int oWidth , int oHeight , float angel )
       {
           Color[,] Buff;
           Buff = sourceBuffer;
           Matrix TrsMat = new Matrix();
           TrsMat.RotateAt(angel, new Point(oWidth / 2, oHeight / 2));
      
           
           Point[] mypoint = new Point[1];
           mypoint[0].X=0;
           mypoint[0].Y=0;
           TrsMat.TransformPoints(mypoint);
           int X0 = mypoint[0].X;
           int Y0 = mypoint[0].Y;
           mypoint[0].X = oWidth;
           mypoint[0].Y = 0;
           TrsMat.TransformPoints(mypoint);
           int X1 = mypoint[0].X;
           int Y1 = mypoint[0].Y;
           mypoint[0].X = 0;
           mypoint[0].Y = oHeight;
           TrsMat.TransformPoints(mypoint);
           int X2 = mypoint[0].X;
           int Y2 = mypoint[0].Y;
           mypoint[0].X = oWidth;
           mypoint[0].Y = oHeight;
           TrsMat.TransformPoints(mypoint);
           int X3 = mypoint[0].X;
           int Y3= mypoint[0].Y;

           int MinX = Math.Min(X0, X1);
           MinX = Math.Min(MinX, X2);
           MinX = Math.Min(MinX, X3);

           int MinY = Math.Min(Y0, Y1);
           MinY = Math.Min(MinY, Y2);
           MinY = Math.Min(MinY, Y3);

           int MaxX = Math.Max(X0, X1);
           MaxX = Math.Max(MaxX, X2);
           MaxX = Math.Max(MaxX, X3);

           int MaxY = Math.Max(Y0, Y1);
           MaxY = Math.Max(MaxY, Y2);
           MaxY = Math.Max(MaxY, Y3);

           int nWidth = MaxX - MinX;
           int nHeight = MaxY - MinY;
            TrsMat = new Matrix();
           TrsMat.RotateAt(angel, new Point(50,50));
           TrsMat.Translate(-MinX, -MinY);
           TrsMat.Invert();
           Buff = new Color[nWidth, nHeight];

           for (int i = 0; i < nHeight; i++)
           {
               for (int j = 0; j < nWidth; j++)
               {
                   mypoint[0].X = j;
                   mypoint[0].Y = i;
                   TrsMat.TransformPoints(mypoint);
                   if (mypoint[0].X < oWidth && mypoint[0].X >= 0 && mypoint[0].Y < oHeight && mypoint[0].Y >= 0)
                   {
                       Buff[j, i] = sourceBuffer[mypoint[0].X, mypoint[0].Y];
                   }
                   else
                   {
                       Buff[j, i] = Color.FromArgb(0);
                   }


               }
           }

           return Buff;




       }

       public static Color[,] Shear(Color[,] sourceBuffer, int oWidth, int oHeight)
       {
           Color[,] Buff;
           Buff = sourceBuffer;
           Matrix TrsMat = new Matrix();
           TrsMat.Shear(1, 0);


           Point[] mypoint = new Point[1];
           mypoint[0].X = 0;
           mypoint[0].Y = 0;
           TrsMat.TransformPoints(mypoint);
           int X0 = mypoint[0].X;
           int Y0 = mypoint[0].Y;
           mypoint[0].X = oWidth;
           mypoint[0].Y = 0;
           TrsMat.TransformPoints(mypoint);
           int X1 = mypoint[0].X;
           int Y1 = mypoint[0].Y;
           mypoint[0].X = 0;
           mypoint[0].Y = oHeight;
           TrsMat.TransformPoints(mypoint);
           int X2 = mypoint[0].X;
           int Y2 = mypoint[0].Y;
           mypoint[0].X = oWidth;
           mypoint[0].Y = oHeight;
           TrsMat.TransformPoints(mypoint);
           int X3 = mypoint[0].X;
           int Y3 = mypoint[0].Y;

           int MinX = Math.Min(X0, X1);
           MinX = Math.Min(MinX, X2);
           MinX = Math.Min(MinX, X3);

           int MinY = Math.Min(Y0, Y1);
           MinY = Math.Min(MinY, Y2);
           MinY = Math.Min(MinY, Y3);

           int MaxX = Math.Max(X0, X1);
           MaxX = Math.Max(MaxX, X2);
           MaxX = Math.Max(MaxX, X3);

           int MaxY = Math.Max(Y0, Y1);
           MaxY = Math.Max(MaxY, Y2);
           MaxY = Math.Max(MaxY, Y3);

           int nWidth = MaxX - MinX;
           int nHeight = MaxY - MinY;
           TrsMat.Translate(-MinX, -MinY);
           TrsMat.Invert();
           Buff = new Color[nWidth, nHeight];

           for (int i = 0; i < nHeight; i++)
           {
               for (int j = 0; j < nWidth; j++)
               {
                   mypoint[0].X = j;
                   mypoint[0].Y = i;
                   TrsMat.TransformPoints(mypoint);
                   if (mypoint[0].X < oWidth && mypoint[0].X >= 0 && mypoint[0].Y < oHeight && mypoint[0].Y >= 0)
                   {
                       Buff[j, i] = sourceBuffer[mypoint[0].X, mypoint[0].Y];
                   }
                   else
                   {
                       Buff[j, i] = Color.FromArgb(0);
                   }


               }
           }

           return Buff;




       }
       public static Color[,] Scale(Color[,] sourceBuffer, int oWidth, int oHeight)
       {
           Color[,] Buff;
           Buff = sourceBuffer;
           Matrix TrsMat = new Matrix();
           TrsMat.Scale(2,2);


           Point[] mypoint = new Point[1];
           mypoint[0].X = 0;
           mypoint[0].Y = 0;
           TrsMat.TransformPoints(mypoint);
           int X0 = mypoint[0].X;
           int Y0 = mypoint[0].Y;
           mypoint[0].X = oWidth;
           mypoint[0].Y = 0;
           TrsMat.TransformPoints(mypoint);
           int X1 = mypoint[0].X;
           int Y1 = mypoint[0].Y;
           mypoint[0].X = 0;
           mypoint[0].Y = oHeight;
           TrsMat.TransformPoints(mypoint);
           int X2 = mypoint[0].X;
           int Y2 = mypoint[0].Y;
           mypoint[0].X = oWidth;
           mypoint[0].Y = oHeight;
           TrsMat.TransformPoints(mypoint);
           int X3 = mypoint[0].X;
           int Y3 = mypoint[0].Y;

           int MinX = Math.Min(X0, X1);
           MinX = Math.Min(MinX, X2);
           MinX = Math.Min(MinX, X3);

           int MinY = Math.Min(Y0, Y1);
           MinY = Math.Min(MinY, Y2);
           MinY = Math.Min(MinY, Y3);

           int MaxX = Math.Max(X0, X1);
           MaxX = Math.Max(MaxX, X2);
           MaxX = Math.Max(MaxX, X3);

           int MaxY = Math.Max(Y0, Y1);
           MaxY = Math.Max(MaxY, Y2);
           MaxY = Math.Max(MaxY, Y3);

           int nWidth = MaxX - MinX;
           int nHeight = MaxY - MinY;
           TrsMat.Translate(-MinX, -MinY);
           TrsMat.Invert();
           Buff = new Color[nWidth, nHeight];
           double x1, x2, y1, y2;
           double xFraction, yFraction;
           Color newPixel;

           for (int i = 0; i < nHeight; i++)
           {
               for (int j = 0; j < nWidth; j++)
               {
                   mypoint[0].X = j;
                   mypoint[0].Y = i;
                   TrsMat.TransformPoints(mypoint);
                   if (mypoint[0].X < oWidth && mypoint[0].X >= 0 && mypoint[0].Y < oHeight && mypoint[0].Y >= 0)
                   {

                       if (mypoint[0].X == oWidth - 1 && mypoint[0].Y == oHeight-1 ) 
                       {
                           x1 = Math.Floor((double)mypoint[0].X);
                           y1 = Math.Floor((double)mypoint[0].Y);
                           x2 = x1 - 1;
                           y2 = y1 - 1;
                           Color P1 = sourceBuffer[(int)x1, (int)y1];
                           Color P2 = sourceBuffer[(int)x2, (int)y1];
                           Color P3 = sourceBuffer[(int)x1, (int)y2];
                           Color P4 = sourceBuffer[(int)x2, (int)y2];
                           xFraction = mypoint[0].X - x1;
                           yFraction = mypoint[0].Y - y1;
                           Color Z1 = Color.FromArgb(Convert.ToInt32(P1.ToArgb() * (1 - xFraction) + P2.ToArgb() * xFraction));
                           Color Z2 = Color.FromArgb(Convert.ToInt32(P3.ToArgb() * (1 - xFraction) + P4.ToArgb() * xFraction));
                           newPixel = Color.FromArgb(Convert.ToInt32(Z1.ToArgb() * (1 - yFraction) + Z2.ToArgb() * yFraction));
                       }

                       else if (mypoint[0].X == oWidth - 1)
                       {
                           x1 = Math.Floor((double)mypoint[0].X);
                           y1 = Math.Floor((double)mypoint[0].Y);
                           x2 = x1 - 1;
                           y2 = y1 + 1;
                           Color P1 = sourceBuffer[(int)x1, (int)y1];
                           Color P2 = sourceBuffer[(int)x2, (int)y1];
                           Color P3 = sourceBuffer[(int)x1, (int)y2];
                           Color P4 = sourceBuffer[(int)x2, (int)y2];
                           xFraction = mypoint[0].X - x1;
                           yFraction = mypoint[0].Y - y1;
                           Color Z1 = Color.FromArgb(Convert.ToInt32(P1.ToArgb() * (1 - xFraction) + P2.ToArgb() * xFraction));
                           Color Z2 = Color.FromArgb(Convert.ToInt32(P3.ToArgb() * (1 - xFraction) + P4.ToArgb() * xFraction));
                           newPixel = Color.FromArgb(Convert.ToInt32(Z1.ToArgb() * (1 - yFraction) + Z2.ToArgb() * yFraction));
                       }

                       else if (mypoint[0].Y== oHeight - 1)
                       {
                           x1 = Math.Floor((double)mypoint[0].X);
                           y1 = Math.Floor((double)mypoint[0].Y);
                           x2 = x1 + 1;
                           y2 = y1 - 1;
                           Color P1 = sourceBuffer[(int)x1, (int)y1];
                           Color P2 = sourceBuffer[(int)x2, (int)y1];
                           Color P3 = sourceBuffer[(int)x1, (int)y2];
                           Color P4 = sourceBuffer[(int)x2, (int)y2];
                           xFraction = mypoint[0].X - x1;
                           yFraction = mypoint[0].Y - y1;
                           Color Z1 = Color.FromArgb(Convert.ToInt32(P1.ToArgb() * (1 - xFraction) + P2.ToArgb() * xFraction));
                           Color Z2 = Color.FromArgb(Convert.ToInt32(P3.ToArgb() * (1 - xFraction) + P4.ToArgb() * xFraction));
                           newPixel = Color.FromArgb(Convert.ToInt32(Z1.ToArgb() * (1 - yFraction) + Z2.ToArgb() * yFraction));
                       }
                       else
                       {

                           x1 = Math.Floor((double)mypoint[0].X);
                           y1 = Math.Floor((double)mypoint[0].Y);
                           x2 = x1 + 1;
                           y2 = y1 + 1;
                           Color P1 = sourceBuffer[(int)x1, (int)y1];
                           Color P2 = sourceBuffer[(int)x2, (int)y1];
                           Color P3 = sourceBuffer[(int)x1, (int)y2];
                           Color P4 = sourceBuffer[(int)x2, (int)y2];
                           xFraction = mypoint[0].X - x1;
                           yFraction = mypoint[0].Y - y1;
                           Color Z1 = Color.FromArgb(Convert.ToInt32(P1.ToArgb() * (1 - xFraction) + P2.ToArgb() * xFraction));
                           Color Z2 = Color.FromArgb(Convert.ToInt32(P3.ToArgb() * (1 - xFraction) + P4.ToArgb() * xFraction));
                           newPixel = Color.FromArgb(Convert.ToInt32(Z1.ToArgb() * (1 - yFraction) + Z2.ToArgb() * yFraction));





                       }
                       Buff[j, i] = sourceBuffer[mypoint[0].X, mypoint[0].Y];
                   }
                   else
                   {
                       Buff[j, i] = Color.FromArgb(0);
                   }


               }
           }

           return Buff;




       }

       public static Bitmap CropImage(Bitmap source, Rectangle section)
       {
               // An empty bitmap which will hold the cropped image
               Bitmap bmp = new Bitmap(section.Width, section.Height);
               Graphics g = Graphics.FromImage(bmp);
               // Draw the given area (section) of the source image
               // at location 0,0 on the empty bitmap (bmp)
               g.DrawImage(source, 0,0, section, GraphicsUnit.Pixel);
           return bmp;
       }
       public static Bitmap ReadP3(int width, int height,Bitmap bm,string AllFile)
       {
           string[] Rows;
           int Red, Green, Blue;
           int index = 0;
           string[] TmpPixels;
           List<string> AllPixels = new List<string>();
           Rows = AllFile.Split('\n');
           for (int i = 0; i < Rows.Length - 1; i++)
           {
               TmpPixels = Rows[i].Split();
               for (int j = 0; j < TmpPixels.Length - 1; j++)
               {
                   AllPixels.Add(TmpPixels[j]);

               }
           }

           for (int i = 0; i < height; i++)
           {
               for (int j = 0; j < width; j++)
               {
                   Red = Convert.ToInt32(AllPixels[index]);
                   index++;
                   Green = Convert.ToInt32(AllPixels[index]);
                   index++;
                   Blue = Convert.ToInt32(AllPixels[index]);
                   index++;
                   Color color = Color.FromArgb(Red, Green, Blue);
                   bm.SetPixel(j, i, color);
               }
           }
           return bm;
       }
       public static Bitmap ReadP6(int width,int height,string FileName )
       {
           Bitmap bitmap;
           int bytesPerPixel = 3;
           byte[] imageData = new byte[width * height * bytesPerPixel]; ;
           FileStream stream = new FileStream(FileName, FileMode.Open);
           BinaryReader binReader = new BinaryReader(stream);
           int bytesLeft = (int)(binReader.BaseStream.Length - binReader.BaseStream.Position);
           imageData = binReader.ReadBytes(bytesLeft);

           byte[] tempData = new byte[imageData.Length];
           for (int i = 0; i < imageData.Length; i++)
           {
               tempData[i] = imageData[imageData.Length - 1 - i];
           }
           imageData = tempData;

           bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);
           Color color = new Color();
           int red, green, blue;
           int Index;

           for (int x = 0; x < width; x++)
           {
               for (int y = 0; y < height; y++)
               {
                   Index = x + y * width;
                   Index = 3 * Index;
                   blue = (int)imageData[Index];
                   green = (int)imageData[Index + 1];
                   red = (int)imageData[Index + 2];
                   color = Color.FromArgb(red, green, blue);
                   bitmap.SetPixel(x, y, color);
               }
           }
           bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
           return bitmap;
       }
       public static Bitmap ToGray(Bitmap Source )
       {
           Bitmap NewImage=new Bitmap (Source.Width , Source.Height);
           int Red, Green ,Blue;
           Color PColor;
           for (int i = 0; i < Source.Height; i++)
           {
               for (int j = 0; j < Source.Width; j++)
               {
                   PColor=Source.GetPixel(j,i);
                   Red = Convert.ToInt32(PColor.R);
                  Green = Convert.ToInt32(PColor.G);
                   Blue = Convert.ToInt32(PColor.B);
                   int Gray = (Red + Green + Blue) / 3;
                   
                    NewImage.SetPixel(j, i, Color.FromArgb(Gray,Gray,Gray));
               }
           }
           return NewImage;
       }
       public static void DrawHistogram(int []Dist,Panel pnl, string color)
       { 
            
            Graphics g = pnl.CreateGraphics();
            float Max=Dist.Max();
            g.Clear(pnl.BackColor);
         
            Pen pen=new Pen (Color.Red);
           for(int i=0;i<256;i++)
           {
              float normalized =(float)Dist[i] / Max;
              int finalvalue = (int)(normalized * 170.0);
               g.DrawLine(pen, i, 182, i, 182-finalvalue);
           }
       
       
       }
       public static void CalculateHistogram(Bitmap source,Panel pnl)
       { 
        int[]redDistribution =new int[256];
        redDistribution.Initialize();
        int[] blueDistribution = new int[256];
        blueDistribution.Initialize();
        int[] greenDistribution = new int[256];
        greenDistribution.Initialize();
        Color CurrentColor = new Color();
        
        for (int i = 0; i < source.Height; i++)
        {

            for (int j = 0; j < source.Width; j++)
            {
                CurrentColor=   source.GetPixel(j, i);
                redDistribution[Convert.ToInt32(CurrentColor.R)]++;

                greenDistribution[Convert.ToInt32(CurrentColor.G)]++;
                blueDistribution[Convert.ToInt32(CurrentColor.B)]++;
            
            }
        }
        DrawHistogram(redDistribution,pnl,"Blue");
       }
    }
    
}

