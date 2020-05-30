using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actual_password_project_LOL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void poop_Click(object sender, EventArgs e)
        {
            //this is the minimum length and maximum length 
            int minLength = 8;
            int maxLength = 16;
            //characters that have an opprotunity to show up in gen
            string charAvailable = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789`~!@#$%^&*()_+-=[];',./";

            StringBuilder password = new StringBuilder();
            Random rdm = new Random();

            
            int passwordLength = rdm.Next(minLength, maxLength + 1);
            
            while (passwordLength-- > 0)
                password.Append(charAvailable[rdm.Next(charAvailable.Length)]);

            ball.Text = password.ToString();
        }
        //hi miss hoff hope you enjoy my project
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }
        Point lastPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
