namespace VideoPlayer
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
            this.components = new System.ComponentModel.Container();
            this.Screen = new System.Windows.Forms.Panel();
            this.PlayListBox = new System.Windows.Forms.ListBox();
            this.Previo = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.TrackBar = new System.Windows.Forms.TrackBar();
            this.VideoName = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полныйЭкранToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.громкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.плейлистToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВидеоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pause = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Screen.Location = new System.Drawing.Point(16, 34);
            this.Screen.Margin = new System.Windows.Forms.Padding(4);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(735, 454);
            this.Screen.TabIndex = 0;
            // 
            // PlayListBox
            // 
            this.PlayListBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PlayListBox.FormattingEnabled = true;
            this.PlayListBox.ItemHeight = 16;
            this.PlayListBox.Location = new System.Drawing.Point(972, 34);
            this.PlayListBox.Margin = new System.Windows.Forms.Padding(4);
            this.PlayListBox.Name = "PlayListBox";
            this.PlayListBox.Size = new System.Drawing.Size(265, 452);
            this.PlayListBox.TabIndex = 0;
            this.PlayListBox.SelectedIndexChanged += new System.EventHandler(this.PlayListBox_SelectedIndexChanged);
            this.PlayListBox.DoubleClick += new System.EventHandler(this.PlayListBox_DoubleClick);
            // 
            // Previo
            // 
            this.Previo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Previo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Previo.Location = new System.Drawing.Point(16, 542);
            this.Previo.Margin = new System.Windows.Forms.Padding(4);
            this.Previo.Name = "Previo";
            this.Previo.Size = new System.Drawing.Size(140, 50);
            this.Previo.TabIndex = 1;
            this.Previo.Text = "Предыдущий";
            this.Previo.UseVisualStyleBackColor = false;
            this.Previo.Click += new System.EventHandler(this.Previo_Click);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Play.Enabled = false;
            this.Play.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Play.Location = new System.Drawing.Point(787, 52);
            this.Play.Margin = new System.Windows.Forms.Padding(4);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(140, 50);
            this.Play.TabIndex = 2;
            this.Play.Text = "Играть";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Next.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next.Location = new System.Drawing.Point(643, 542);
            this.Next.Margin = new System.Windows.Forms.Padding(4);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(140, 50);
            this.Next.TabIndex = 3;
            this.Next.Text = "Следующий";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // TrackBar
            // 
            this.TrackBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TrackBar.Location = new System.Drawing.Point(991, 536);
            this.TrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.TrackBar.Maximum = 0;
            this.TrackBar.Minimum = -10000;
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.Size = new System.Drawing.Size(228, 56);
            this.TrackBar.TabIndex = 19;
            this.TrackBar.Visible = false;
            this.TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // VideoName
            // 
            this.VideoName.AutoSize = true;
            this.VideoName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.VideoName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VideoName.Location = new System.Drawing.Point(293, 503);
            this.VideoName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VideoName.Name = "VideoName";
            this.VideoName.Size = new System.Drawing.Size(179, 25);
            this.VideoName.TabIndex = 13;
            this.VideoName.Text = "Название видео";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.Location = new System.Drawing.Point(311, 613);
            this.Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(124, 18);
            this.Time.TabIndex = 6;
            this.Time.Text = "00:00:00/00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.плейлистToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1267, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.полныйЭкранToolStripMenuItem,
            this.громкостьToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // полныйЭкранToolStripMenuItem
            // 
            this.полныйЭкранToolStripMenuItem.Name = "полныйЭкранToolStripMenuItem";
            this.полныйЭкранToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.полныйЭкранToolStripMenuItem.Text = "Полный экран";
            this.полныйЭкранToolStripMenuItem.Click += new System.EventHandler(this.полныйЭкранToolStripMenuItem_Click);
            // 
            // громкостьToolStripMenuItem
            // 
            this.громкостьToolStripMenuItem.Name = "громкостьToolStripMenuItem";
            this.громкостьToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.громкостьToolStripMenuItem.Text = "Громкость";
            this.громкостьToolStripMenuItem.Click += new System.EventHandler(this.громкостьToolStripMenuItem_Click);
            // 
            // плейлистToolStripMenuItem
            // 
            this.плейлистToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.удалитьВидеоToolStripMenuItem});
            this.плейлистToolStripMenuItem.Name = "плейлистToolStripMenuItem";
            this.плейлистToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.плейлистToolStripMenuItem.Text = "Плейлист";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.открытьToolStripMenuItem.Text = "Добавить видео";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.добавитьВидеоToolStripMenuItem_Click);
            // 
            // удалитьВидеоToolStripMenuItem
            // 
            this.удалитьВидеоToolStripMenuItem.Name = "удалитьВидеоToolStripMenuItem";
            this.удалитьВидеоToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.удалитьВидеоToolStripMenuItem.Text = "Удалить видео";
            this.удалитьВидеоToolStripMenuItem.Click += new System.EventHandler(this.удалитьВидеоToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click_1);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pause.Enabled = false;
            this.Pause.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pause.Location = new System.Drawing.Point(787, 129);
            this.Pause.Margin = new System.Windows.Forms.Padding(4);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(140, 50);
            this.Pause.TabIndex = 20;
            this.Pause.Text = "Пауза";
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Continue
            // 
            this.Continue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Continue.Enabled = false;
            this.Continue.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Continue.Location = new System.Drawing.Point(787, 206);
            this.Continue.Margin = new System.Windows.Forms.Padding(4);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(140, 50);
            this.Continue.TabIndex = 21;
            this.Continue.Text = "Продолжить";
            this.Continue.UseVisualStyleBackColor = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(163, 542);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(473, 56);
            this.trackBar1.TabIndex = 22;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1073, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Громкость";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1267, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.VideoName);
            this.Controls.Add(this.TrackBar);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Previo);
            this.Controls.Add(this.PlayListBox);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "VideoPlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Screen;
        private System.Windows.Forms.ListBox PlayListBox;
        private System.Windows.Forms.Button Previo;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TrackBar TrackBar;
        private System.Windows.Forms.Label VideoName;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полныйЭкранToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem громкостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem плейлистToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВидеоToolStripMenuItem;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
    }
}

