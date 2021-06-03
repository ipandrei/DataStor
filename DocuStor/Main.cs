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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            label1.Text = LoginInfo.UserFullName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
