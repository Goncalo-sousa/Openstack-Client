
namespace ProjLTI
{
    partial class MainForm
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
            this.labelProjectTop = new System.Windows.Forms.Label();
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
            this.labelstatsInstances = new System.Windows.Forms.Label();
            this.labelVCPUsTitle = new System.Windows.Forms.Label();
            this.labelstatsVCPUs = new System.Windows.Forms.Label();
            this.labelRAMTitle = new System.Windows.Forms.Label();
            this.labelstatsRAM = new System.Windows.Forms.Label();
            this.labelVolumesTitle = new System.Windows.Forms.Label();
            this.labelstatsVolumes = new System.Windows.Forms.Label();
            this.labelVolumesSnapTitle = new System.Windows.Forms.Label();
            this.labelstatsVolumeSnaps = new System.Windows.Forms.Label();
            this.labelVolumeStorageTitle = new System.Windows.Forms.Label();
            this.labelstatsVolumeStorage = new System.Windows.Forms.Label();
            this.labelVolumesBold = new System.Windows.Forms.Label();
            this.btnRefreshStats = new System.Windows.Forms.Button();
            this.btnContainers = new System.Windows.Forms.Button();
            this.labelInstancesTitle = new System.Windows.Forms.Label();
            this.labelComputeBold = new System.Windows.Forms.Label();
            this.labelSeparador = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBoxAddPort = new System.Windows.Forms.TextBox();
            this.labelPortLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(379, 152);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 9;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(376, 136);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(56, 13);
            this.labelPass.TabIndex = 8;
            this.labelPass.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(376, 92);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.Text = "Username:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(404, 224);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(379, 108);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 5;
            // 
            // labelProjectTop
            // 
            this.labelProjectTop.AutoSize = true;
            this.labelProjectTop.Location = new System.Drawing.Point(501, 21);
            this.labelProjectTop.Name = "labelProjectTop";
            this.labelProjectTop.Size = new System.Drawing.Size(48, 13);
            this.labelProjectTop.TabIndex = 11;
            this.labelProjectTop.Text = "Projetos:";
            // 
            // btnOpenProject
            // 
            this.btnOpenProject.Location = new System.Drawing.Point(216, 323);
            this.btnOpenProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenProject.Name = "btnOpenProject";
            this.btnOpenProject.Size = new System.Drawing.Size(84, 22);
            this.btnOpenProject.TabIndex = 12;
            this.btnOpenProject.Text = "Volumes";
            this.btnOpenProject.UseVisualStyleBackColor = true;
            this.btnOpenProject.Click += new System.EventHandler(this.btnOpenProject_Click);
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(552, 18);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProject.TabIndex = 15;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(418, 21);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(32, 13);
            this.labelUser.TabIndex = 21;
            this.labelUser.Text = "User:";
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Location = new System.Drawing.Point(448, 21);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(0, 13);
            this.labelUserLogin.TabIndex = 22;
            // 
            // textBoxIPServer
            // 
            this.textBoxIPServer.Location = new System.Drawing.Point(379, 198);
            this.textBoxIPServer.Name = "textBoxIPServer";
            this.textBoxIPServer.Size = new System.Drawing.Size(100, 20);
            this.textBoxIPServer.TabIndex = 25;
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(376, 182);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(41, 13);
            this.labelServer.TabIndex = 24;
            this.labelServer.Text = "Server:";
            // 
            // labelServidor
            // 
            this.labelServidor.AutoSize = true;
            this.labelServidor.Location = new System.Drawing.Point(266, 20);
            this.labelServidor.Name = "labelServidor";
            this.labelServidor.Size = new System.Drawing.Size(41, 13);
            this.labelServidor.TabIndex = 26;
            this.labelServidor.Text = "Server:";
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Location = new System.Drawing.Point(305, 21);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(0, 13);
            this.label_IP.TabIndex = 27;
            // 
            // btnInstances
            // 
            this.btnInstances.Location = new System.Drawing.Point(374, 323);
            this.btnInstances.Name = "btnInstances";
            this.btnInstances.Size = new System.Drawing.Size(75, 22);
            this.btnInstances.TabIndex = 28;
            this.btnInstances.Text = "Instances";
            this.btnInstances.UseVisualStyleBackColor = true;
            this.btnInstances.Click += new System.EventHandler(this.btnInstances_Click);
            // 
            // btnImages
            // 
            this.btnImages.Location = new System.Drawing.Point(517, 323);
            this.btnImages.Name = "btnImages";
            this.btnImages.Size = new System.Drawing.Size(75, 22);
            this.btnImages.TabIndex = 29;
            this.btnImages.Text = "Images";
            this.btnImages.UseVisualStyleBackColor = true;
            this.btnImages.Click += new System.EventHandler(this.btnImages_Click);
            // 
            // labelstatsInstances
            // 
            this.labelstatsInstances.AutoSize = true;
            this.labelstatsInstances.Location = new System.Drawing.Point(51, 138);
            this.labelstatsInstances.Name = "labelstatsInstances";
            this.labelstatsInstances.Size = new System.Drawing.Size(35, 13);
            this.labelstatsInstances.TabIndex = 31;
            this.labelstatsInstances.Text = "label2";
            // 
            // labelVCPUsTitle
            // 
            this.labelVCPUsTitle.AutoSize = true;
            this.labelVCPUsTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVCPUsTitle.Location = new System.Drawing.Point(191, 107);
            this.labelVCPUsTitle.Name = "labelVCPUsTitle";
            this.labelVCPUsTitle.Size = new System.Drawing.Size(43, 15);
            this.labelVCPUsTitle.TabIndex = 32;
            this.labelVCPUsTitle.Text = "VCPUs";
            // 
            // labelstatsVCPUs
            // 
            this.labelstatsVCPUs.AutoSize = true;
            this.labelstatsVCPUs.Location = new System.Drawing.Point(177, 138);
            this.labelstatsVCPUs.Name = "labelstatsVCPUs";
            this.labelstatsVCPUs.Size = new System.Drawing.Size(35, 13);
            this.labelstatsVCPUs.TabIndex = 33;
            this.labelstatsVCPUs.Text = "label5";
            // 
            // labelRAMTitle
            // 
            this.labelRAMTitle.AutoSize = true;
            this.labelRAMTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRAMTitle.Location = new System.Drawing.Point(331, 107);
            this.labelRAMTitle.Name = "labelRAMTitle";
            this.labelRAMTitle.Size = new System.Drawing.Size(33, 15);
            this.labelRAMTitle.TabIndex = 34;
            this.labelRAMTitle.Text = "RAM";
            // 
            // labelstatsRAM
            // 
            this.labelstatsRAM.AutoSize = true;
            this.labelstatsRAM.Location = new System.Drawing.Point(288, 138);
            this.labelstatsRAM.Name = "labelstatsRAM";
            this.labelstatsRAM.Size = new System.Drawing.Size(35, 13);
            this.labelstatsRAM.TabIndex = 35;
            this.labelstatsRAM.Text = "label7";
            // 
            // labelVolumesTitle
            // 
            this.labelVolumesTitle.AutoSize = true;
            this.labelVolumesTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVolumesTitle.Location = new System.Drawing.Point(405, 235);
            this.labelVolumesTitle.Name = "labelVolumesTitle";
            this.labelVolumesTitle.Size = new System.Drawing.Size(49, 15);
            this.labelVolumesTitle.TabIndex = 36;
            this.labelVolumesTitle.Text = "Volumes";
            // 
            // labelstatsVolumes
            // 
            this.labelstatsVolumes.AutoSize = true;
            this.labelstatsVolumes.Location = new System.Drawing.Point(391, 266);
            this.labelstatsVolumes.Name = "labelstatsVolumes";
            this.labelstatsVolumes.Size = new System.Drawing.Size(35, 13);
            this.labelstatsVolumes.TabIndex = 37;
            this.labelstatsVolumes.Text = "label9";
            // 
            // labelVolumesSnapTitle
            // 
            this.labelVolumesSnapTitle.AutoSize = true;
            this.labelVolumesSnapTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVolumesSnapTitle.Location = new System.Drawing.Point(517, 234);
            this.labelVolumesSnapTitle.Name = "labelVolumesSnapTitle";
            this.labelVolumesSnapTitle.Size = new System.Drawing.Size(97, 15);
            this.labelVolumesSnapTitle.TabIndex = 38;
            this.labelVolumesSnapTitle.Text = "Volume Snapshots";
            // 
            // labelstatsVolumeSnaps
            // 
            this.labelstatsVolumeSnaps.AutoSize = true;
            this.labelstatsVolumeSnaps.Location = new System.Drawing.Point(521, 266);
            this.labelstatsVolumeSnaps.Name = "labelstatsVolumeSnaps";
            this.labelstatsVolumeSnaps.Size = new System.Drawing.Size(41, 13);
            this.labelstatsVolumeSnaps.TabIndex = 39;
            this.labelstatsVolumeSnaps.Text = "label11";
            // 
            // labelVolumeStorageTitle
            // 
            this.labelVolumeStorageTitle.AutoSize = true;
            this.labelVolumeStorageTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVolumeStorageTitle.Location = new System.Drawing.Point(673, 235);
            this.labelVolumeStorageTitle.Name = "labelVolumeStorageTitle";
            this.labelVolumeStorageTitle.Size = new System.Drawing.Size(84, 15);
            this.labelVolumeStorageTitle.TabIndex = 40;
            this.labelVolumeStorageTitle.Text = "Volume Storage";
            // 
            // labelstatsVolumeStorage
            // 
            this.labelstatsVolumeStorage.AutoSize = true;
            this.labelstatsVolumeStorage.Location = new System.Drawing.Point(657, 266);
            this.labelstatsVolumeStorage.Name = "labelstatsVolumeStorage";
            this.labelstatsVolumeStorage.Size = new System.Drawing.Size(41, 13);
            this.labelstatsVolumeStorage.TabIndex = 41;
            this.labelstatsVolumeStorage.Text = "label13";
            // 
            // labelVolumesBold
            // 
            this.labelVolumesBold.AutoSize = true;
            this.labelVolumesBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolumesBold.Location = new System.Drawing.Point(356, 202);
            this.labelVolumesBold.Name = "labelVolumesBold";
            this.labelVolumesBold.Size = new System.Drawing.Size(73, 18);
            this.labelVolumesBold.TabIndex = 42;
            this.labelVolumesBold.Text = "Volumes";
            // 
            // btnRefreshStats
            // 
            this.btnRefreshStats.Location = new System.Drawing.Point(694, 18);
            this.btnRefreshStats.Name = "btnRefreshStats";
            this.btnRefreshStats.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshStats.TabIndex = 44;
            this.btnRefreshStats.Text = "Refresh";
            this.btnRefreshStats.UseVisualStyleBackColor = true;
            this.btnRefreshStats.Click += new System.EventHandler(this.btnRefreshStats_Click);
            // 
            // btnContainers
            // 
            this.btnContainers.Location = new System.Drawing.Point(673, 323);
            this.btnContainers.Name = "btnContainers";
            this.btnContainers.Size = new System.Drawing.Size(75, 22);
            this.btnContainers.TabIndex = 45;
            this.btnContainers.Text = "Containers";
            this.btnContainers.UseVisualStyleBackColor = true;
            this.btnContainers.Click += new System.EventHandler(this.btnContainers_Click);
            // 
            // labelInstancesTitle
            // 
            this.labelInstancesTitle.AutoSize = true;
            this.labelInstancesTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInstancesTitle.Location = new System.Drawing.Point(63, 107);
            this.labelInstancesTitle.Name = "labelInstancesTitle";
            this.labelInstancesTitle.Size = new System.Drawing.Size(55, 15);
            this.labelInstancesTitle.TabIndex = 30;
            this.labelInstancesTitle.Text = "Instances";
            // 
            // labelComputeBold
            // 
            this.labelComputeBold.AutoSize = true;
            this.labelComputeBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputeBold.Location = new System.Drawing.Point(12, 66);
            this.labelComputeBold.Name = "labelComputeBold";
            this.labelComputeBold.Size = new System.Drawing.Size(76, 18);
            this.labelComputeBold.TabIndex = 46;
            this.labelComputeBold.Text = "Compute";
            // 
            // labelSeparador
            // 
            this.labelSeparador.AutoSize = true;
            this.labelSeparador.Location = new System.Drawing.Point(158, 175);
            this.labelSeparador.Name = "labelSeparador";
            this.labelSeparador.Size = new System.Drawing.Size(493, 13);
            this.labelSeparador.TabIndex = 47;
            this.labelSeparador.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(13, 322);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 48;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBoxAddPort
            // 
            this.textBoxAddPort.Location = new System.Drawing.Point(486, 198);
            this.textBoxAddPort.Name = "textBoxAddPort";
            this.textBoxAddPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddPort.TabIndex = 49;
            // 
            // labelPortLogin
            // 
            this.labelPortLogin.AutoSize = true;
            this.labelPortLogin.Location = new System.Drawing.Point(486, 181);
            this.labelPortLogin.Name = "labelPortLogin";
            this.labelPortLogin.Size = new System.Drawing.Size(29, 13);
            this.labelPortLogin.TabIndex = 50;
            this.labelPortLogin.Text = "Port:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 355);
            this.Controls.Add(this.labelPortLogin);
            this.Controls.Add(this.textBoxAddPort);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelSeparador);
            this.Controls.Add(this.labelComputeBold);
            this.Controls.Add(this.btnContainers);
            this.Controls.Add(this.btnRefreshStats);
            this.Controls.Add(this.labelVolumesBold);
            this.Controls.Add(this.labelstatsVolumeStorage);
            this.Controls.Add(this.labelVolumeStorageTitle);
            this.Controls.Add(this.labelstatsVolumeSnaps);
            this.Controls.Add(this.labelVolumesSnapTitle);
            this.Controls.Add(this.labelstatsVolumes);
            this.Controls.Add(this.labelVolumesTitle);
            this.Controls.Add(this.labelstatsRAM);
            this.Controls.Add(this.labelRAMTitle);
            this.Controls.Add(this.labelstatsVCPUs);
            this.Controls.Add(this.labelVCPUsTitle);
            this.Controls.Add(this.labelstatsInstances);
            this.Controls.Add(this.labelInstancesTitle);
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
            this.Controls.Add(this.labelProjectTop);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "MainForm";
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
        private System.Windows.Forms.Label labelProjectTop;
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
        private System.Windows.Forms.Label labelstatsInstances;
        private System.Windows.Forms.Label labelVCPUsTitle;
        private System.Windows.Forms.Label labelstatsVCPUs;
        private System.Windows.Forms.Label labelRAMTitle;
        private System.Windows.Forms.Label labelstatsRAM;
        private System.Windows.Forms.Label labelVolumesTitle;
        private System.Windows.Forms.Label labelstatsVolumes;
        private System.Windows.Forms.Label labelVolumesSnapTitle;
        private System.Windows.Forms.Label labelstatsVolumeSnaps;
        private System.Windows.Forms.Label labelVolumeStorageTitle;
        private System.Windows.Forms.Label labelstatsVolumeStorage;
        private System.Windows.Forms.Label labelVolumesBold;
        private System.Windows.Forms.Button btnRefreshStats;
        private System.Windows.Forms.Button btnContainers;
        private System.Windows.Forms.Label labelInstancesTitle;
        private System.Windows.Forms.Label labelComputeBold;
        private System.Windows.Forms.Label labelSeparador;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBoxAddPort;
        private System.Windows.Forms.Label labelPortLogin;
    }
}

