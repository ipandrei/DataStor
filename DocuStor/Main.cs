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
            refreshMetadata();
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
                Globals.FileTitleWithoutExtension = Path.GetFileNameWithoutExtension(Globals.FilePath);
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
                    string query = "SELECT Content,Title, Extension FROM Documents WHERE ID=@id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        var title = reader["Title"].ToString();
                        var extn = reader["Extension"].ToString();
                        var content = (byte[])reader["Content"];
                        Globals.Document = title;

                        var docTitle = DateTime.Now.ToString("ddMMyyyyhhmmss") + " " + title + extn ;
                        File.WriteAllBytes(docTitle, content);

                        Process.Start(docTitle);

                    }
                }

            }

        }

        private void refreshMetadata()
        {
            var selectedRow = resultsDgv.SelectedRows;
            foreach (var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                LoadData(id);
            }

            void LoadData(int id)
            {
                using (SqlConnection cn = Globals.GetConnection())
                {
                    string query = "SELECT d.Id, d.Title, d.Extension, c.Id as idOfCategory, d.CreatedAt, u.Name as CreatedBy, d.Description, d.ModifiedAt, um.Name as ModifiedBy FROM Documents d LEFT JOIN Users u ON d.CreatedById = u.Id LEFT JOIN DocumentCategories c ON d.CategoryId = c.Id LEFT JOIN Users um ON d.ModifiedById = um.Id WHERE d.ID=@id ";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        titleTxtBx.Text = reader["Title"].ToString();
                        categogoryCbx.SelectedValue = reader["idOfCategory"].ToString();
                        createdAtTxtBx.Text = reader["CreatedAt"].ToString();
                        createdByTxtBx.Text = reader["CreatedBy"].ToString();
                        modifiedAtTxtBx.Text = reader["ModifiedAt"].ToString();
                        modifiedByTxtBx.Text = reader["ModifiedBy"].ToString();
                        descriptionTxtBx.Text = reader["Description"].ToString();
                        extensionTxtBx.Text = reader["Extension"].ToString();
                        bigTitleTxtBx.Text = titleTxtBx.Text;
                    }
                }

            }
        }

        private void resultsDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            refreshMetadata();
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

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataStorCategories.DocumentCategories' table. You can move, or remove it, as needed.
            this.documentCategoriesTableAdapter.Fill(this.dataStorCategories.DocumentCategories);

        }

        private void cancelMetadataBtn_Click(object sender, EventArgs e)
        {

        }

        private void resultsDgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveMetdataBtn_Click(object sender, EventArgs e)
        {

            var selectedRow = resultsDgv.SelectedRows;
            foreach (var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                updateData(id);
            }

            void updateData(int id)
            {
                string title = titleTxtBx.Text;
                var categoryId = categogoryCbx.SelectedValue;
                var description = descriptionTxtBx.Text;
                string query = "UPDATE Documents SET Title = @title, CategoryId = @categoryId, Description = @description, ModifiedAt = @modifiedAt, ModifiedById = @modifiedById  WHERE ID = @id";

                using (SqlConnection cn = Globals.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@title", SqlDbType.NVarChar).Value = title;
                    cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = categoryId;
                    cmd.Parameters.Add("@description", SqlDbType.Text).Value = description;
                    cmd.Parameters.Add("@modifiedAt", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@modifiedById", SqlDbType.Int).Value = Globals.UserId;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }

                refreshMetadata();

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Update Content";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var filePath = ofd.FileName;

                var selectedRow = resultsDgv.SelectedRows;
                foreach (var row in selectedRow)
                {
                    int id = (int)((DataGridViewRow)row).Cells[0].Value;
                    updateContent(id);
                }

                void updateContent(int id)
                {
                    using (Stream stream = File.OpenRead(filePath))
                    {
                        byte[] buffer = new byte[stream.Length];
                        stream.Read(buffer, 0, buffer.Length);

                        string query = "UPDATE Documents SET Content = @content,  ModifiedAt = @modifiedAt, ModifiedById = @modifiedById, Extension = @extension  WHERE ID = @id";

                        var extn = new FileInfo(filePath).Extension;

                        using (SqlConnection cn = Globals.GetConnection())
                        {
                            SqlCommand cmd = new SqlCommand(query, cn);
                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                            cmd.Parameters.Add("@content", SqlDbType.VarBinary).Value = buffer;
                            cmd.Parameters.Add("@modifiedAt", SqlDbType.DateTime).Value = DateTime.Now;
                            cmd.Parameters.Add("@modifiedById", SqlDbType.Int).Value = Globals.UserId;
                            cmd.Parameters.Add("@extension", SqlDbType.Char).Value = extn;
                            cn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    refreshMetadata();

                }
            }
        }

        private void titleTxtBx_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
