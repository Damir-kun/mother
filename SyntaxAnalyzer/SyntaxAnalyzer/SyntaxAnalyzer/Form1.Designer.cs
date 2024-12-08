namespace SyntaxAnalyzer
{
    partial class Form1
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.запускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.анализToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.очисткаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.исходныйТекстПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.результатыАнализаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.окноУведомленийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.полнаяОчисткаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оРазработчикеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView4 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запускToolStripMenuItem,
            this.анализToolStripMenuItem,
            this.очисткаToolStripMenuItem,
            this.менюToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1438, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// запускToolStripMenuItem
			// 
			this.запускToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.выходToolStripMenuItem});
			this.запускToolStripMenuItem.Name = "запускToolStripMenuItem";
			this.запускToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
			this.запускToolStripMenuItem.Text = "Файл";
			// 
			// открытьToolStripMenuItem
			// 
			this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
			this.открытьToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
			this.открытьToolStripMenuItem.Text = "Открыть";
			this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
			// 
			// сохранитьКакToolStripMenuItem
			// 
			this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
			this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
			this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
			this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click_1);
			// 
			// анализToolStripMenuItem
			// 
			this.анализToolStripMenuItem.Name = "анализToolStripMenuItem";
			this.анализToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
			this.анализToolStripMenuItem.Text = "Анализ";
			this.анализToolStripMenuItem.Click += new System.EventHandler(this.анализToolStripMenuItem_Click);
			// 
			// очисткаToolStripMenuItem
			// 
			this.очисткаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.исходныйТекстПрограммыToolStripMenuItem,
            this.результатыАнализаToolStripMenuItem,
            this.окноУведомленийToolStripMenuItem,
            this.полнаяОчисткаToolStripMenuItem});
			this.очисткаToolStripMenuItem.Name = "очисткаToolStripMenuItem";
			this.очисткаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
			this.очисткаToolStripMenuItem.Text = "Очистка";
			// 
			// исходныйТекстПрограммыToolStripMenuItem
			// 
			this.исходныйТекстПрограммыToolStripMenuItem.Name = "исходныйТекстПрограммыToolStripMenuItem";
			this.исходныйТекстПрограммыToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
			this.исходныйТекстПрограммыToolStripMenuItem.Text = "Исходный текст программы";
			this.исходныйТекстПрограммыToolStripMenuItem.Click += new System.EventHandler(this.исходныйТекстПрограммыToolStripMenuItem_Click);
			// 
			// результатыАнализаToolStripMenuItem
			// 
			this.результатыАнализаToolStripMenuItem.Name = "результатыАнализаToolStripMenuItem";
			this.результатыАнализаToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
			this.результатыАнализаToolStripMenuItem.Text = "Результаты анализа";
			this.результатыАнализаToolStripMenuItem.Click += new System.EventHandler(this.результатыАнализаToolStripMenuItem_Click);
			// 
			// окноУведомленийToolStripMenuItem
			// 
			this.окноУведомленийToolStripMenuItem.Name = "окноУведомленийToolStripMenuItem";
			this.окноУведомленийToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
			this.окноУведомленийToolStripMenuItem.Text = "Окно уведомлений";
			this.окноУведомленийToolStripMenuItem.Click += new System.EventHandler(this.окноУведомленийToolStripMenuItem_Click);
			// 
			// полнаяОчисткаToolStripMenuItem
			// 
			this.полнаяОчисткаToolStripMenuItem.Name = "полнаяОчисткаToolStripMenuItem";
			this.полнаяОчисткаToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
			this.полнаяОчисткаToolStripMenuItem.Text = "Полная очистка";
			this.полнаяОчисткаToolStripMenuItem.Click += new System.EventHandler(this.полнаяОчисткаToolStripMenuItem_Click);
			// 
			// менюToolStripMenuItem
			// 
			this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оРазработчикеToolStripMenuItem});
			this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
			this.менюToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
			this.менюToolStripMenuItem.Text = "Справка";
			// 
			// оРазработчикеToolStripMenuItem
			// 
			this.оРазработчикеToolStripMenuItem.Name = "оРазработчикеToolStripMenuItem";
			this.оРазработчикеToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
			this.оРазработчикеToolStripMenuItem.Text = "О разработчике";
			this.оРазработчикеToolStripMenuItem.Click += new System.EventHandler(this.оРазработчикеToolStripMenuItem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.dataGridView4);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dataGridView3);
			this.groupBox1.Controls.Add(this.dataGridView2);
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Location = new System.Drawing.Point(858, 31);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(561, 551);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Таблицы";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(302, 375);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(210, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Таблица идентификаторов (3)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 375);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Таблица чисел (2)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(302, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(185, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Таблица разделителей (1)";
			// 
			// dataGridView4
			// 
			this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView4.Location = new System.Drawing.Point(9, 395);
			this.dataGridView4.Name = "dataGridView4";
			this.dataGridView4.RowHeadersWidth = 51;
			this.dataGridView4.RowTemplate.Height = 24;
			this.dataGridView4.Size = new System.Drawing.Size(252, 150);
			this.dataGridView4.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Таблица служебных слов (0)";
			this.label1.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// dataGridView3
			// 
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Location = new System.Drawing.Point(305, 395);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.RowHeadersWidth = 51;
			this.dataGridView3.RowTemplate.Height = 24;
			this.dataGridView3.Size = new System.Drawing.Size(245, 150);
			this.dataGridView3.TabIndex = 2;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(305, 50);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.Size = new System.Drawing.Size(245, 317);
			this.dataGridView2.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(9, 50);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(252, 317);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(15, 51);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(516, 525);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(183, 17);
			this.label5.TabIndex = 8;
			this.label5.Text = "Исходный тест программы";
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(553, 51);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(299, 525);
			this.richTextBox2.TabIndex = 9;
			this.richTextBox2.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(550, 31);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(145, 17);
			this.label6.TabIndex = 10;
			this.label6.Text = "Результаты анализа";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 587);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(133, 17);
			this.label7.TabIndex = 11;
			this.label7.Text = "Окно уведомлений\r\n";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// richTextBox3
			// 
			this.richTextBox3.Location = new System.Drawing.Point(15, 607);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new System.Drawing.Size(1408, 72);
			this.richTextBox3.TabIndex = 12;
			this.richTextBox3.Text = "";
			// 
			// Num
			// 
			this.Num.MinimumWidth = 6;
			this.Num.Name = "Num";
			this.Num.Width = 125;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1438, 701);
			this.Controls.Add(this.richTextBox3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Синтаксический анализатор";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оРазработчикеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запускToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.ToolStripMenuItem анализToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очисткаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исходныйТекстПрограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатыАнализаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окноУведомленийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полнаяОчисткаToolStripMenuItem;
    }
}

