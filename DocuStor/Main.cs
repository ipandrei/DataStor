using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            label1.Text = Globals.UserFullName;

            TopLevel = true;
            CenterToScreen();
            //WindowState = FormWindowState.Maximized;
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
                string query = "SELECT ID, Title, CreatedAt FROM Documents";
                SqlDataAdapter adp = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    resultsDgv.DataSource = dt;
                }
            }
        }

        private void resultsDgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = resultsDgv.SelectedRows;
            foreach(var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
            }

        }
    }
}
