
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
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.textBoxIPServer = new System.Windows.Forms.TextBox();
            this.labelServer = new System.Windows.Forms.Label();
            this.labelServidor = new System.Windows.Forms.Label();
            this.label_IP = new System.Windows.Forms.Label();
            this.btnInstances = new System.Windows.Forms.Button();
            this.btnImages = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelstatsInstances = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelstatsVCPUs = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelstatsRAM = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelstatsVolumes = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelstatsVolumeSnaps = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelstatsVolumeStorage = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnRefreshStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(89, 175);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(132, 22);
            this.textBoxPassword.TabIndex = 9;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(85, 155);
            this.labelPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(73, 17);
            this.labelPass.TabIndex = 8;
            this.labelPass.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(85, 101);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(77, 17);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.Text = "Username:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(125, 266);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(89, 121);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(132, 22);
            this.textBoxUsername.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Projetos:";
            // 
            // btnOpenProject
            // 
            this.btnOpenProject.Location = new System.Drawing.Point(277, 396);
            this.btnOpenProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenProject.Name = "btnOpenProject";
            this.btnOpenProject.Size = new System.Drawing.Size(112, 27);
            this.btnOpenProject.TabIndex = 12;
            this.btnOpenProject.Text = "Volumes";
            this.btnOpenProject.UseVisualStyleBackColor = true;
            this.btnOpenProject.Click += new System.EventHandler(this.btnOpenProject_Click);
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(731, 22);
            this.comboBoxProject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(160, 24);
            this.comboBoxProject.TabIndex = 15;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(557, 25);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(42, 17);
            this.labelUser.TabIndex = 21;
            this.labelUser.Text = "User:";
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Location = new System.Drawing.Point(597, 26);
            this.labelUserLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(0, 17);
            this.labelUserLogin.TabIndex = 22;
            // 
            // textBoxIPServer
            // 
            this.textBoxIPServer.Location = new System.Drawing.Point(89, 231);
            this.textBoxIPServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIPServer.Name = "textBoxIPServer";
            this.textBoxIPServer.Size = new System.Drawing.Size(132, 22);
            this.textBoxIPServer.TabIndex = 25;
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(85, 212);
            this.labelServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(54, 17);
            this.labelServer.TabIndex = 24;
            this.labelServer.Text = "Server:";
            // 
            // labelServidor
            // 
            this.labelServidor.AutoSize = true;
            this.labelServidor.Location = new System.Drawing.Point(355, 25);
            this.labelServidor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServidor.Name = "labelServidor";
            this.labelServidor.Size = new System.Drawing.Size(54, 17);
            this.labelServidor.TabIndex = 26;
            this.labelServidor.Text = "Server:";
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Location = new System.Drawing.Point(407, 26);
            this.label_IP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(0, 17);
            this.label_IP.TabIndex = 27;
            // 
            // btnInstances
            // 
            this.btnInstances.Location = new System.Drawing.Point(480, 394);
            this.btnInstances.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInstances.Name = "btnInstances";
            this.btnInstances.Size = new System.Drawing.Size(100, 28);
            this.btnInstances.TabIndex = 28;
            this.btnInstances.Text = "Instances";
            this.btnInstances.UseVisualStyleBackColor = true;
            this.btnInstances.Click += new System.EventHandler(this.btnInstances_Click);
            // 
            // btnImages
            // 
            this.btnImages.Location = new System.Drawing.Point(672, 395);
            this.btnImages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImages.Name = "btnImages";
            this.btnImages.Size = new System.Drawing.Size(100, 28);
            this.btnImages.TabIndex = 29;
            this.btnImages.Text = "Images";
            this.btnImages.UseVisualStyleBackColor = true;
            this.btnImages.Click += new System.EventHandler(this.btnImages_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Instances";
            // 
            // labelstatsInstances
            // 
            this.labelstatsInstances.AutoSize = true;
            this.labelstatsInstances.Location = new System.Drawing.Point(435, 166);
            this.labelstatsInstances.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelstatsInstances.Name = "labelstatsInstances";
            this.labelstatsInstances.Size = new System.Drawing.Size(46, 17);
            this.labelstatsInstances.TabIndex = 31;
            this.labelstatsInstances.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "VCPUs";
            // 
            // labelstatsVCPUs
            // 
            this.labelstatsVCPUs.AutoSize = true;
            this.labelstatsVCPUs.Location = new System.Drawing.Point(551, 170);
            this.labelstatsVCPUs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelstatsVCPUs.Name = "labelstatsVCPUs";
            this.labelstatsVCPUs.Size = new System.Drawing.Size(46, 17);
            this.labelstatsVCPUs.TabIndex = 33;
            this.labelstatsVCPUs.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(664, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "RAM";
            // 
            // labelstatsRAM
            // 
            this.labelstatsRAM.AutoSize = true;
            this.labelstatsRAM.Location = new System.Drawing.Point(668, 170);
            this.labelstatsRAM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelstatsRAM.Name = "labelstatsRAM";
            this.labelstatsRAM.Size = new System.Drawing.Size(46, 17);
            this.labelstatsRAM.TabIndex = 35;
            this.labelstatsRAM.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 254);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Volumes";
            // 
            // labelstatsVolumes
            // 
            this.labelstatsVolumes.AutoSize = true;
            this.labelstatsVolumes.Location = new System.Drawing.Point(425, 289);
            this.labelstatsVolumes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelstatsVolumes.Name = "labelstatsVolumes";
            this.labelstatsVolumes.Size = new System.Drawing.Size(46, 17);
            this.labelstatsVolumes.TabIndex = 37;
            this.labelstatsVolumes.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(533, 254);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "Volume Snapshots";
            // 
            // labelstatsVolumeSnaps
            // 
            this.labelstatsVolumeSnaps.AutoSize = true;
            this.labelstatsVolumeSnaps.Location = new System.Drawing.Point(541, 290);
            this.labelstatsVolumeSnaps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelstatsVolumeSnaps.Name = "labelstatsVolumeSnaps";
            this.labelstatsVolumeSnaps.Size = new System.Drawing.Size(54, 17);
            this.labelstatsVolumeSnaps.TabIndex = 39;
            this.labelstatsVolumeSnaps.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(689, 255);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 17);
            this.label12.TabIndex = 40;
            this.label12.Text = "Volume Storage";
            // 
            // labelstatsVolumeStorage
            // 
            this.labelstatsVolumeStorage.AutoSize = true;
            this.labelstatsVolumeStorage.Location = new System.Drawing.Point(697, 292);
            this.labelstatsVolumeStorage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelstatsVolumeStorage.Name = "labelstatsVolumeStorage";
            this.labelstatsVolumeStorage.Size = new System.Drawing.Size(54, 17);
            this.labelstatsVolumeStorage.TabIndex = 41;
            this.labelstatsVolumeStorage.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(341, 224);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 42;
            this.label14.Text = "Volumes";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(359, 89);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 17);
            this.label15.TabIndex = 43;
            this.label15.Text = "Compute";
            // 
            // btnRefreshStats
            // 
            this.btnRefreshStats.Location = new System.Drawing.Point(925, 22);
            this.btnRefreshStats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefreshStats.Name = "btnRefreshStats";
            this.btnRefreshStats.Size = new System.Drawing.Size(100, 28);
            this.btnRefreshStats.TabIndex = 44;
            this.btnRefreshStats.Text = "Refresh";
            this.btnRefreshStats.UseVisualStyleBackColor = true;
            this.btnRefreshStats.Click += new System.EventHandler(this.btnRefreshStats_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 437);
            this.Controls.Add(this.btnRefreshStats);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.labelstatsVolumeStorage);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelstatsVolumeSnaps);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelstatsVolumes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelstatsRAM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelstatsVCPUs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelstatsInstances);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImages);
            this.Controls.Add(this.btnInstances);
            this.Controls.Add(this.label_IP);
            this.Controls.Add(this.labelServidor);
            this.Controls.Add(this.textBoxIPServer);
            this.Controls.Add(this.labelServer);
            this.Controls.Add(this.labelUserLogin);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.comboBoxProject);
            this.Controls.Add(this.btnOpenProject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBoxUsername);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Main";
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
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.TextBox textBoxIPServer;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Label labelServidor;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.Button btnInstances;
        private System.Windows.Forms.Button btnImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelstatsInstances;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelstatsVCPUs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelstatsRAM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelstatsVolumes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelstatsVolumeSnaps;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelstatsVolumeStorage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnRefreshStats;
    }
}

