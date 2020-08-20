namespace Метод_Дейксты
{
    partial class main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.selectButton = new System.Windows.Forms.Button();
            this.deleteALLButton = new System.Windows.Forms.Button();
            this.drawEdgeButton = new System.Windows.Forms.Button();
            this.drawVertexButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveGraphButton = new System.Windows.Forms.Button();
            this.saveResultButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.разделитель = new System.Windows.Forms.ToolStripSeparator();
            this.результатBT = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchABButton = new System.Windows.Forms.Button();
            this.searchAllButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.sheet = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSV = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectButton
            // 
            this.selectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectButton.Location = new System.Drawing.Point(10, 19);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(50, 50);
            this.selectButton.TabIndex = 0;
            this.toolTip1.SetToolTip(this.selectButton, "Выбрать ");
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // deleteALLButton
            // 
            this.deleteALLButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteALLButton.Location = new System.Drawing.Point(80, 81);
            this.deleteALLButton.Name = "deleteALLButton";
            this.deleteALLButton.Size = new System.Drawing.Size(50, 50);
            this.deleteALLButton.TabIndex = 0;
            this.toolTip1.SetToolTip(this.deleteALLButton, "Очистить");
            this.deleteALLButton.UseVisualStyleBackColor = true;
            this.deleteALLButton.Click += new System.EventHandler(this.deleteALLButton_Click);
            // 
            // drawEdgeButton
            // 
            this.drawEdgeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drawEdgeButton.Location = new System.Drawing.Point(10, 81);
            this.drawEdgeButton.Name = "drawEdgeButton";
            this.drawEdgeButton.Size = new System.Drawing.Size(50, 50);
            this.drawEdgeButton.TabIndex = 0;
            this.toolTip1.SetToolTip(this.drawEdgeButton, "Соединить");
            this.drawEdgeButton.UseVisualStyleBackColor = true;
            this.drawEdgeButton.Click += new System.EventHandler(this.drawEdgeButton_Click);
            // 
            // drawVertexButton
            // 
            this.drawVertexButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drawVertexButton.Location = new System.Drawing.Point(80, 19);
            this.drawVertexButton.Name = "drawVertexButton";
            this.drawVertexButton.Size = new System.Drawing.Size(50, 50);
            this.drawVertexButton.TabIndex = 0;
            this.toolTip1.SetToolTip(this.drawVertexButton, "Нарисовать");
            this.drawVertexButton.UseVisualStyleBackColor = true;
            this.drawVertexButton.Click += new System.EventHandler(this.drawVertexButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectButton);
            this.groupBox1.Controls.Add(this.drawVertexButton);
            this.groupBox1.Controls.Add(this.deleteALLButton);
            this.groupBox1.Controls.Add(this.saveGraphButton);
            this.groupBox1.Controls.Add(this.saveResultButton);
            this.groupBox1.Controls.Add(this.drawEdgeButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 195);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инструмены";
            // 
            // saveGraphButton
            // 
            this.saveGraphButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveGraphButton.Location = new System.Drawing.Point(80, 137);
            this.saveGraphButton.Name = "saveGraphButton";
            this.saveGraphButton.Size = new System.Drawing.Size(50, 50);
            this.saveGraphButton.TabIndex = 0;
            this.toolTip1.SetToolTip(this.saveGraphButton, "Сохранить граф");
            this.saveGraphButton.UseVisualStyleBackColor = true;
            this.saveGraphButton.Click += new System.EventHandler(this.saveGraphButton_Click);
            // 
            // saveResultButton
            // 
            this.saveResultButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveResultButton.Location = new System.Drawing.Point(10, 137);
            this.saveResultButton.Name = "saveResultButton";
            this.saveResultButton.Size = new System.Drawing.Size(50, 50);
            this.saveResultButton.TabIndex = 0;
            this.toolTip1.SetToolTip(this.saveResultButton, "Сохранить результат");
            this.saveResultButton.UseVisualStyleBackColor = true;
            this.saveResultButton.Click += new System.EventHandler(this.saveResultButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripDropDownButton2,
            this.toolStripButton1,
            this.toolStripButton2,
            this.разделитель,
            this.результатBT});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1022, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseClick);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.toolStripDropDownButton2.Image = global::Метод_Дейксты.Properties.Resources.fail;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(65, 22);
            this.toolStripDropDownButton2.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Метод_Дейксты.Properties.Resources.dev;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(97, 22);
            this.toolStripButton1.Text = "Разработчик";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Метод_Дейксты.Properties.Resources.opr;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(102, 22);
            this.toolStripButton2.Text = "О программе";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // разделитель
            // 
            this.разделитель.Name = "разделитель";
            this.разделитель.Size = new System.Drawing.Size(6, 25);
            this.разделитель.Visible = false;
            // 
            // результатBT
            // 
            this.результатBT.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.результатBT.Image = global::Метод_Дейксты.Properties.Resources.variant;
            this.результатBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.результатBT.Name = "результатBT";
            this.результатBT.Size = new System.Drawing.Size(80, 22);
            this.результатBT.Text = "Результат";
            this.результатBT.Visible = false;
            this.результатBT.Click += new System.EventHandler(this.результатBT_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchABButton);
            this.groupBox2.Controls.Add(this.searchAllButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 81);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Решение";
            // 
            // searchABButton
            // 
            this.searchABButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchABButton.Enabled = false;
            this.searchABButton.Location = new System.Drawing.Point(80, 19);
            this.searchABButton.Name = "searchABButton";
            this.searchABButton.Size = new System.Drawing.Size(50, 50);
            this.searchABButton.TabIndex = 0;
            this.toolTip1.SetToolTip(this.searchABButton, "Найти от A до B");
            this.searchABButton.UseVisualStyleBackColor = true;
            this.searchABButton.Click += new System.EventHandler(this.searchABButton_Click);
            // 
            // searchAllButton
            // 
            this.searchAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchAllButton.Enabled = false;
            this.searchAllButton.Location = new System.Drawing.Point(10, 19);
            this.searchAllButton.Name = "searchAllButton";
            this.searchAllButton.Size = new System.Drawing.Size(50, 50);
            this.searchAllButton.TabIndex = 0;
            this.toolTip1.SetToolTip(this.searchAllButton, "Найти все пути");
            this.searchAllButton.UseVisualStyleBackColor = true;
            this.searchAllButton.Click += new System.EventHandler(this.searchAllButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(181, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(241, 171);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(452, 308);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(558, 109);
            this.textBox1.TabIndex = 7;
            this.textBox1.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(689, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(87, 186);
            this.listBox1.TabIndex = 9;
            this.listBox1.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(800, 44);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(78, 186);
            this.listBox2.TabIndex = 10;
            this.listBox2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 371);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(844, 155);
            this.textBox2.TabIndex = 11;
            this.textBox2.Visible = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPG|*.jpg";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "TXT|*.txt";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(884, 44);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(81, 186);
            this.listBox3.TabIndex = 12;
            this.listBox3.Visible = false;
            // 
            // sheet
            // 
            this.sheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sheet.Location = new System.Drawing.Point(166, 41);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(844, 485);
            this.sheet.TabIndex = 2;
            this.sheet.TabStop = false;
            this.sheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sheet_MouseClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSV});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1022, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSV
            // 
            this.TSV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSV.Name = "TSV";
            this.TSV.Size = new System.Drawing.Size(1007, 17);
            this.TSV.Spring = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 550);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sheet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Алгоритм Дейкстры";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.Load += new System.EventHandler(this.main_Load);
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawVertexButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button deleteALLButton;
        private System.Windows.Forms.Button drawEdgeButton;
        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchAllButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button searchABButton;
        private System.Windows.Forms.Button saveGraphButton;
        private System.Windows.Forms.Button saveResultButton;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ToolStripButton результатBT;
        private System.Windows.Forms.ToolStripSeparator разделитель;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSV;
    }
}

