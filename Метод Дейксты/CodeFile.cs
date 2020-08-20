using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;


namespace Метод_Дейксты
{
    class Vertex
    {
        public int x, y;

        public Vertex(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
    }

    class Edge
    {
        public int v1, v2;

        public Edge(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }


    class DrawGraph
    {
        Bitmap bitmap;
        Pen blackPen;
        Pen RedPen;
        Pen BluePen;
        Pen RedSel;
        Graphics gr;
        Font fo;
        Brush pur;
        Brush br;
        PointF point;
        public int R = 20; //радиус окружности вершины
        public string ok;
        zapros zp = new zapros();
        public string zap ;
   




        public DrawGraph(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            gr = Graphics.FromImage(bitmap);
            clearSheet();
            blackPen = new Pen(Color.Black);
            blackPen.Width = 3;
            RedPen = new Pen(Color.Red, 3);
            BluePen = new Pen(Color.Blue);
            BluePen.Width = 3;
            fo = new Font("Arial", 20);
            br = Brushes.Black;
            pur = Brushes.DarkRed;
           
          
        }

        public void ClearLine(PictureBox picture)
        {
            for (int x = 0; x < picture.Width; x++)
            {
                for (int y = 0; y < picture.Height; y++)
                {
                    if (((Bitmap)picture.Image).GetPixel(x, y).ToArgb() == Color.Red.ToArgb())
                    {
                        ((Bitmap)picture.Image).SetPixel(x, y, Color.Blue);
                    }
                }
            }
        }
        public Bitmap GetBitmap()
        {
            return bitmap;
        }

      
        public void clearSheet()
        {
            gr.Clear(Color.White);
        }

       
        public void drawVertex(int x, int y, string number)
        {
            gr.FillEllipse(Brushes.White, (x - R), (y - R), 2 * R, 2 * R);
            gr.DrawEllipse(blackPen, (x - R), (y - R), 2 * R, 2 * R);
            point = new PointF(x - 9, y - 9);
            gr.DrawString(number, fo, br, point);
        }

        public void ElipsSel( int x,int y)
        {
            RedSel = new Pen(Color.FromArgb(128, 13, 255, 5), 3);
            gr.DrawEllipse(RedSel, (x - R), (y - R), (2 * R ), (2 * R ));
          
        }

     public void ElipsSel2 (int x,int y)
        {
            RedSel =  new Pen(Color.FromArgb(255, 0, 0, 0), 3);
            gr.DrawEllipse(RedSel, (x - R), (y - R), (2 * R), (2 * R));
           

        }
        
      
        public void PathLine (Vertex v1 , Vertex v2)
        {
            gr.DrawLine(RedPen, v1.x, v1.y, v2.x, v2.y);
        }
        public void drawEdge(Vertex V1, Vertex V2, Edge E)
        {
           

            zp.ShowDialog();


            if (zp.textBox1.Text != "")
            {
                if (zp.NeorRB.Checked == true)
                {
                    zap = "1";
                    ok = zp.textBox1.Text;
                    zp.textBox1.Clear();
                    point = new PointF((V1.x + V2.x) / 2, (V1.y + V2.y) / 2);
                    gr.DrawString((ok).ToString(), fo, pur, point);
                    BluePen.StartCap = LineCap.NoAnchor;
                    BluePen.EndCap = LineCap.NoAnchor;
                    ElipsSel2(V1.x, V1.y);
                    ElipsSel2(V2.x, V2.y);
                    gr.DrawLine(BluePen, V1.x, V1.y, V2.x, V2.y);

               
                
                  

                }
                if (zp.OtABRB.Checked == true)
                {
                    zap = "2";
                    ok = zp.textBox1.Text;
                    zp.textBox1.Clear();
                    point = new PointF((V1.x + V2.x) / 2, (V1.y + V2.y) / 2);
                    gr.DrawString((ok).ToString(), fo, pur, point);
                    AdjustableArrowCap Arrow = new AdjustableArrowCap(4, 4);
                    BluePen.StartCap = LineCap.RoundAnchor;
                    BluePen.CustomEndCap = Arrow;
                    ElipsSel2(V1.x, V1.y);
                    ElipsSel2(V2.x, V2.y);
                    gr.DrawLine(BluePen, V1.x, V1.y, V2.x, V2.y);
                   

                }


            }

        }


    }
}
