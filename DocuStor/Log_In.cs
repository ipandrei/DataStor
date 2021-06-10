using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocuStor
{
    public partial class Log_In : Form
    {
        public Log_In()
        {
            InitializeComponent();

            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Log_In_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataStorEntities context = new DataStorEntities();
            if (username_txtbox.Text != string.Empty && password_txtbox.Text != string.Empty)
            {
                var user = context.Users.Where(a => a.UserName.Equals(username_txtbox.Text)).FirstOrDefault();
                if(user!=null)
                {
                    if (user.Password.Equals(password_txtbox.Text))
                    {
                        LoginInfo.Username = user.UserName;
                        LoginInfo.UserFullName = user.Name;
                        
                        Main mform = new Main();
                        mform.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password");
                    }
                }
            }
            else
            {
                if (username_txtbox.Text == string.Empty)
                {
                    MessageBox.Show("Please enter your username!");
                }
                else
                {
                    MessageBox.Show("Please enter your password!");
                }
            }
        }

        private void password_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
