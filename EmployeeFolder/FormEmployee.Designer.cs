namespace Project_Winform
{
    partial class FormEmployee
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
            this.Menu = new System.Windows.Forms.Panel();
            this.ButtonCheckOut = new System.Windows.Forms.Button();
            this.ButtonBill = new System.Windows.Forms.Button();
            this.ButtonShowStorage = new System.Windows.Forms.Button();
            this.ButtonShowProduct = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Panel();
            this.ButtonEmployeeAccount = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.ButtonCheckOut);
            this.Menu.Controls.Add(this.ButtonEmployeeAccount);
            this.Menu.Controls.Add(this.ButtonBill);
            this.Menu.Controls.Add(this.ButtonShowStorage);
            this.Menu.Controls.Add(this.ButtonShowProduct);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(962, 100);
            this.Menu.TabIndex = 0;
            // 
            // ButtonCheckOut
            // 
            this.ButtonCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ButtonCheckOut.Location = new System.Drawing.Point(773, 4);
            this.ButtonCheckOut.Name = "ButtonCheckOut";
            this.ButtonCheckOut.Size = new System.Drawing.Size(172, 91);
            this.ButtonCheckOut.TabIndex = 3;
            this.ButtonCheckOut.Text = "Check Out";
            this.ButtonCheckOut.UseVisualStyleBackColor = true;
            // 
            // ButtonBill
            // 
            this.ButtonBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ButtonBill.Location = new System.Drawing.Point(395, 5);
            this.ButtonBill.Name = "ButtonBill";
            this.ButtonBill.Size = new System.Drawing.Size(172, 91);
            this.ButtonBill.TabIndex = 2;
            this.ButtonBill.Text = "Bill";
            this.ButtonBill.UseVisualStyleBackColor = true;
            // 
            // ButtonShowStorage
            // 
            this.ButtonShowStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ButtonShowStorage.Location = new System.Drawing.Point(206, 4);
            this.ButtonShowStorage.Name = "ButtonShowStorage";
            this.ButtonShowStorage.Size = new System.Drawing.Size(172, 91);
            this.ButtonShowStorage.TabIndex = 1;
            this.ButtonShowStorage.Text = "Storage";
            this.ButtonShowStorage.UseVisualStyleBackColor = true;
            // 
            // ButtonShowProduct
            // 
            this.ButtonShowProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ButtonShowProduct.Location = new System.Drawing.Point(17, 4);
            this.ButtonShowProduct.Name = "ButtonShowProduct";
            this.ButtonShowProduct.Size = new System.Drawing.Size(172, 91);
            this.ButtonShowProduct.TabIndex = 0;
            this.ButtonShowProduct.Text = "Products";
            this.ButtonShowProduct.UseVisualStyleBackColor = true;
            // 
            // Show
            // 
            this.Show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Show.Location = new System.Drawing.Point(0, 100);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(962, 535);
            this.Show.TabIndex = 1;
            // 
            // ButtonEmployeeAccount
            // 
            this.ButtonEmployeeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ButtonEmployeeAccount.Location = new System.Drawing.Point(584, 5);
            this.ButtonEmployeeAccount.Name = "ButtonEmployeeAccount";
            this.ButtonEmployeeAccount.Size = new System.Drawing.Size(172, 91);
            this.ButtonEmployeeAccount.TabIndex = 4;
            this.ButtonEmployeeAccount.Text = "Account";
            this.ButtonEmployeeAccount.UseVisualStyleBackColor = true;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 635);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Menu);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button ButtonShowProduct;
        private System.Windows.Forms.Panel Show;
        private System.Windows.Forms.Button ButtonBill;
        private System.Windows.Forms.Button ButtonShowStorage;
        private System.Windows.Forms.Button ButtonCheckOut;
        private System.Windows.Forms.Button ButtonEmployeeAccount;
    }
}