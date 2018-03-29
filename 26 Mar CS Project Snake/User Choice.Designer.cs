namespace _26_Mar_CS_Project_Snake
{
    partial class User_Choice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_SquareSize = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TrackBar_Red = new System.Windows.Forms.TrackBar();
            this.TrackBar_Green = new System.Windows.Forms.TrackBar();
            this.TrackBar_Blue = new System.Windows.Forms.TrackBar();
            this.TextBox_Red = new System.Windows.Forms.TextBox();
            this.TextBox_Green = new System.Windows.Forms.TextBox();
            this.TextBox_Blue = new System.Windows.Forms.TextBox();
            this.PictBoxColor = new System.Windows.Forms.PictureBox();
            this.TrackBar_Alpha = new System.Windows.Forms.TrackBar();
            this.TextBox_Alpha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Alpha)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_SquareSize
            // 
            this.TextBox_SquareSize.Location = new System.Drawing.Point(129, 29);
            this.TextBox_SquareSize.Name = "TextBox_SquareSize";
            this.TextBox_SquareSize.Size = new System.Drawing.Size(100, 20);
            this.TextBox_SquareSize.TabIndex = 0;
            this.TextBox_SquareSize.Text = "100";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Square Size:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TrackBar_Red
            // 
            this.TrackBar_Red.Location = new System.Drawing.Point(150, 113);
            this.TrackBar_Red.Maximum = 255;
            this.TrackBar_Red.Name = "TrackBar_Red";
            this.TrackBar_Red.Size = new System.Drawing.Size(104, 45);
            this.TrackBar_Red.TabIndex = 3;
            this.TrackBar_Red.Value = 255;
            this.TrackBar_Red.Scroll += new System.EventHandler(this.TrackBar_Red_Scroll);
            // 
            // TrackBar_Green
            // 
            this.TrackBar_Green.Location = new System.Drawing.Point(150, 164);
            this.TrackBar_Green.Maximum = 255;
            this.TrackBar_Green.Name = "TrackBar_Green";
            this.TrackBar_Green.Size = new System.Drawing.Size(104, 45);
            this.TrackBar_Green.TabIndex = 3;
            this.TrackBar_Green.Value = 255;
            this.TrackBar_Green.Scroll += new System.EventHandler(this.TrackBar_Green_Scroll);
            // 
            // TrackBar_Blue
            // 
            this.TrackBar_Blue.Location = new System.Drawing.Point(150, 215);
            this.TrackBar_Blue.Maximum = 255;
            this.TrackBar_Blue.Name = "TrackBar_Blue";
            this.TrackBar_Blue.Size = new System.Drawing.Size(104, 45);
            this.TrackBar_Blue.TabIndex = 3;
            this.TrackBar_Blue.Value = 255;
            this.TrackBar_Blue.Scroll += new System.EventHandler(this.TrackBar_Blue_Scroll);
            // 
            // TextBox_Red
            // 
            this.TextBox_Red.Location = new System.Drawing.Point(260, 113);
            this.TextBox_Red.Name = "TextBox_Red";
            this.TextBox_Red.ReadOnly = true;
            this.TextBox_Red.Size = new System.Drawing.Size(53, 20);
            this.TextBox_Red.TabIndex = 4;
            this.TextBox_Red.Text = "255";
            // 
            // TextBox_Green
            // 
            this.TextBox_Green.Location = new System.Drawing.Point(260, 164);
            this.TextBox_Green.Name = "TextBox_Green";
            this.TextBox_Green.ReadOnly = true;
            this.TextBox_Green.Size = new System.Drawing.Size(53, 20);
            this.TextBox_Green.TabIndex = 4;
            this.TextBox_Green.Text = "255";
            // 
            // TextBox_Blue
            // 
            this.TextBox_Blue.Location = new System.Drawing.Point(260, 215);
            this.TextBox_Blue.Name = "TextBox_Blue";
            this.TextBox_Blue.ReadOnly = true;
            this.TextBox_Blue.Size = new System.Drawing.Size(53, 20);
            this.TextBox_Blue.TabIndex = 4;
            this.TextBox_Blue.Text = "255";
            // 
            // PictBoxColor
            // 
            this.PictBoxColor.Location = new System.Drawing.Point(12, 98);
            this.PictBoxColor.Name = "PictBoxColor";
            this.PictBoxColor.Size = new System.Drawing.Size(116, 122);
            this.PictBoxColor.TabIndex = 5;
            this.PictBoxColor.TabStop = false;
            // 
            // TrackBar_Alpha
            // 
            this.TrackBar_Alpha.Location = new System.Drawing.Point(150, 62);
            this.TrackBar_Alpha.Maximum = 255;
            this.TrackBar_Alpha.Name = "TrackBar_Alpha";
            this.TrackBar_Alpha.Size = new System.Drawing.Size(104, 45);
            this.TrackBar_Alpha.TabIndex = 3;
            this.TrackBar_Alpha.Value = 255;
            this.TrackBar_Alpha.Scroll += new System.EventHandler(this.TrackBar_Alpha_Scroll);
            // 
            // TextBox_Alpha
            // 
            this.TextBox_Alpha.Location = new System.Drawing.Point(260, 62);
            this.TextBox_Alpha.Name = "TextBox_Alpha";
            this.TextBox_Alpha.ReadOnly = true;
            this.TextBox_Alpha.Size = new System.Drawing.Size(53, 20);
            this.TextBox_Alpha.TabIndex = 4;
            this.TextBox_Alpha.Text = "255";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ALPHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "RED";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "GREEN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "BLUE";
            // 
            // User_Choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 340);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PictBoxColor);
            this.Controls.Add(this.TextBox_Blue);
            this.Controls.Add(this.TextBox_Green);
            this.Controls.Add(this.TextBox_Alpha);
            this.Controls.Add(this.TextBox_Red);
            this.Controls.Add(this.TrackBar_Blue);
            this.Controls.Add(this.TrackBar_Green);
            this.Controls.Add(this.TrackBar_Alpha);
            this.Controls.Add(this.TrackBar_Red);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBox_SquareSize);
            this.Name = "User_Choice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.User_Choice_FormClosed);
            this.Load += new System.EventHandler(this.User_Choice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Alpha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_SquareSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar TrackBar_Red;
        private System.Windows.Forms.TrackBar TrackBar_Green;
        private System.Windows.Forms.TrackBar TrackBar_Blue;
        private System.Windows.Forms.TextBox TextBox_Red;
        private System.Windows.Forms.TextBox TextBox_Green;
        private System.Windows.Forms.TextBox TextBox_Blue;
        private System.Windows.Forms.PictureBox PictBoxColor;
        private System.Windows.Forms.TrackBar TrackBar_Alpha;
        private System.Windows.Forms.TextBox TextBox_Alpha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}