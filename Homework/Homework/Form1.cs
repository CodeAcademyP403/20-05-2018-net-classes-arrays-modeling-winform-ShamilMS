using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UserPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserData User = new UserData();
            string UserN = User.GetName();
            string UserP = User.GetPassword();

            if (UserName.Text == UserN && UserPassword.Text == UserP)
            {
                MessageBox.Show("Signed in Successfully");
                UserName.Text = "";
                UserPassword.Text = "";
             
            }

            else if (UserName.Text == "" && UserPassword.Text == "")
            {

                MessageBox.Show("Please, fill out all the fields!");
            }

            else if(UserName.Text != UserN && UserPassword.Text != UserP){
                MessageBox.Show("Login or Password is incorrect!");
                UserName.Text = "";
                UserPassword.Text = "";
                UserName.Focus();
            }      

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
