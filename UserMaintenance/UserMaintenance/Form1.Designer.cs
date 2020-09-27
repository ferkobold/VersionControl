namespace UserMaintenance
{
    partial class Form1
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
            this.listUsers = new System.Windows.Forms.ListBox();
            this.textBFullName = new System.Windows.Forms.TextBox();
            this.labFullName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.Location = new System.Drawing.Point(12, 12);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(255, 251);
            this.listUsers.TabIndex = 0;
            // 
            // textBFullName
            // 
            this.textBFullName.Location = new System.Drawing.Point(356, 9);
            this.textBFullName.Name = "textBFullName";
            this.textBFullName.Size = new System.Drawing.Size(100, 20);
            this.textBFullName.TabIndex = 1;
            // 
            // labFullName
            // 
            this.labFullName.AutoSize = true;
            this.labFullName.Location = new System.Drawing.Point(274, 12);
            this.labFullName.Name = "labFullName";
            this.labFullName.Size = new System.Drawing.Size(35, 13);
            this.labFullName.TabIndex = 3;
            this.labFullName.Text = "label1";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(277, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 278);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labFullName);
            this.Controls.Add(this.textBFullName);
            this.Controls.Add(this.listUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.TextBox textBFullName;
        private System.Windows.Forms.Label labFullName;
        private System.Windows.Forms.Button btnAdd;
    }
}

