
namespace DocuStor
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultsDgv = new System.Windows.Forms.DataGridView();
            this.addContent = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.descriptionTxtBx = new System.Windows.Forms.RichTextBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.extensionTxtBx = new System.Windows.Forms.TextBox();
            this.modifiedByTxtBx = new System.Windows.Forms.TextBox();
            this.modifiedAtTxtBx = new System.Windows.Forms.TextBox();
            this.extensionLbl = new System.Windows.Forms.Label();
            this.modifiedByLbl = new System.Windows.Forms.Label();
            this.modifiedAtLbl = new System.Windows.Forms.Label();
            this.createdByTxtBx = new System.Windows.Forms.TextBox();
            this.createdAtTxtBx = new System.Windows.Forms.TextBox();
            this.categogoryCbx = new System.Windows.Forms.ComboBox();
            this.documentCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataStorCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataStorCategories = new DocuStor.DataStorCategories();
            this.titleTxtBx = new System.Windows.Forms.TextBox();
            this.createdByLbl = new System.Windows.Forms.Label();
            this.createdAtLbl = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.saveMetdataBtn = new System.Windows.Forms.Button();
            this.cancelMetadataBtn = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.documentCategoriesTableAdapter = new DocuStor.DataStorCategoriesTableAdapters.DocumentCategoriesTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bigTitleTxtBx = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDgv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStorCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStorCategories)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1795, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(3, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(1145, 41);
            this.search.TabIndex = 1;
            this.search.Text = "Search";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resultsDgv);
            this.panel1.Controls.Add(this.addContent);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.search);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 991);
            this.panel1.TabIndex = 5;
            // 
            // resultsDgv
            // 
            this.resultsDgv.AllowUserToAddRows = false;
            this.resultsDgv.AllowUserToDeleteRows = false;
            this.resultsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDgv.Location = new System.Drawing.Point(3, 50);
            this.resultsDgv.Name = "resultsDgv";
            this.resultsDgv.ReadOnly = true;
            this.resultsDgv.RowHeadersWidth = 55;
            this.resultsDgv.RowTemplate.Height = 24;
            this.resultsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultsDgv.Size = new System.Drawing.Size(1244, 941);
            this.resultsDgv.TabIndex = 7;
            this.resultsDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultsDgv_CellClick);
            this.resultsDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultsDgv_CellDoubleClick);
            this.resultsDgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.resultsDgv_DataBindingComplete);
            // 
            // addContent
            // 
            this.addContent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addContent.BackgroundImage = global::DocuStor.Properties.Resources._1587992;
            this.addContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addContent.Location = new System.Drawing.Point(1204, 3);
            this.addContent.Name = "addContent";
            this.addContent.Size = new System.Drawing.Size(43, 41);
            this.addContent.TabIndex = 6;
            this.addContent.UseVisualStyleBackColor = false;
            this.addContent.Click += new System.EventHandler(this.addContent_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.searchBtn.BackgroundImage = global::DocuStor.Properties.Resources.loupe;
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn.Location = new System.Drawing.Point(1154, 3);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(44, 41);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bigTitleTxtBx);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.descriptionTxtBx);
            this.panel2.Controls.Add(this.descriptionLbl);
            this.panel2.Controls.Add(this.extensionTxtBx);
            this.panel2.Controls.Add(this.modifiedByTxtBx);
            this.panel2.Controls.Add(this.modifiedAtTxtBx);
            this.panel2.Controls.Add(this.extensionLbl);
            this.panel2.Controls.Add(this.modifiedByLbl);
            this.panel2.Controls.Add(this.modifiedAtLbl);
            this.panel2.Controls.Add(this.createdByTxtBx);
            this.panel2.Controls.Add(this.createdAtTxtBx);
            this.panel2.Controls.Add(this.categogoryCbx);
            this.panel2.Controls.Add(this.titleTxtBx);
            this.panel2.Controls.Add(this.createdByLbl);
            this.panel2.Controls.Add(this.createdAtLbl);
            this.panel2.Controls.Add(this.categoryLbl);
            this.panel2.Controls.Add(this.titleLbl);
            this.panel2.Controls.Add(this.saveMetdataBtn);
            this.panel2.Controls.Add(this.cancelMetadataBtn);
            this.panel2.Location = new System.Drawing.Point(1286, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 882);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DocuStor.Properties.Resources.doc;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(25, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 188);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // descriptionTxtBx
            // 
            this.descriptionTxtBx.Location = new System.Drawing.Point(178, 568);
            this.descriptionTxtBx.Name = "descriptionTxtBx";
            this.descriptionTxtBx.Size = new System.Drawing.Size(400, 201);
            this.descriptionTxtBx.TabIndex = 16;
            this.descriptionTxtBx.Text = "";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.Location = new System.Drawing.Point(42, 568);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(99, 25);
            this.descriptionLbl.TabIndex = 15;
            this.descriptionLbl.Text = "Decription";
            // 
            // extensionTxtBx
            // 
            this.extensionTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extensionTxtBx.Location = new System.Drawing.Point(178, 318);
            this.extensionTxtBx.Name = "extensionTxtBx";
            this.extensionTxtBx.ReadOnly = true;
            this.extensionTxtBx.Size = new System.Drawing.Size(400, 30);
            this.extensionTxtBx.TabIndex = 14;
            // 
            // modifiedByTxtBx
            // 
            this.modifiedByTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifiedByTxtBx.Location = new System.Drawing.Point(178, 363);
            this.modifiedByTxtBx.Name = "modifiedByTxtBx";
            this.modifiedByTxtBx.ReadOnly = true;
            this.modifiedByTxtBx.Size = new System.Drawing.Size(400, 30);
            this.modifiedByTxtBx.TabIndex = 13;
            // 
            // modifiedAtTxtBx
            // 
            this.modifiedAtTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifiedAtTxtBx.Location = new System.Drawing.Point(178, 413);
            this.modifiedAtTxtBx.Name = "modifiedAtTxtBx";
            this.modifiedAtTxtBx.ReadOnly = true;
            this.modifiedAtTxtBx.Size = new System.Drawing.Size(400, 30);
            this.modifiedAtTxtBx.TabIndex = 12;
            // 
            // extensionLbl
            // 
            this.extensionLbl.AutoSize = true;
            this.extensionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extensionLbl.Location = new System.Drawing.Point(42, 318);
            this.extensionLbl.Name = "extensionLbl";
            this.extensionLbl.Size = new System.Drawing.Size(98, 25);
            this.extensionLbl.TabIndex = 11;
            this.extensionLbl.Text = "Extension";
            // 
            // modifiedByLbl
            // 
            this.modifiedByLbl.AutoSize = true;
            this.modifiedByLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifiedByLbl.Location = new System.Drawing.Point(42, 363);
            this.modifiedByLbl.Name = "modifiedByLbl";
            this.modifiedByLbl.Size = new System.Drawing.Size(112, 25);
            this.modifiedByLbl.TabIndex = 10;
            this.modifiedByLbl.Text = "Modified by";
            // 
            // modifiedAtLbl
            // 
            this.modifiedAtLbl.AutoSize = true;
            this.modifiedAtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifiedAtLbl.Location = new System.Drawing.Point(42, 413);
            this.modifiedAtLbl.Name = "modifiedAtLbl";
            this.modifiedAtLbl.Size = new System.Drawing.Size(107, 25);
            this.modifiedAtLbl.TabIndex = 9;
            this.modifiedAtLbl.Text = "Modified at";
            // 
            // createdByTxtBx
            // 
            this.createdByTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdByTxtBx.Location = new System.Drawing.Point(178, 463);
            this.createdByTxtBx.Name = "createdByTxtBx";
            this.createdByTxtBx.ReadOnly = true;
            this.createdByTxtBx.Size = new System.Drawing.Size(400, 30);
            this.createdByTxtBx.TabIndex = 8;
            // 
            // createdAtTxtBx
            // 
            this.createdAtTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdAtTxtBx.Location = new System.Drawing.Point(178, 512);
            this.createdAtTxtBx.Name = "createdAtTxtBx";
            this.createdAtTxtBx.ReadOnly = true;
            this.createdAtTxtBx.Size = new System.Drawing.Size(400, 30);
            this.createdAtTxtBx.TabIndex = 7;
            // 
            // categogoryCbx
            // 
            this.categogoryCbx.DataSource = this.documentCategoriesBindingSource;
            this.categogoryCbx.DisplayMember = "Name";
            this.categogoryCbx.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.categogoryCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categogoryCbx.FormattingEnabled = true;
            this.categogoryCbx.Location = new System.Drawing.Point(178, 269);
            this.categogoryCbx.Name = "categogoryCbx";
            this.categogoryCbx.Size = new System.Drawing.Size(400, 33);
            this.categogoryCbx.TabIndex = 6;
            this.categogoryCbx.ValueMember = "Id";
            // 
            // documentCategoriesBindingSource
            // 
            this.documentCategoriesBindingSource.DataMember = "DocumentCategories";
            this.documentCategoriesBindingSource.DataSource = this.dataStorCategoriesBindingSource;
            // 
            // dataStorCategoriesBindingSource
            // 
            this.dataStorCategoriesBindingSource.DataSource = this.dataStorCategories;
            this.dataStorCategoriesBindingSource.Position = 0;
            // 
            // dataStorCategories
            // 
            this.dataStorCategories.DataSetName = "DataStorCategories";
            this.dataStorCategories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titleTxtBx
            // 
            this.titleTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxtBx.Location = new System.Drawing.Point(178, 222);
            this.titleTxtBx.Name = "titleTxtBx";
            this.titleTxtBx.Size = new System.Drawing.Size(400, 30);
            this.titleTxtBx.TabIndex = 5;
            this.titleTxtBx.TextChanged += new System.EventHandler(this.titleTxtBx_TextChanged);
            // 
            // createdByLbl
            // 
            this.createdByLbl.AutoSize = true;
            this.createdByLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdByLbl.Location = new System.Drawing.Point(42, 512);
            this.createdByLbl.Name = "createdByLbl";
            this.createdByLbl.Size = new System.Drawing.Size(108, 25);
            this.createdByLbl.TabIndex = 4;
            this.createdByLbl.Text = "Created by";
            // 
            // createdAtLbl
            // 
            this.createdAtLbl.AutoSize = true;
            this.createdAtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdAtLbl.Location = new System.Drawing.Point(42, 463);
            this.createdAtLbl.Name = "createdAtLbl";
            this.createdAtLbl.Size = new System.Drawing.Size(103, 25);
            this.createdAtLbl.TabIndex = 3;
            this.createdAtLbl.Text = "Created at";
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.Location = new System.Drawing.Point(42, 269);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(92, 25);
            this.categoryLbl.TabIndex = 2;
            this.categoryLbl.Text = "Category";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(42, 222);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(49, 25);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Title";
            // 
            // saveMetdataBtn
            // 
            this.saveMetdataBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveMetdataBtn.Location = new System.Drawing.Point(308, 807);
            this.saveMetdataBtn.Name = "saveMetdataBtn";
            this.saveMetdataBtn.Size = new System.Drawing.Size(270, 60);
            this.saveMetdataBtn.TabIndex = 0;
            this.saveMetdataBtn.Text = "Save";
            this.saveMetdataBtn.UseVisualStyleBackColor = false;
            this.saveMetdataBtn.Click += new System.EventHandler(this.saveMetdataBtn_Click);
            // 
            // cancelMetadataBtn
            // 
            this.cancelMetadataBtn.Location = new System.Drawing.Point(32, 807);
            this.cancelMetadataBtn.Name = "cancelMetadataBtn";
            this.cancelMetadataBtn.Size = new System.Drawing.Size(270, 60);
            this.cancelMetadataBtn.TabIndex = 0;
            this.cancelMetadataBtn.Text = "Cancel";
            this.cancelMetadataBtn.UseVisualStyleBackColor = true;
            this.cancelMetadataBtn.Click += new System.EventHandler(this.cancelMetadataBtn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1902, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(60, 24);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 24);
            this.toolStripButton1.Text = "Update";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // documentCategoriesTableAdapter
            // 
            this.documentCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DocuStor.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1268, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 106);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bigTitleTxtBx
            // 
            this.bigTitleTxtBx.BackColor = System.Drawing.Color.White;
            this.bigTitleTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bigTitleTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigTitleTxtBx.Location = new System.Drawing.Point(208, 30);
            this.bigTitleTxtBx.Multiline = true;
            this.bigTitleTxtBx.Name = "bigTitleTxtBx";
            this.bigTitleTxtBx.ReadOnly = true;
            this.bigTitleTxtBx.Size = new System.Drawing.Size(370, 175);
            this.bigTitleTxtBx.TabIndex = 19;
            // 
            // Main
            // 
            this.AcceptButton = this.searchBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "DocuStor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStorCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStorCategories)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView resultsDgv;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button saveMetdataBtn;
        private System.Windows.Forms.Button cancelMetadataBtn;
        private System.Windows.Forms.TextBox titleTxtBx;
        private System.Windows.Forms.Label createdByLbl;
        private System.Windows.Forms.Label createdAtLbl;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.ComboBox categogoryCbx;
        private System.Windows.Forms.BindingSource dataStorCategoriesBindingSource;
        private DataStorCategories dataStorCategories;
        private System.Windows.Forms.BindingSource documentCategoriesBindingSource;
        private DataStorCategoriesTableAdapters.DocumentCategoriesTableAdapter documentCategoriesTableAdapter;
        private System.Windows.Forms.TextBox createdAtTxtBx;
        private System.Windows.Forms.TextBox createdByTxtBx;
        private System.Windows.Forms.TextBox extensionTxtBx;
        private System.Windows.Forms.TextBox modifiedByTxtBx;
        private System.Windows.Forms.TextBox modifiedAtTxtBx;
        private System.Windows.Forms.Label extensionLbl;
        private System.Windows.Forms.Label modifiedByLbl;
        private System.Windows.Forms.Label modifiedAtLbl;
        private System.Windows.Forms.RichTextBox descriptionTxtBx;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox bigTitleTxtBx;
    }
}