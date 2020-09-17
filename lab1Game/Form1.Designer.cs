namespace lab1Game
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
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGrey = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonContrast = new System.Windows.Forms.Button();
            this.buttonChannel = new System.Windows.Forms.Button();
            this.button90 = new System.Windows.Forms.Button();
            this.button180 = new System.Windows.Forms.Button();
            this.buttonGauss = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Enabled = false;
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonGrey
            // 
            this.buttonGrey.Location = new System.Drawing.Point(12, 435);
            this.buttonGrey.Name = "buttonGrey";
            this.buttonGrey.Size = new System.Drawing.Size(189, 22);
            this.buttonGrey.TabIndex = 2;
            this.buttonGrey.Text = "Сделать черно-белым";
            this.buttonGrey.UseVisualStyleBackColor = true;
            this.buttonGrey.Click += new System.EventHandler(this.buttonGrey_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(496, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(462, 372);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // buttonContrast
            // 
            this.buttonContrast.Location = new System.Drawing.Point(12, 463);
            this.buttonContrast.Name = "buttonContrast";
            this.buttonContrast.Size = new System.Drawing.Size(189, 23);
            this.buttonContrast.TabIndex = 4;
            this.buttonContrast.Text = "Увеличить контрасность на 50 %";
            this.buttonContrast.UseVisualStyleBackColor = true;
            this.buttonContrast.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonChannel
            // 
            this.buttonChannel.Location = new System.Drawing.Point(12, 492);
            this.buttonChannel.Name = "buttonChannel";
            this.buttonChannel.Size = new System.Drawing.Size(189, 23);
            this.buttonChannel.TabIndex = 5;
            this.buttonChannel.Text = "Замена каналов";
            this.buttonChannel.UseVisualStyleBackColor = true;
            this.buttonChannel.Click += new System.EventHandler(this.button2_Click);
            // 
            // button90
            // 
            this.button90.Location = new System.Drawing.Point(285, 435);
            this.button90.Name = "button90";
            this.button90.Size = new System.Drawing.Size(189, 22);
            this.button90.TabIndex = 6;
            this.button90.Text = "Поворот 90 градусов";
            this.button90.UseVisualStyleBackColor = true;
            this.button90.Click += new System.EventHandler(this.button3_Click);
            // 
            // button180
            // 
            this.button180.Location = new System.Drawing.Point(285, 464);
            this.button180.Name = "button180";
            this.button180.Size = new System.Drawing.Size(189, 22);
            this.button180.TabIndex = 7;
            this.button180.Text = "Поворот 180 градусов";
            this.button180.UseVisualStyleBackColor = true;
            this.button180.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonGauss
            // 
            this.buttonGauss.Location = new System.Drawing.Point(285, 493);
            this.buttonGauss.Name = "buttonGauss";
            this.buttonGauss.Size = new System.Drawing.Size(189, 22);
            this.buttonGauss.TabIndex = 8;
            this.buttonGauss.Text = "Размытие по Гауссу";
            this.buttonGauss.UseVisualStyleBackColor = true;
            this.buttonGauss.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(972, 551);
            this.Controls.Add(this.buttonGauss);
            this.Controls.Add(this.button180);
            this.Controls.Add(this.button90);
            this.Controls.Add(this.buttonChannel);
            this.Controls.Add(this.buttonContrast);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonGrey);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lab1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGrey;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonContrast;
        private System.Windows.Forms.Button buttonChannel;
        private System.Windows.Forms.Button button90;
        private System.Windows.Forms.Button button180;
        private System.Windows.Forms.Button buttonGauss;
    }
}

