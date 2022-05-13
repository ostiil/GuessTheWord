
namespace GuessTheWord
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.правилаИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алфавитToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.английскиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таймерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сек59ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.минутаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.минута2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LookWordButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.minLabel = new System.Windows.Forms.Label();
            this.secLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правилаИгрыToolStripMenuItem,
            this.алфавитToolStripMenuItem,
            this.таймерToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(386, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // правилаИгрыToolStripMenuItem
            // 
            this.правилаИгрыToolStripMenuItem.Name = "правилаИгрыToolStripMenuItem";
            this.правилаИгрыToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.правилаИгрыToolStripMenuItem.Text = "Правила игры";
            this.правилаИгрыToolStripMenuItem.Click += new System.EventHandler(this.правилаИгрыToolStripMenuItem_Click);
            // 
            // алфавитToolStripMenuItem
            // 
            this.алфавитToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.русскийToolStripMenuItem,
            this.английскиToolStripMenuItem});
            this.алфавитToolStripMenuItem.Name = "алфавитToolStripMenuItem";
            this.алфавитToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.алфавитToolStripMenuItem.Text = "Алфавит";
            // 
            // русскийToolStripMenuItem
            // 
            this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            this.русскийToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.русскийToolStripMenuItem.Text = "Русский";
            this.русскийToolStripMenuItem.Click += new System.EventHandler(this.русскийToolStripMenuItem_Click);
            // 
            // английскиToolStripMenuItem
            // 
            this.английскиToolStripMenuItem.Name = "английскиToolStripMenuItem";
            this.английскиToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.английскиToolStripMenuItem.Text = "Английский";
            this.английскиToolStripMenuItem.Click += new System.EventHandler(this.английскиToolStripMenuItem_Click);
            // 
            // таймерToolStripMenuItem
            // 
            this.таймерToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сек59ToolStripMenuItem,
            this.минутаToolStripMenuItem1,
            this.минута2ToolStripMenuItem});
            this.таймерToolStripMenuItem.Name = "таймерToolStripMenuItem";
            this.таймерToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.таймерToolStripMenuItem.Text = "Таймер";
            // 
            // сек59ToolStripMenuItem
            // 
            this.сек59ToolStripMenuItem.Name = "сек59ToolStripMenuItem";
            this.сек59ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сек59ToolStripMenuItem.Text = "0:59 минут";
            this.сек59ToolStripMenuItem.Click += new System.EventHandler(this.сек59ToolStripMenuItem_Click);
            // 
            // минутаToolStripMenuItem1
            // 
            this.минутаToolStripMenuItem1.Name = "минутаToolStripMenuItem1";
            this.минутаToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.минутаToolStripMenuItem1.Text = "1:30 минут";
            this.минутаToolStripMenuItem1.Click += new System.EventHandler(this.минутаToolStripMenuItem1_Click);
            // 
            // минута2ToolStripMenuItem
            // 
            this.минута2ToolStripMenuItem.Name = "минута2ToolStripMenuItem";
            this.минута2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.минута2ToolStripMenuItem.Text = "2:00 минуты";
            this.минута2ToolStripMenuItem.Click += new System.EventHandler(this.секундToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите слово:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(179, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 3;
            // 
            // CheckButton
            // 
            this.CheckButton.Enabled = false;
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckButton.Location = new System.Drawing.Point(260, 300);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(114, 29);
            this.CheckButton.TabIndex = 4;
            this.CheckButton.Text = "Проверить";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Для начала игры выберите алфавит";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(22, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 81);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вы угадали! Загаданная буква ";
            this.label3.Visible = false;
            // 
            // LookWordButton
            // 
            this.LookWordButton.Enabled = false;
            this.LookWordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LookWordButton.Location = new System.Drawing.Point(140, 300);
            this.LookWordButton.Name = "LookWordButton";
            this.LookWordButton.Size = new System.Drawing.Size(114, 29);
            this.LookWordButton.TabIndex = 11;
            this.LookWordButton.Text = "Сдаться";
            this.LookWordButton.UseVisualStyleBackColor = true;
            this.LookWordButton.Click += new System.EventHandler(this.LookWordButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minLabel.Location = new System.Drawing.Point(21, 300);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(18, 20);
            this.minLabel.TabIndex = 12;
            this.minLabel.Text = "0";
            // 
            // secLabel
            // 
            this.secLabel.AutoSize = true;
            this.secLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secLabel.Location = new System.Drawing.Point(64, 300);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(18, 20);
            this.secLabel.TabIndex = 13;
            this.secLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(45, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = ":";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(386, 341);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.secLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.LookWordButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Угадай слово\"";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem правилаИгрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LookWordButton;
        private System.Windows.Forms.ToolStripMenuItem алфавитToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem английскиToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label secLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem таймерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сек59ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem минутаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem минута2ToolStripMenuItem;
    }
}

