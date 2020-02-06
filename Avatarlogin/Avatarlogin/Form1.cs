using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Avatarlogin
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        List<Image> images = new List<Image>();
        string[] location = new string[25];
        public Form1()
        {

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            location[0] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_1.jpg";
            location[1] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_2.jpg";
            location[2] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_3.jpg";
            location[3] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_4.jpg";
            location[4] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_5.jpg";
            location[5] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_6.jpg";
            location[6] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_7.jpg";
            location[7] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_8.jpg";
            location[8] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_9.jpg";
            location[9] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_10.jpg";
            location[10] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_11.jpg";
            location[11] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_12.jpg";
            location[12] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_13.jpg";
            location[13] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_14.jpg";
            location[14] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_15.jpg";
            location[15] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_16.jpg";
            location[16] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_17.jpg";
            location[17] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_18.jpg";
            location[18] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_19.jpg";
            location[19] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_20.jpg";
            location[20] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_21.jpg";
            location[21] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_22.jpg";
            location[22] = @"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_user_23.jpg";
            diapo();
        }

        private void diapo()
        {
            for (int i = 0; i < 23; i++) {
                Bitmap bitmap = new Bitmap(location[i]);
                images.Add(bitmap);
            }
            images.Add(Properties.Resources.textbox_user_24);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox1.Text.Length <= 15)
            {
                pictureBox1.Image = images[textBox1.Text.Length - 1];
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (textBox1.Text.Length <= 0)
                pictureBox1.Image = Properties.Resources.debut;
            else
                pictureBox1.Image = images[22];
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap (@"C:\Users\RPL\Documents\Visual Studio 2008\Projects\Avatarlogin\Avatarlogin\Animation\textbox_password.png");
            pictureBox1.Image = bm;
            textBox2.PasswordChar = '*';
        
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                pictureBox1.Image = images[textBox1.Text.Length - 1];
            else
                pictureBox1.Image = Properties.Resources.debut;

        }
    }
}
