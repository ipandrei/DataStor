using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocuStor
{
    public partial class AddContent : Form
    {
        public AddContent()
        {
            InitializeComponent();

            CenterToScreen();

            TitleTxtBx.Text = Globals.FileTitle;
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Globals.FileTitle = "";
            Globals.FilePath = "";
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (Stream stream = File.OpenRead(Globals.FilePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                //string extn = new FileInfo(Globals.FilePath).Extension;
                string title = TitleTxtBx.Text;
                var createdAt = DateTime.Now;
                string query = "INSERT INTO Documents(Title,CreatedAt,Content)VALUES(@title,@createdAt, @data)";

                using(SqlConnection cn = Globals.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.Add("@title", SqlDbType.NVarChar).Value = title;
                    cmd.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = createdAt;
                    cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }

                Close();
            }
        }

        
    }
}
