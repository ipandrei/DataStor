using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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

            label1.Text = Globals.UserFullName;

            TopLevel = true;
            CenterToScreen();
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addContent_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Add Content";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Globals.FileTitle = ofd.SafeFileName;
                Globals.FilePath = ofd.FileName;
                AddContent addContent = new AddContent();
                addContent.Show();
            }    
            
        }

        private void LoadData()
        {
            using (SqlConnection cn = Globals.GetConnection())
            {
                SqlDataAdapter adp = new SqlDataAdapter(Globals.loadQuery, cn);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    resultsDgv.DataSource = dt;
                }
            }
        }

        private void resultsDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = resultsDgv.SelectedRows;
            foreach(var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                LoadData(id);
            }

            void LoadData(int id)
            {
                using (SqlConnection cn = Globals.GetConnection())
                {
                    string query = "SELECT Content,Title FROM Documents WHERE ID=@id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        var title = reader["Title"].ToString();
                        var content = (byte[])reader["Content"];
                        Globals.Document = title;

                        var docTitle = DateTime.Now.ToString("ddMMyyyyhhmmss") + " " + title ;
                        File.WriteAllBytes(docTitle, content);

                        Process.Start(docTitle);

                    }
                }

            }

        }

        private void resultsDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchKey = search.Text;

            using (SqlConnection cn = Globals.GetConnection())
            {
                
                SqlCommand cmd = new SqlCommand(Globals.searchQuery, cn);
                cmd.Parameters.AddWithValue("searchKey", searchKey.Trim());
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        resultsDgv.DataSource = dt;
                    }
                }

                    
            }
                
        }
    }
}
