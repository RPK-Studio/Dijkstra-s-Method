using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace Метод_Дейксты
{
    public partial class main : Form
    {
        DrawGraph G;
        List<Vertex> V;
        List<Edge> E;
        int[] posic;
        int rezul = 1;

        int selected1; //выбранные вершины, для соединения линиями
        int selected2;

        SearchPath SP = new SearchPath();
      
        public main()
        {
            InitializeComponent();
            V = new List<Vertex>();
            G = new DrawGraph(sheet.Width, sheet.Height);
            E = new List<Edge>();
            sheet.Image = G.GetBitmap();
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void main_Load(object sender, EventArgs e)
        {
          drawVertexButton.Image = Properties.Resources.RGB;
            selectButton.Image = Properties.Resources.newcursor;
          deleteALLButton.Image = Properties.Resources.deleteAll;
          drawEdgeButton.Image = Properties.Resources.edge;
            searchAllButton.Image = Properties.Resources.searchall;
            searchABButton.Image = Properties.Resources.searchAB;
            saveResultButton.Image = Properties.Resources.saveResult1;
            saveGraphButton.Image = Properties.Resources.saveGraph;
         
           

        }

        private void drawVertexButton_Click(object sender, EventArgs e)
        {
            drawVertexButton.Enabled = false;
            selectButton.Enabled = true;
            drawEdgeButton.Enabled = true;

            for (int i = 0; i < V.Count; i++)
            {
                G.ElipsSel2(V[i].x, V[i].y);
            }
            G.ClearLine(sheet);
            TSV.Text = "";
            sheet.Image = G.GetBitmap();
         
            
        }

        private void sheet_MouseClick(object sender, MouseEventArgs e)
        {
            //нажата кнопка "выбрать вершину", ищем степень вершины
            if (selectButton.Enabled == false)
            {
                for (int i = 0; i < V.Count; i++)
                {
                    if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                    {
                        if (selected1 != -1)
                        {
                            selected1 = -1;
                            for (int z = 0; z < V.Count; z++)
                            {
                                G.ElipsSel2(V[z].x, V[z].y);
                            }
                            sheet.Image = G.GetBitmap();
                        }
                        if (selected1 == -1)
                        {
                            G.ElipsSel(V[i].x, V[i].y);
                            selected1 = i;
                            sheet.Image = G.GetBitmap();
                            break;
                        }
                    }
                }
            }
            //нажата кнопка "рисовать вершину"
            if (drawVertexButton.Enabled == false)
            {
                V.Add(new Vertex(e.X, e.Y));
                G.drawVertex(e.X, e.Y, V.Count.ToString());
                sheet.Image = G.GetBitmap();
            }
           
            //нажата кнопка "рисовать ребро"
            if (drawEdgeButton.Enabled == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    for (int i = 0; i < V.Count; i++)
                    {
                        if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                        {
                            if (selected1 == -1)
                            {
                                G.ElipsSel(V[i].x, V[i].y);
                                selected1 = i;
                                sheet.Image = G.GetBitmap();
                                break;
                            }
                            if (selected2 == -1)
                            {
                                G.ElipsSel(V[i].x, V[i].y);
                                selected2 = i;
                                E.Add(new Edge(selected1, selected2));
                                G.drawEdge(V[selected1], V[selected2], E[E.Count - 1]);

                                if (G.zap=="1")
                                {   
                                     dataGridView1.Rows[selected1].Cells[selected2].Value = G.ok;
                                     dataGridView1.Rows[selected2].Cells[selected1].Value = G.ok;
                                    searchAllButton.Enabled = true;
                                }

                                if (G.zap == "2")
                                {
                                    dataGridView1.Rows[selected1].Cells[selected2].Value = G.ok;
                                    searchAllButton.Enabled = true;
                                }

                                selected1 = -1;
                                selected2 = -1;
                                sheet.Image = G.GetBitmap();
                                break;
                            }
                       }
                    }
                }
                if (e.Button == MouseButtons.Right)
                {
                    if ((selected1 != -1) &&
                        (Math.Pow((V[selected1].x - e.X), 2) + Math.Pow((V[selected1].y - e.Y), 2) <= G.R * G.R))
                    {
                        G.drawVertex(V[selected1].x, V[selected1].y, (selected1 + 1).ToString());
                        selected1 = -1;
                        sheet.Image = G.GetBitmap();
                    }
                }
            }
            
        }
        
        private void selectButton_Click(object sender, EventArgs e)
        {
           
            selectButton.Enabled = false;
            drawVertexButton.Enabled = true;
            drawEdgeButton.Enabled = true;
            for (int i = 0; i < V.Count; i++)
            {
                G.ElipsSel2(V[i].x, V[i].y);
            }
            G.ClearLine(sheet);
            TSV.Text = "";
            sheet.Image = G.GetBitmap();
           selected1 = -1;
        }

        

        private void drawEdgeButton_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = V.Count;
            dataGridView1.ColumnCount = V.Count;
           
            
            drawEdgeButton.Enabled = false;
            selectButton.Enabled = true;
            drawVertexButton.Enabled = true;
            for (int i = 0; i < V.Count; i++)
            {
             G.ElipsSel2(V[i].x,V[i].y);
            }
            G.ClearLine(sheet);
            TSV.Text = "";
            sheet.Image = G.GetBitmap();
            selected1 = -1;
            selected2 = -1;

         
        }

        private void deleteALLButton_Click(object sender, EventArgs e)
        {
            selectButton.Enabled = true;
            drawVertexButton.Enabled = true;
            drawEdgeButton.Enabled = true;
            searchABButton.Enabled = false;
            searchAllButton.Enabled = false;
            textBox2.Visible = false;
            TSV.Text = "";
            const string message = "Вы действительно хотите полностью удалить граф?";
            const string caption = "Удаление";
            var MBSave = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MBSave == DialogResult.Yes)
            {
                V.Clear();
                E.Clear();
                G.clearSheet();
                sheet.Image = G.GetBitmap();
                textBox1.Clear();
                textBox2.Clear();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                разделитель.Visible = false;
                результатBT.Visible = false;

                for (int r = 0; r < dataGridView1.RowCount; r++)
                {
                    for (int c = 0; c < dataGridView1.ColumnCount; c++)
                    {

                        dataGridView1.Rows[r].Cells[c].Value = null;


                    }
                }

               
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
          
        }

        private void вариант1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
        private void searchAllButton_Click(object sender, EventArgs e)
        {
          
                selectButton.Enabled = true;
                drawVertexButton.Enabled = true;
                drawEdgeButton.Enabled = true;
                for (int vert = 0; vert < V.Count; vert++)
                {
                    G.ElipsSel2(V[vert].x, V[vert].y);
                }
                G.ClearLine(sheet);
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                textBox1.Clear();
                textBox2.Clear();
                TSV.Text = "";

            for (int r = 0; r <V.Count; r++)
                {
                    for (int c = 0; c < V.Count; c++)
                    {
                        if (dataGridView1.Rows[r].Cells[c].Value == null)
                        {
                            dataGridView1.Rows[r].Cells[c].Value = "1000";
                        }

                    }
                }


                for (int r = 0; r < V.Count; r++)
                {
                    for (int c = 0; c < V.Count; c++)
                    {
                        if (r == c)
                        {
                            dataGridView1.Rows[r].Cells[c].Value = 0.ToString();
                        }

                    }
                }


                
                int[,] adjacency_matrix = new int[V.Count, V.Count];
                for (int r = 0; r < V.Count; r++)
                {
                    for (int c = 0; c < V.Count; c++)
                    {
                        adjacency_matrix[r, c] = Int32.Parse(dataGridView1.Rows[r].Cells[c].Value.ToString());
                    }
                }
                int minimizeDistance, position, i, j;
                int vertex = 0;
                int[] d = new int[V.Count + 1], post = new int[V.Count + 1];
                bool[] t = new bool[V.Count + 1];


                minimizeDistance = 0;
                for (i = 0; i < V.Count; i++)
                {
                    d[i] = adjacency_matrix[0, i];
                    post[i] = 0;
                    t[i] = true;
                }
                t[0] = false; post[0] = 0;
                for (i = 0; i < V.Count - 1; i++)
                {

                    minimizeDistance = 1000;
                    for (j = 0; j < V.Count; j++)
                        if ((t[j] == true) && (minimizeDistance > d[j]))
                        {
                            minimizeDistance = d[j];
                            vertex = j;
                        }



                    t[vertex] = false;
                    for (j = 0; j < V.Count; j++)
                        if ((t[j] == true) && (d[j] > d[vertex] + adjacency_matrix[vertex, j]))
                        {
                            d[j] = d[vertex] + adjacency_matrix[vertex, j];
                            post[j] = vertex;
                        }
                }


                textBox1.Text = "Вершины:";
                for (int z = 0; z < V.Count; z++)
                {
                    textBox1.Text = textBox1.Text + z.ToString() + "\t";
                    listBox2.Items.Add(z);
                }

                textBox1.Text = textBox1.Text + Environment.NewLine + "Дистанция:";
                for (i = 0; i < adjacency_matrix.GetLength(0); i++)
                {
                    textBox1.Text = textBox1.Text + d[i] + "\t";
                    listBox3.Items.Add(d[i]);
                }



                for (int dis = 0; dis < V.Count; dis++)
                {
                    position = dis;
                    textBox1.Text = textBox1.Text + Environment.NewLine + "Конечная вершина = " + (position) + ", до него: ";
                    do
                    {
                        position = post[position];
                        textBox1.Text = textBox1.Text + (position) + "\t";
                    }
                    while (position != 0);

                }


                for (int a = 2; a < textBox1.Lines.Length; a++)
                {
                    string slovo = textBox1.Lines[a].ToString();

                    string vv = slovo.Remove(0, 30);
                    string vvv = vv.Replace("\t", " ");
                    string vvvv = ReverseWords(vvv.ToString());
                    listBox1.Items.Add(vvvv);
                }

                if (textBox1.Text != "")
                {
                
                File.WriteAllText("Paths.txt", string.Empty);
                    int[,] adjacency_matrixx = new int[V.Count, V.Count];
                    for (int r = 0; r < V.Count; r++)
                    {
                        for (int c = 0; c < V.Count; c++)
                        {
                            adjacency_matrixx[r, c] = Int32.Parse(dataGridView1.Rows[r].Cells[c].Value.ToString());
                        }
                    }
                    int minimizeDistancex, positionx, ix, jx;
                    int vertexx = 0;
                    int[] dx = new int[V.Count + 1], postx = new int[V.Count + 1];
                    bool[] tx = new bool[V.Count + 1];


                    minimizeDistancex = 0;
                    for (ix = 0; ix < V.Count; ix++)
                    {
                        dx[ix] = adjacency_matrixx[0, ix];
                        postx[ix] = 0;
                        tx[ix] = true;
                    }
                    tx[0] = false; postx[0] = 0;
                    for (ix = 0; ix < V.Count - 1; ix++)
                    {

                        minimizeDistancex = 1000;
                        for (jx = 0; jx < V.Count; jx++)
                            if ((tx[jx] == true) && (minimizeDistancex > dx[jx]))
                            {
                                minimizeDistancex = dx[jx];
                                vertexx = jx;
                            }



                        tx[vertexx] = false;
                        for (jx = 0; jx < V.Count; jx++)
                            if ((tx[jx] == true) && (dx[jx] > dx[vertexx] + adjacency_matrixx[vertexx, jx]))
                            {
                                dx[jx] = dx[vertexx] + adjacency_matrixx[vertexx, jx];
                                postx[jx] = vertexx;
                            }
                    }


                    textBox2.Text = "Вершины:";
                    for (int z = 1; z < V.Count + 1; z++)
                    {
                        textBox2.Text = textBox2.Text + z.ToString() + "\t";

                    }

                    textBox2.Text = textBox2.Text + Environment.NewLine + "Дистанция:";
                    for (ix = 0; ix < adjacency_matrixx.GetLength(0); ix++)
                        textBox2.Text = textBox2.Text + dx[ix] + "\t";


                    for (int dis = 0; dis < V.Count; dis++)
                    {
                        positionx = dis;
                        textBox2.Text = textBox2.Text + Environment.NewLine + "Конечная вершина = " + (positionx + 1) + ", до него: ";
                        do
                        {
                            positionx = postx[positionx];
                            textBox2.Text = textBox2.Text + "\t" + (positionx + 1);
                        }
                        while (positionx != 0);

                    }

                    for (int a = 0; a < textBox2.Lines.Length; a++)
                    {
                        if (a >= 2)
                        {
                            string slovov = textBox2.Lines[a].ToString();
                            string vva = slovov.Replace("\t", "<--");
                            using (StreamWriter wr = new StreamWriter("Paths.txt", true))
                            {
                                wr.WriteLine(vva);
                            }
                        }
                        else
                        {
                            using (StreamWriter wr = new StreamWriter("Paths.txt", true))
                            {
                                wr.WriteLine(textBox2.Lines[a].ToString());
                            }
                        }



                    }
                }


                textBox2.Text = File.ReadAllText("Paths.txt");
                searchABButton.Enabled = true;
                разделитель.Visible = true;
                результатBT.Visible = true;
                textBox2.Visible = true;

            
        }


        private void searchABButton_Click(object sender, EventArgs e)
        {
            try
            {
                selectButton.Enabled = true;
                drawVertexButton.Enabled = true;
                drawEdgeButton.Enabled = true;
                G.ClearLine(sheet);


                for (int vert = 0; vert < V.Count; vert++)
                {
                    G.ElipsSel2(V[vert].x, V[vert].y);
                }
                
                SP.ShowDialog();
                if (SP.textBox1.Text != "")
                {

                    int i = 0;
                    int ver = int.Parse(SP.textBox1.Text) - 1;
                    SP.textBox1.Clear();
                    string slovo = listBox1.Items[ver].ToString();
                    string[] words = slovo.Split(new char[] { ' ' });
                    posic = new int[words.Length - 1];
                    foreach (string s in words)
                    {

                        if (s != "")
                        {
                            posic[i] = int.Parse(s);
                            i++;
                        }


                    }
                    posic[i] = int.Parse(listBox2.Items[ver].ToString());
                    for (int v = 0; v < posic.Length; v++)
                    {

                        G.ElipsSel(V[posic[v]].x, V[posic[v]].y);
                        sheet.Image = G.GetBitmap();

                    }


                    for (int p = 0; p < posic.Length - 2; p++)
                    {

                        G.PathLine(V[posic[p]], V[posic[p + 1]]);
                        sheet.Image = G.GetBitmap();


                    }
                    if (listBox3.Items[ver].ToString() != 1000.ToString())
                    {
                        G.PathLine(V[posic[0]], V[ver]);
                    }
                    else
                    {
                        G.ClearLine(sheet);
                        for (int vert = 0; vert < V.Count; vert++)
                        {
                            G.ElipsSel2(V[vert].x, V[vert].y);
                        }
                        MessageBox.Show("Нет связи между вершинами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    TSV.Text = String.Format("{0}.  Растояние до вершины {1} = {2}.",textBox2.Lines[ver+2].ToString(),(ver+1).ToString(),listBox3.Items[ver].ToString());
                }
                else
                {

                }
            }
            catch { }
        }
        static string ReverseWords(string str)
        {
            string[] words = str.Split();
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = new string(words[i].Reverse().ToArray());
            }
            return string.Join(" ", words);
        }

        private void saveResultButton_Click(object sender, EventArgs e)
        {
            selectButton.Enabled = true;
            drawVertexButton.Enabled = true;
            drawEdgeButton.Enabled = true;
            try
            {
                File.WriteAllText("Paths.txt", string.Empty);
                int[,] adjacency_matrix = new int[V.Count, V.Count];
                for (int r = 0; r < V.Count; r++)
                {
                    for (int c = 0; c < V.Count; c++)
                    {
                        adjacency_matrix[r, c] = Int32.Parse(dataGridView1.Rows[r].Cells[c].Value.ToString());
                    }
                }
                int minimizeDistance, position, i, j;
                int vertex = 0;
                int[] d = new int[V.Count + 1], post = new int[V.Count + 1];
                bool[] t = new bool[V.Count + 1];


                minimizeDistance = 0;
                for (i = 0; i < V.Count; i++)
                {
                    d[i] = adjacency_matrix[0, i];
                    post[i] = 0;
                    t[i] = true;
                }
                t[0] = false; post[0] = 0;
                for (i = 0; i < V.Count - 1; i++)
                {

                    minimizeDistance = 1000;
                    for (j = 0; j < V.Count; j++)
                        if ((t[j] == true) && (minimizeDistance > d[j]))
                        {
                            minimizeDistance = d[j];
                            vertex = j;
                        }



                    t[vertex] = false;
                    for (j = 0; j < V.Count; j++)
                        if ((t[j] == true) && (d[j] > d[vertex] + adjacency_matrix[vertex, j]))
                        {
                            d[j] = d[vertex] + adjacency_matrix[vertex, j];
                            post[j] = vertex;
                        }
                }


                textBox2.Text = "Вершины:";
                for (int z = 1; z < V.Count + 1; z++)
                {
                    textBox2.Text = textBox2.Text + z.ToString() + "\t";

                }

                textBox2.Text = textBox2.Text + Environment.NewLine + "Дистанция:";
                for (i = 0; i < adjacency_matrix.GetLength(0); i++)
                    textBox2.Text = textBox2.Text + d[i] + "\t";


                for (int dis = 0; dis < V.Count; dis++)
                {
                    position = dis;
                    textBox2.Text = textBox2.Text + Environment.NewLine + "Конечная вершина = " + (position + 1) + ", до него: ";
                    do
                    {
                        position = post[position];
                        textBox2.Text = textBox2.Text + "\t" + (position + 1);
                    }
                    while (position != 0);

                }

                for (int a = 0; a < textBox2.Lines.Length; a++)
                {
                    if (a >= 2)
                    {
                        string slovov = textBox2.Lines[a].ToString();
                        string vva = slovov.Replace("\t", "<--");
                        using (StreamWriter wr = new StreamWriter("Paths.txt", true))
                        {
                            wr.WriteLine(vva);
                        }
                    }
                    else
                    {
                        using (StreamWriter wr = new StreamWriter("Paths.txt", true))
                        {
                            wr.WriteLine(textBox2.Lines[a].ToString());
                        }
                    }



                }

                if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog2.FileName, File.ReadAllText("Paths.txt"));
                    MessageBox.Show("Файл сохранен", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch { MessageBox.Show("Нет данных для сохранения!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }

        private void saveGraphButton_Click(object sender, EventArgs e)
        {
            selectButton.Enabled = true;
            drawVertexButton.Enabled = true;
            drawEdgeButton.Enabled = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                    G.GetBitmap().Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show("Файл сохранен","Сохранение", MessageBoxButtons.OK,MessageBoxIcon.Information);
                
               
            }
          
        }

        private void toolStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void результатBT_Click(object sender, EventArgs e)
        {
            rezul++;
            if ((rezul % 2) == 0)
            {
                textBox2.Visible = false;
            }
            else
            {
                textBox2.Visible = true;
            }
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
