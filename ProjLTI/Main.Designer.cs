
namespace ProjLTI
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.listBoxProjects = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(81, 219);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(132, 22);
            this.textBoxPassword.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(81, 276);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(81, 143);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(132, 22);
            this.textBoxUsername.TabIndex = 5;
            // 
            // listBoxProjects
            // 
            this.listBoxProjects.FormattingEnabled = true;
            this.listBoxProjects.ItemHeight = 16;
            this.listBoxProjects.Location = new System.Drawing.Point(415, 133);
            this.listBoxProjects.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxProjects.Name = "listBoxProjects";
            this.listBoxProjects.Size = new System.Drawing.Size(584, 180);
            this.listBoxProjects.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Projetos:";
            // 
            // btnOpenProject
            // 
            this.btnOpenProject.Location = new System.Drawing.Point(885, 333);
            this.btnOpenProject.Name = "btnOpenProject";
            this.btnOpenProject.Size = new System.Drawing.Size(114, 23);
            this.btnOpenProject.TabIndex = 12;
            this.btnOpenProject.Text = "Abrir Projeto";
            this.btnOpenProject.UseVisualStyleBackColor = true;
            this.btnOpenProject.Click += new System.EventHandler(this.btnOpenProject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnOpenProject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxProjects);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBoxUsername);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.ListBox listBoxProjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenProject;
    }
}

