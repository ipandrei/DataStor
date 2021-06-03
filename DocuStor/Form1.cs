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
            if (username_txtbox.Text != string.Empty || password_txtbox.Text != string.Empty)
            {
                var user = context.Users.Where(a => a.UserName.Equals(username_txtbox.Text)).FirstOrDefault();
                if(user!=null)
                {
                    if (user.Password.Equals(password_txtbox.Text))
                    {
                        System.Diagnostics.Debug.WriteLine("Succes!");
                    }
                }
            }
        }
    }
}
