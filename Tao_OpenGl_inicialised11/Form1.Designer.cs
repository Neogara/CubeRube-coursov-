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
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.button1 = new System.Windows.Forms.Button();
            this.RenderTimer = new System.Windows.Forms.Timer(this.components);
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LabelMenu = new System.Windows.Forms.Label();
            this.RenderAnimation = new System.Windows.Forms.Timer(this.components);
            this.RecTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            this.PauseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnT.Location = new System.Drawing.Point(0, 0);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(876, 500);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            this.AnT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnT_KeyDown);
            this.AnT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseDown);
            this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseMove);
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
            this.RenderTimer.Enabled = true;
            this.RenderTimer.Interval = 50;
            this.RenderTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PanelMenu
            // 
            this.PanelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelMenu.Controls.Add(this.button5);
            this.PanelMenu.Controls.Add(this.buttonExit);
            this.PanelMenu.Controls.Add(this.button3);
            this.PanelMenu.Controls.Add(this.button2);
            this.PanelMenu.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.PanelMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PanelMenu.Location = new System.Drawing.Point(696, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(177, 256);
            this.PanelMenu.TabIndex = 2;
            this.PanelMenu.Leave += new System.EventHandler(this.panel1_Leave);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Turquoise;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Bookman Old Style", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(2, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 50);
            this.button5.TabIndex = 3;
            this.button5.Text = "Рекорды";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Turquoise;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Bookman Old Style", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(3, 201);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(172, 50);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Turquoise;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bookman Old Style", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(2, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 50);
            this.button3.TabIndex = 1;
            this.button3.Text = "Настройки";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(2, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "Новая игра ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // LabelMenu
            // 
            this.LabelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.LabelMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelMenu.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LabelMenu.Location = new System.Drawing.Point(814, 3);
            this.LabelMenu.Name = "LabelMenu";
            this.LabelMenu.Size = new System.Drawing.Size(50, 21);
            this.LabelMenu.TabIndex = 3;
            this.LabelMenu.Text = "[МЕНЮ]";
            this.LabelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelMenu.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // RenderAnimation
            // 
            this.RenderAnimation.Interval = 1;
            // 
            // RecTimer
            // 
            this.RecTimer.Interval = 1;
            this.RecTimer.Tick += new System.EventHandler(this.RecTimer_Tick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(876, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PauseLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.LabelMenu);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AnT);
            this.Name = "Form1";
            this.Text = "Кубик Рубик By NeoGara";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer RenderTimer;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LabelMenu;
        private System.Windows.Forms.Timer RenderAnimation;
        private System.Windows.Forms.Timer RecTimer;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label PauseLabel;
        private System.Windows.Forms.Label label1;

    }
}

