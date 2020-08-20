using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Метод_Дейксты
{
    public partial class zapros : Form
    {
        public zapros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
             this.Close();
            }
            else
            {
                MessageBox.Show("Введите расстояние между точками!", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
          
        }

        private void zapros_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar)| e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Контекстное меню запрещен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("0"))
            {
                textBox1.Clear();
            }
        }
    }
}
