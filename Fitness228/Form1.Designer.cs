namespace Fitness228
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            icon = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)icon).BeginInit();
            SuspendLayout();
            // 
            // icon
            // 
            icon.BackColor = Color.DarkSlateBlue;
            icon.BackgroundImage = Properties.Resources.FITNESSS1;
            icon.BackgroundImageLayout = ImageLayout.Zoom;
            icon.Location = new Point(340, -25);
            icon.Name = "icon";
            icon.Size = new Size(163, 114);
            icon.SizeMode = PictureBoxSizeMode.Zoom;
            icon.TabIndex = 0;
            icon.TabStop = false;
            icon.Click += icon_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateBlue;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.SlateBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sans Serif Collection", 6.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(101, 144);
            button1.Name = "button1";
            button1.Size = new Size(236, 78);
            button1.TabIndex = 1;
            button1.Text = "Соотношение веса и роста";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SlateBlue;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.SlateBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Sans Serif Collection", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(793, 12);
            button2.Name = "button2";
            button2.Size = new Size(45, 45);
            button2.TabIndex = 2;
            button2.Text = "x";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseMnemonic = false;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SlateBlue;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.SlateBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Sans Serif Collection", 6.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(507, 144);
            button3.Name = "button3";
            button3.Size = new Size(236, 78);
            button3.TabIndex = 3;
            button3.Text = "Тренировка";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SlateBlue;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.SlateBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Sans Serif Collection", 6.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(101, 311);
            button4.Name = "button4";
            button4.Size = new Size(236, 78);
            button4.TabIndex = 4;
            button4.Text = "Прокачка";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.SlateBlue;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.SlateBlue;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Sans Serif Collection", 6.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(507, 311);
            button5.Name = "button5";
            button5.Size = new Size(236, 78);
            button5.TabIndex = 5;
            button5.Text = "сушиться(удалить все)";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(850, 500);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(icon);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeadInsideFitnesss";
            ((System.ComponentModel.ISupportInitialize)icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox icon;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
