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
    public partial class zastavka : Form
    {
      
        public zastavka()
        {
            InitializeComponent();
            this.Opacity = 0; // прозрачность формы при открытии
           
        }

        private void zastavka_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent; // прозразность фона текста
            label2.BackColor = Color.Transparent; // прозразность фона текста
            timer1.Start(); 
          
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // таймер появления формы
        private void timer1_Tick(object sender, EventArgs e) 
        {
            if (this.Opacity < 1)  // если прозначноть меньше 1 
            {
                this.Opacity = this.Opacity + 0.07d; // увелечиваем процент прозрачности
            }
            if (this.Opacity == 1) // если дошли до 1
            {
                timer1.Stop(); // 1 таймер останавливаем
                timer2.Start(); // 2 таймер запускаем
            } 
            

        }

        // таймер исчезновения 
        private void timer2_Tick(object sender, EventArgs e)
        {
           
                this.Opacity = this.Opacity - 0.1d; // удавляем прозрачность
                if (this.Opacity == 0) // если дошли до 0 
                {
                    timer2.Stop(); // останавливаем таймер
                    this.Hide(); // скрываем фформы
                main ad = new main();
                ad.Show(); // открываем основную форму
                }

            
        }
    }
}
