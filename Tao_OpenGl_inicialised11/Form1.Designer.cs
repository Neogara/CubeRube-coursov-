namespace Tao_OpenGl_inicialised11
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.RenderTimer = new System.Windows.Forms.Timer(this.components);
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.RecordButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.RenderAnimation = new System.Windows.Forms.Timer(this.components);
            this.RecTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            this.PauseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.RecordsPanel = new System.Windows.Forms.Panel();
            this.RecordSavePanel = new System.Windows.Forms.Panel();
            this.SaveNewRecordButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NewNameRecordText = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.OpenGlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            this.RecordsPanel.SuspendLayout();
            this.RecordSavePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RenderTimer
            // 
            this.RenderTimer.Interval = 50;
            this.RenderTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PanelMenu
            // 
            this.PanelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelMenu.Controls.Add(this.RecordButton);
            this.PanelMenu.Controls.Add(this.ExitButton);
            this.PanelMenu.Controls.Add(this.SettingsButton);
            this.PanelMenu.Controls.Add(this.NewGameButton);
            this.PanelMenu.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.PanelMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PanelMenu.Location = new System.Drawing.Point(696, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(177, 256);
            this.PanelMenu.TabIndex = 2;
            this.PanelMenu.Leave += new System.EventHandler(this.panel1_Leave);
            // 
            // RecordButton
            // 
            this.RecordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RecordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RecordButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.RecordButton.FlatAppearance.BorderSize = 0;
            this.RecordButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.RecordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.RecordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.RecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecordButton.Font = new System.Drawing.Font("Bookman Old Style", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.RecordButton.Location = new System.Drawing.Point(2, 55);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(172, 50);
            this.RecordButton.TabIndex = 3;
            this.RecordButton.Text = "Рекорды";
            this.RecordButton.UseVisualStyleBackColor = false;
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Bookman Old Style", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(3, 201);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(172, 50);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.SettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Bookman Old Style", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.SettingsButton.Location = new System.Drawing.Point(2, 111);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(172, 50);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NewGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NewGameButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.NewGameButton.FlatAppearance.BorderSize = 0;
            this.NewGameButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.NewGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.NewGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.NewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGameButton.Font = new System.Drawing.Font("Bookman Old Style", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.NewGameButton.Location = new System.Drawing.Point(2, -1);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(172, 50);
            this.NewGameButton.TabIndex = 0;
            this.NewGameButton.Text = "Новая игра ";
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // MenuLabel
            // 
            this.MenuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuLabel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.MenuLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.MenuLabel.Location = new System.Drawing.Point(814, 3);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(50, 21);
            this.MenuLabel.TabIndex = 3;
            this.MenuLabel.Text = "[МЕНЮ]";
            this.MenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MenuLabel.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // RenderAnimation
            // 
            this.RenderAnimation.Interval = 1;
            // 
            // RecTimer
            // 
            this.RecTimer.Tick += new System.EventHandler(this.RecTimer_Tick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(12, 20);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(71, 20);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "00:00:00";
            this.TimeLabel.Visible = false;
            // 
            // PauseLabel
            // 
            this.PauseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PauseLabel.BackColor = System.Drawing.Color.LightGray;
            this.PauseLabel.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.PauseLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseLabel.Font = new System.Drawing.Font("Bookman Old Style", 40F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PauseLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PauseLabel.Location = new System.Drawing.Point(491, 259);
            this.PauseLabel.Name = "PauseLabel";
            this.PauseLabel.Size = new System.Drawing.Size(385, 233);
            this.PauseLabel.TabIndex = 8;
            this.PauseLabel.Text = "Пауза";
            this.PauseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PauseLabel.UseMnemonic = false;
            this.PauseLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер куба";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(143, 11);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(346, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SettingsPanel.Controls.Add(this.ColorLabel);
            this.SettingsPanel.Controls.Add(this.label2);
            this.SettingsPanel.Controls.Add(this.trackBar1);
            this.SettingsPanel.Controls.Add(this.label1);
            this.SettingsPanel.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.SettingsPanel.Font = new System.Drawing.Font("Bookman Old Style", 40F, System.Drawing.FontStyle.Italic);
            this.SettingsPanel.Location = new System.Drawing.Point(136, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(554, 256);
            this.SettingsPanel.TabIndex = 9;
            this.SettingsPanel.Visible = false;
            this.SettingsPanel.Leave += new System.EventHandler(this.SettingsPanel_Leave);
            // 
            // ColorLabel
            // 
            this.ColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorLabel.Location = new System.Drawing.Point(140, 47);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(343, 16);
            this.ColorLabel.TabIndex = 10;
            this.ColorLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цвет Мира";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorDialog1
            // 
            this.colorDialog1.AllowFullOpen = false;
            this.colorDialog1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colorDialog1.SolidColorOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 46);
            this.label3.TabIndex = 10;
            this.label3.Text = "label";
            // 
            // RecordsPanel
            // 
            this.RecordsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RecordsPanel.Controls.Add(this.RecordSavePanel);
            this.RecordsPanel.Controls.Add(this.listBox1);
            this.RecordsPanel.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.RecordsPanel.Font = new System.Drawing.Font("Bookman Old Style", 25F, System.Drawing.FontStyle.Italic);
            this.RecordsPanel.Location = new System.Drawing.Point(0, 0);
            this.RecordsPanel.Name = "RecordsPanel";
            this.RecordsPanel.Size = new System.Drawing.Size(351, 381);
            this.RecordsPanel.TabIndex = 11;
            this.RecordsPanel.Visible = false;
            // 
            // RecordSavePanel
            // 
            this.RecordSavePanel.Controls.Add(this.SaveNewRecordButton);
            this.RecordSavePanel.Controls.Add(this.label4);
            this.RecordSavePanel.Controls.Add(this.NewNameRecordText);
            this.RecordSavePanel.Location = new System.Drawing.Point(25, 275);
            this.RecordSavePanel.Name = "RecordSavePanel";
            this.RecordSavePanel.Size = new System.Drawing.Size(297, 106);
            this.RecordSavePanel.TabIndex = 13;
            this.RecordSavePanel.Visible = false;
            // 
            // SaveNewRecordButton
            // 
            this.SaveNewRecordButton.Location = new System.Drawing.Point(251, 7);
            this.SaveNewRecordButton.Name = "SaveNewRecordButton";
            this.SaveNewRecordButton.Size = new System.Drawing.Size(34, 93);
            this.SaveNewRecordButton.TabIndex = 16;
            this.SaveNewRecordButton.Text = ">";
            this.SaveNewRecordButton.UseVisualStyleBackColor = true;
            this.SaveNewRecordButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 38);
            this.label4.TabIndex = 15;
            this.label4.Text = "Введите имя";
            // 
            // NewNameRecordText
            // 
            this.NewNameRecordText.Location = new System.Drawing.Point(10, 53);
            this.NewNameRecordText.MaxLength = 15;
            this.NewNameRecordText.Name = "NewNameRecordText";
            this.NewNameRecordText.Size = new System.Drawing.Size(225, 47);
            this.NewNameRecordText.TabIndex = 14;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Bookman Old Style", 25F, System.Drawing.FontStyle.Italic);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(3, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(345, 370);
            this.listBox1.TabIndex = 0;
            // 
            // OpenGlControl
            // 
            this.OpenGlControl.AccumBits = ((byte)(0));
            this.OpenGlControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenGlControl.AutoCheckErrors = false;
            this.OpenGlControl.AutoFinish = false;
            this.OpenGlControl.AutoMakeCurrent = true;
            this.OpenGlControl.AutoSwapBuffers = true;
            this.OpenGlControl.BackColor = System.Drawing.Color.Black;
            this.OpenGlControl.ColorBits = ((byte)(32));
            this.OpenGlControl.DepthBits = ((byte)(16));
            this.OpenGlControl.Location = new System.Drawing.Point(0, -1);
            this.OpenGlControl.Name = "OpenGlControl";
            this.OpenGlControl.Size = new System.Drawing.Size(889, 459);
            this.OpenGlControl.StencilBits = ((byte)(0));
            this.OpenGlControl.TabIndex = 12;
            this.OpenGlControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnT_KeyDown);
            this.OpenGlControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseDown);
            this.OpenGlControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(876, 500);
            this.Controls.Add(this.RecordsPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.PauseLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.MenuLabel);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OpenGlControl);
            this.Name = "Form1";
            this.Text = "Кубик Рубик By NeoGara";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.RecordsPanel.ResumeLayout(false);
            this.RecordSavePanel.ResumeLayout(false);
            this.RecordSavePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer RenderTimer;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button RecordButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Timer RenderAnimation;
        private System.Windows.Forms.Timer RecTimer;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label PauseLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel RecordsPanel;
        private Tao.Platform.Windows.SimpleOpenGlControl OpenGlControl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel RecordSavePanel;
        private System.Windows.Forms.Button SaveNewRecordButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NewNameRecordText;

    }
}

