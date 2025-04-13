namespace Project_Winform
{
    partial class FormAdmin
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
            this.Show = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Panel();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonBillHistory = new System.Windows.Forms.Button();
            this.ButtonBill = new System.Windows.Forms.Button();
            this.ButtonShowStorage = new System.Windows.Forms.Button();
            this.ButtonShowProduct = new System.Windows.Forms.Button();
            this.ButtonEmployeeManagement = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Show
            // 
            this.Show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Show.Location = new System.Drawing.Point(0, 100);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(962, 535);
            this.Show.TabIndex = 3;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.ButtonEmployeeManagement);
            this.Menu.Controls.Add(this.ButtonExit);
            this.Menu.Controls.Add(this.ButtonBillHistory);
            this.Menu.Controls.Add(this.ButtonBill);
            this.Menu.Controls.Add(this.ButtonShowStorage);
            this.Menu.Controls.Add(this.ButtonShowProduct);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(962, 100);
            this.Menu.TabIndex = 2;
            this.Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ButtonExit.Location = new System.Drawing.Point(807, 4);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(139, 91);
            this.ButtonExit.TabIndex = 3;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            // 
            // ButtonBillHistory
            // 
            this.ButtonBillHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ButtonBillHistory.Location = new System.Drawing.Point(649, 3);
            this.ButtonBillHistory.Name = "ButtonBillHistory";
            this.ButtonBillHistory.Size = new System.Drawing.Size(139, 91);
            this.ButtonBillHistory.TabIndex = 4;
            this.ButtonBillHistory.Text = "History";
            this.ButtonBillHistory.UseVisualStyleBackColor = true;
            // 
            // ButtonBill
            // 
            this.ButtonBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ButtonBill.Location = new System.Drawing.Point(491, 3);
            this.ButtonBill.Name = "ButtonBill";
            this.ButtonBill.Size = new System.Drawing.Size(139, 91);
            this.ButtonBill.TabIndex = 2;
            this.ButtonBill.Text = "Bill";
            this.ButtonBill.UseVisualStyleBackColor = true;
            // 
            // ButtonShowStorage
            // 
            this.ButtonShowStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ButtonShowStorage.Location = new System.Drawing.Point(333, 3);
            this.ButtonShowStorage.Name = "ButtonShowStorage";
            this.ButtonShowStorage.Size = new System.Drawing.Size(139, 91);
            this.ButtonShowStorage.TabIndex = 1;
            this.ButtonShowStorage.Text = "Storage";
            this.ButtonShowStorage.UseVisualStyleBackColor = true;
            // 
            // ButtonShowProduct
            // 
            this.ButtonShowProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ButtonShowProduct.Location = new System.Drawing.Point(175, 4);
            this.ButtonShowProduct.Name = "ButtonShowProduct";
            this.ButtonShowProduct.Size = new System.Drawing.Size(139, 91);
            this.ButtonShowProduct.TabIndex = 0;
            this.ButtonShowProduct.Text = "Products";
            this.ButtonShowProduct.UseVisualStyleBackColor = true;
            // 
            // ButtonEmployeeManagement
            // 
            this.ButtonEmployeeManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ButtonEmployeeManagement.Location = new System.Drawing.Point(17, 6);
            this.ButtonEmployeeManagement.Name = "ButtonEmployeeManagement";
            this.ButtonEmployeeManagement.Size = new System.Drawing.Size(139, 91);
            this.ButtonEmployeeManagement.TabIndex = 5;
            this.ButtonEmployeeManagement.Text = "Employee Management";
            this.ButtonEmployeeManagement.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 635);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Menu);
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Show;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonBillHistory;
        private System.Windows.Forms.Button ButtonBill;
        private System.Windows.Forms.Button ButtonShowStorage;
        private System.Windows.Forms.Button ButtonShowProduct;
        private System.Windows.Forms.Button ButtonEmployeeManagement;
    }
}