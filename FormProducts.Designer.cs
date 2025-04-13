namespace Project_Winform
{
    partial class FormProducts
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
            this.Filter = new System.Windows.Forms.Panel();
            this.Sort = new System.Windows.Forms.Panel();
            this.Show = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterCategories = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SortAZ = new System.Windows.Forms.RadioButton();
            this.SortZA = new System.Windows.Forms.RadioButton();
            this.SortLowtoHigh = new System.Windows.Forms.RadioButton();
            this.SortHightoLow = new System.Windows.Forms.RadioButton();
            this.Search.SuspendLayout();
            this.Filter.SuspendLayout();
            this.Sort.SuspendLayout();
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
            this.Search.TabIndex = 0;
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.FilterCategories);
            this.Filter.Controls.Add(this.label2);
            this.Filter.Dock = System.Windows.Forms.DockStyle.Left;
            this.Filter.Location = new System.Drawing.Point(0, 57);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(144, 439);
            this.Filter.TabIndex = 1;
            // 
            // Sort
            // 
            this.Sort.Controls.Add(this.SortHightoLow);
            this.Sort.Controls.Add(this.SortLowtoHigh);
            this.Sort.Controls.Add(this.SortZA);
            this.Sort.Controls.Add(this.SortAZ);
            this.Sort.Controls.Add(this.label3);
            this.Sort.Dock = System.Windows.Forms.DockStyle.Right;
            this.Sort.Location = new System.Drawing.Point(743, 57);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(203, 439);
            this.Sort.TabIndex = 2;
            // 
            // Show
            // 
            this.Show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Show.Location = new System.Drawing.Point(144, 57);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(599, 439);
            this.Show.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 39);
            this.textBox1.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sort";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SortAZ
            // 
            this.SortAZ.AutoSize = true;
            this.SortAZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.SortAZ.Location = new System.Drawing.Point(10, 30);
            this.SortAZ.Name = "SortAZ";
            this.SortAZ.Size = new System.Drawing.Size(59, 28);
            this.SortAZ.TabIndex = 3;
            this.SortAZ.TabStop = true;
            this.SortAZ.Text = "A-Z";
            this.SortAZ.UseVisualStyleBackColor = true;
            // 
            // SortZA
            // 
            this.SortZA.AutoSize = true;
            this.SortZA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.SortZA.Location = new System.Drawing.Point(10, 64);
            this.SortZA.Name = "SortZA";
            this.SortZA.Size = new System.Drawing.Size(59, 28);
            this.SortZA.TabIndex = 4;
            this.SortZA.TabStop = true;
            this.SortZA.Text = "Z-A";
            this.SortZA.UseVisualStyleBackColor = true;
            // 
            // SortLowtoHigh
            // 
            this.SortLowtoHigh.AutoSize = true;
            this.SortLowtoHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.SortLowtoHigh.Location = new System.Drawing.Point(10, 98);
            this.SortLowtoHigh.Name = "SortLowtoHigh";
            this.SortLowtoHigh.Size = new System.Drawing.Size(190, 28);
            this.SortLowtoHigh.TabIndex = 5;
            this.SortLowtoHigh.TabStop = true;
            this.SortLowtoHigh.Text = "Cheap->Expensive";
            this.SortLowtoHigh.UseVisualStyleBackColor = true;
            // 
            // SortHightoLow
            // 
            this.SortHightoLow.AutoSize = true;
            this.SortHightoLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.SortHightoLow.Location = new System.Drawing.Point(10, 132);
            this.SortHightoLow.Name = "SortHightoLow";
            this.SortHightoLow.Size = new System.Drawing.Size(190, 28);
            this.SortHightoLow.TabIndex = 6;
            this.SortHightoLow.TabStop = true;
            this.SortHightoLow.Text = "Expensive->Cheap";
            this.SortHightoLow.UseVisualStyleBackColor = true;
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 496);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.Search);
            this.Name = "FormProducts";
            this.Text = "Products";
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.Sort.ResumeLayout(false);
            this.Sort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Search;
        private System.Windows.Forms.Panel Filter;
        private System.Windows.Forms.Panel Sort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox FilterCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Show;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton SortAZ;
        private System.Windows.Forms.RadioButton SortHightoLow;
        private System.Windows.Forms.RadioButton SortLowtoHigh;
        private System.Windows.Forms.RadioButton SortZA;
    }
}