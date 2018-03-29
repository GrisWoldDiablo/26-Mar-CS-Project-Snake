using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_Mar_CS_Project_Snake
{
    public partial class User_Choice : Form
    {
        Color myColor = new Color();
        int alpha;
        int red;
        int green;
        int blue;
        public User_Choice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(TextBox_SquareSize.Text, out Form1.squareSize);
            Form1.initColor = myColor;
            this.Hide();
        }

        private void User_Choice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void User_Choice_Load(object sender, EventArgs e)
        {
            alpha = red = green = blue = 255;

            myColor = Color.FromArgb(alpha, red, green, blue);
            PictBoxColor.BackColor = myColor;
        }

        private void TrackBar_Red_Scroll(object sender, EventArgs e)
        {
            TextBox_Red.Text =  TrackBar_Red.Value.ToString();
            red = TrackBar_Red.Value;
            myColor = Color.FromArgb(alpha, red, green, blue);
            PictBoxColor.BackColor = myColor;
        }

        private void TrackBar_Green_Scroll(object sender, EventArgs e)
        {
            TextBox_Green.Text = TrackBar_Green.Value.ToString();
            green = TrackBar_Green.Value;
            myColor = Color.FromArgb(alpha, red, green, blue);
            PictBoxColor.BackColor = myColor;
        }

        private void TrackBar_Blue_Scroll(object sender, EventArgs e)
        {
            TextBox_Blue.Text = TrackBar_Blue.Value.ToString();
            blue = TrackBar_Blue.Value;
            myColor = Color.FromArgb(alpha, red, green, blue);
            PictBoxColor.BackColor = myColor;
        }

        private void TrackBar_Alpha_Scroll(object sender, EventArgs e)
        {
            TextBox_Alpha.Text = TrackBar_Alpha.Value.ToString();
            alpha = TrackBar_Alpha.Value;
            myColor = Color.FromArgb(alpha, red, green, blue);
            PictBoxColor.BackColor = myColor;
        }
    }
}
