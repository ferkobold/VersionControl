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
            this.textBLastName = new System.Windows.Forms.TextBox();
            this.textBFirstName = new System.Windows.Forms.TextBox();
            this.labLastName = new System.Windows.Forms.Label();
            this.labFirstName = new System.Windows.Forms.Label();
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
            // textBLastName
            // 
            this.textBLastName.Location = new System.Drawing.Point(356, 9);
            this.textBLastName.Name = "textBLastName";
            this.textBLastName.Size = new System.Drawing.Size(100, 20);
            this.textBLastName.TabIndex = 1;
            // 
            // textBFirstName
            // 
            this.textBFirstName.Location = new System.Drawing.Point(356, 35);
            this.textBFirstName.Name = "textBFirstName";
            this.textBFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBFirstName.TabIndex = 2;
            // 
            // labLastName
            // 
            this.labLastName.AutoSize = true;
            this.labLastName.Location = new System.Drawing.Point(274, 12);
            this.labLastName.Name = "labLastName";
            this.labLastName.Size = new System.Drawing.Size(35, 13);
            this.labLastName.TabIndex = 3;
            this.labLastName.Text = "label1";
            // 
            // labFirstName
            // 
            this.labFirstName.AutoSize = true;
            this.labFirstName.Location = new System.Drawing.Point(274, 38);
            this.labFirstName.Name = "labFirstName";
            this.labFirstName.Size = new System.Drawing.Size(35, 13);
            this.labFirstName.TabIndex = 4;
            this.labFirstName.Text = "label2";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(277, 61);
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
            this.Controls.Add(this.labFirstName);
            this.Controls.Add(this.labLastName);
            this.Controls.Add(this.textBFirstName);
            this.Controls.Add(this.textBLastName);
            this.Controls.Add(this.listUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.TextBox textBLastName;
        private System.Windows.Forms.TextBox textBFirstName;
        private System.Windows.Forms.Label labLastName;
        private System.Windows.Forms.Label labFirstName;
        private System.Windows.Forms.Button btnAdd;
    }
}

