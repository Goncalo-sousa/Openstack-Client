
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
            this.labelPass = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenProject = new System.Windows.Forms.Button();
            this.listBoxVMs = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.btnShowVMs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(21, 108);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 9;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(18, 92);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(56, 13);
            this.labelPass.TabIndex = 8;
            this.labelPass.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(18, 30);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.Text = "Username:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(21, 154);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(21, 46);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Projetos:";
            // 
            // btnOpenProject
            // 
            this.btnOpenProject.Location = new System.Drawing.Point(37, 207);
            this.btnOpenProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenProject.Name = "btnOpenProject";
            this.btnOpenProject.Size = new System.Drawing.Size(84, 22);
            this.btnOpenProject.TabIndex = 12;
            this.btnOpenProject.Text = "Volumes";
            this.btnOpenProject.UseVisualStyleBackColor = true;
            this.btnOpenProject.Click += new System.EventHandler(this.btnOpenProject_Click);
            // 
            // listBoxVMs
            // 
            this.listBoxVMs.FormattingEnabled = true;
            this.listBoxVMs.Location = new System.Drawing.Point(201, 90);
            this.listBoxVMs.Name = "listBoxVMs";
            this.listBoxVMs.Size = new System.Drawing.Size(439, 199);
            this.listBoxVMs.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "VMs";
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(201, 43);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProject.TabIndex = 15;
            // 
            // btnShowVMs
            // 
            this.btnShowVMs.Location = new System.Drawing.Point(328, 42);
            this.btnShowVMs.Name = "btnShowVMs";
            this.btnShowVMs.Size = new System.Drawing.Size(75, 23);
            this.btnShowVMs.TabIndex = 16;
            this.btnShowVMs.Text = "Refresh";
            this.btnShowVMs.UseVisualStyleBackColor = true;
            this.btnShowVMs.Click += new System.EventHandler(this.btnShowVMs_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Create VM";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Edit VM";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(563, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Delete VM";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(37, 235);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(84, 24);
            this.btnUploadImage.TabIndex = 20;
            this.btnUploadImage.Text = "Upload image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(635, 21);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(32, 13);
            this.labelUser.TabIndex = 21;
            this.labelUser.Text = "User:";
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Location = new System.Drawing.Point(673, 21);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(0, 10);
            this.labelUserLogin.TabIndex = 22;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 358);
            this.Controls.Add(this.labelUserLogin);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowVMs);
            this.Controls.Add(this.comboBoxProject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxVMs);
            this.Controls.Add(this.btnOpenProject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenProject;
        private System.Windows.Forms.ListBox listBoxVMs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.Button btnShowVMs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelUserLogin;
    }
}

