namespace Hospital
{
    partial class AdminForm
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelNewEmployee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNewEmployee = new System.Windows.Forms.Button();
            this.buttonManageEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(352, 472);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 18;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(440, 432);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(352, 432);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(258, 432);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 15;
            this.buttonLogin.Text = "Login In";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // labelNewEmployee
            // 
            this.labelNewEmployee.AutoSize = true;
            this.labelNewEmployee.Location = new System.Drawing.Point(21, 49);
            this.labelNewEmployee.Name = "labelNewEmployee";
            this.labelNewEmployee.Size = new System.Drawing.Size(78, 13);
            this.labelNewEmployee.TabIndex = 19;
            this.labelNewEmployee.Text = "New Employee";
            this.labelNewEmployee.Click += new System.EventHandler(this.labelNewEmployee_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Manage Employee";
            // 
            // buttonNewEmployee
            // 
            this.buttonNewEmployee.Location = new System.Drawing.Point(2, 3);
            this.buttonNewEmployee.Name = "buttonNewEmployee";
            this.buttonNewEmployee.Size = new System.Drawing.Size(97, 23);
            this.buttonNewEmployee.TabIndex = 21;
            this.buttonNewEmployee.Text = "New Employee";
            this.buttonNewEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonManageEmployee
            // 
            this.buttonManageEmployee.Location = new System.Drawing.Point(105, 3);
            this.buttonManageEmployee.Name = "buttonManageEmployee";
            this.buttonManageEmployee.Size = new System.Drawing.Size(98, 23);
            this.buttonManageEmployee.TabIndex = 22;
            this.buttonManageEmployee.Text = "New Employee";
            this.buttonManageEmployee.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 504);
            this.Controls.Add(this.buttonManageEmployee);
            this.Controls.Add(this.buttonNewEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNewEmployee);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLogin);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelNewEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNewEmployee;
        private System.Windows.Forms.Button buttonManageEmployee;
    }
}