namespace Project_Winform
{
    partial class FormCheckOut
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
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.TextWorkTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ButtonCancel.Location = new System.Drawing.Point(91, 170);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(117, 64);
            this.ButtonCancel.TabIndex = 0;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ButtonAccept.Location = new System.Drawing.Point(267, 170);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(117, 64);
            this.ButtonAccept.TabIndex = 1;
            this.ButtonAccept.Text = "Accept";
            this.ButtonAccept.UseVisualStyleBackColor = true;
            // 
            // TextWorkTime
            // 
            this.TextWorkTime.AutoSize = true;
            this.TextWorkTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TextWorkTime.Location = new System.Drawing.Point(45, 53);
            this.TextWorkTime.Name = "TextWorkTime";
            this.TextWorkTime.Size = new System.Drawing.Size(163, 24);
            this.TextWorkTime.TabIndex = 2;
            this.TextWorkTime.Text = "Today work time : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(87, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Confirm your working time of today?";
            // 
            // FormCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 247);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextWorkTime);
            this.Controls.Add(this.ButtonAccept);
            this.Controls.Add(this.ButtonCancel);
            this.Name = "FormCheckOut";
            this.Text = "CheckOut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.Label TextWorkTime;
        private System.Windows.Forms.Label label1;
    }
}