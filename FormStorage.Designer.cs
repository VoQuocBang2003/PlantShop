namespace Project_Winform
{
    partial class FormStorage
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
            this.Search = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Filter = new System.Windows.Forms.Panel();
            this.FilterCategories = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StorageView = new System.Windows.Forms.DataGridView();
            this.Search.SuspendLayout();
            this.Filter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StorageView)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Controls.Add(this.label1);
            this.Search.Controls.Add(this.ButtonSearch);
            this.Search.Controls.Add(this.textBox1);
            this.Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.Search.Location = new System.Drawing.Point(0, 0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(946, 57);
            this.Search.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Storage";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ButtonSearch.Location = new System.Drawing.Point(537, 12);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(92, 39);
            this.ButtonSearch.TabIndex = 0;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 39);
            this.textBox1.TabIndex = 0;
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.FilterCategories);
            this.Filter.Controls.Add(this.label2);
            this.Filter.Dock = System.Windows.Forms.DockStyle.Left;
            this.Filter.Location = new System.Drawing.Point(0, 57);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(144, 439);
            this.Filter.TabIndex = 2;
            // 
            // FilterCategories
            // 
            this.FilterCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FilterCategories.FormattingEnabled = true;
            this.FilterCategories.Items.AddRange(new object[] {
            "Plants",
            "Pot",
            "Seeds"});
            this.FilterCategories.Location = new System.Drawing.Point(16, 39);
            this.FilterCategories.Name = "FilterCategories";
            this.FilterCategories.Size = new System.Drawing.Size(120, 76);
            this.FilterCategories.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filter";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StorageView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(144, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 439);
            this.panel1.TabIndex = 3;
            // 
            // StorageView
            // 
            this.StorageView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StorageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StorageView.Location = new System.Drawing.Point(0, 0);
            this.StorageView.Name = "StorageView";
            this.StorageView.Size = new System.Drawing.Size(802, 439);
            this.StorageView.TabIndex = 0;
            // 
            // FormStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.Search);
            this.Name = "FormStorage";
            this.Text = "Storage";
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StorageView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel Filter;
        private System.Windows.Forms.CheckedListBox FilterCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView StorageView;
    }
}