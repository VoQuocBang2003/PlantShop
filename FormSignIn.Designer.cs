namespace Project_Winform
{
    partial class FormSignIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonForgotPass = new System.Windows.Forms.Button();
            this.ButtonChangePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(50, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(50, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ButtonCancel.Location = new System.Drawing.Point(50, 199);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(99, 43);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ButtonOK.Location = new System.Drawing.Point(191, 199);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(99, 43);
            this.ButtonOK.TabIndex = 5;
            this.ButtonOK.Text = "Ok";
            this.ButtonOK.UseVisualStyleBackColor = true;
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ButtonRegister.Location = new System.Drawing.Point(332, 199);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(99, 43);
            this.ButtonRegister.TabIndex = 6;
            this.ButtonRegister.Text = "Register";
            this.ButtonRegister.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(77, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Incorrect Username or Password! Please try again!";
            this.label3.Visible = false;
            // 
            // ButtonForgotPass
            // 
            this.ButtonForgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ButtonForgotPass.Location = new System.Drawing.Point(256, 259);
            this.ButtonForgotPass.Name = "ButtonForgotPass";
            this.ButtonForgotPass.Size = new System.Drawing.Size(175, 43);
            this.ButtonForgotPass.TabIndex = 8;
            this.ButtonForgotPass.Text = "Forgot Password";
            this.ButtonForgotPass.UseVisualStyleBackColor = true;
            this.ButtonForgotPass.Click += new System.EventHandler(this.ButtonForgotPass_Click);
            // 
            // ButtonChangePass
            // 
            this.ButtonChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ButtonChangePass.Location = new System.Drawing.Point(50, 259);
            this.ButtonChangePass.Name = "ButtonChangePass";
            this.ButtonChangePass.Size = new System.Drawing.Size(175, 43);
            this.ButtonChangePass.TabIndex = 9;
            this.ButtonChangePass.Text = "Change Password";
            this.ButtonChangePass.UseVisualStyleBackColor = true;
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 314);
            this.Controls.Add(this.ButtonChangePass);
            this.Controls.Add(this.ButtonForgotPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonRegister);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSignIn";
            this.Text = "Form_SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonForgotPass;
        private System.Windows.Forms.Button ButtonChangePass;
    }
}

