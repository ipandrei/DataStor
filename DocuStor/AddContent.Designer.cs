
namespace DocuStor
{
    partial class AddContent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleTxtBx = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataStorCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataStorCategories = new DocuStor.DataStorCategories();
            this.documentCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentCategoriesTableAdapter = new DocuStor.DataStorCategoriesTableAdapters.DocumentCategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataStorCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStorCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentCategoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TitleTxtBx
            // 
            this.TitleTxtBx.Location = new System.Drawing.Point(116, 175);
            this.TitleTxtBx.Name = "TitleTxtBx";
            this.TitleTxtBx.Size = new System.Drawing.Size(288, 22);
            this.TitleTxtBx.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(217, 449);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(88, 38);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(311, 449);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(93, 38);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Cancel";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Location = new System.Drawing.Point(16, 230);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(65, 17);
            this.categoryLbl.TabIndex = 4;
            this.categoryLbl.Text = "Category";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(16, 279);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(79, 17);
            this.DescriptionLbl.TabIndex = 5;
            this.DescriptionLbl.Text = "Description";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(116, 279);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(288, 164);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.documentCategoriesBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 227);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "Id";
            // 
            // dataStorCategoriesBindingSource
            // 
            this.dataStorCategoriesBindingSource.DataSource = this.dataStorCategories;
            this.dataStorCategoriesBindingSource.Position = 0;
            this.dataStorCategoriesBindingSource.CurrentChanged += new System.EventHandler(this.dataStorCategoriesBindingSource_CurrentChanged);
            // 
            // dataStorCategories
            // 
            this.dataStorCategories.DataSetName = "DataStorCategories";
            this.dataStorCategories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentCategoriesBindingSource
            // 
            this.documentCategoriesBindingSource.DataMember = "DocumentCategories";
            this.documentCategoriesBindingSource.DataSource = this.dataStorCategoriesBindingSource;
            // 
            // documentCategoriesTableAdapter
            // 
            this.documentCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // AddContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 495);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.TitleTxtBx);
            this.Controls.Add(this.label1);
            this.Name = "AddContent";
            this.Text = "Add Content";
            this.Load += new System.EventHandler(this.AddContent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStorCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStorCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentCategoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleTxtBx;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource dataStorCategoriesBindingSource;
        private DataStorCategories dataStorCategories;
        private System.Windows.Forms.BindingSource documentCategoriesBindingSource;
        private DataStorCategoriesTableAdapters.DocumentCategoriesTableAdapter documentCategoriesTableAdapter;
    }
}