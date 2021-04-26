
namespace ProjLTI
{
    partial class Images
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textBoxNameImage = new System.Windows.Forms.TextBox();
            this.comboBoxDiskFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxContainerFormat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxImages = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(95, 91);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(49, 17);
            this.labelUsername.TabIndex = 28;
            this.labelUsername.Text = "Name:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(207, 234);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 27;
            this.btnLogin.Text = "Create";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnCreateImage_Click);
            // 
            // textBoxNameImage
            // 
            this.textBoxNameImage.Location = new System.Drawing.Point(153, 87);
            this.textBoxNameImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNameImage.Name = "textBoxNameImage";
            this.textBoxNameImage.Size = new System.Drawing.Size(152, 22);
            this.textBoxNameImage.TabIndex = 26;
            // 
            // comboBoxDiskFormat
            // 
            this.comboBoxDiskFormat.FormattingEnabled = true;
            this.comboBoxDiskFormat.Items.AddRange(new object[] {
            "AMI",
            "ARI",
            "AKI",
            "VHD",
            "VHDX",
            "VMDK",
            "RAW",
            "QCOW2",
            "VDI",
            "PLOOP",
            "ISO"});
            this.comboBoxDiskFormat.Location = new System.Drawing.Point(153, 134);
            this.comboBoxDiskFormat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDiskFormat.Name = "comboBoxDiskFormat";
            this.comboBoxDiskFormat.Size = new System.Drawing.Size(152, 24);
            this.comboBoxDiskFormat.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Disk format:";
            // 
            // comboBoxContainerFormat
            // 
            this.comboBoxContainerFormat.FormattingEnabled = true;
            this.comboBoxContainerFormat.Items.AddRange(new object[] {
            "AMI",
            "ARI",
            "AKI",
            "BARE",
            "OVF",
            "OVA",
            "DOCKER"});
            this.comboBoxContainerFormat.Location = new System.Drawing.Point(153, 182);
            this.comboBoxContainerFormat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxContainerFormat.Name = "comboBoxContainerFormat";
            this.comboBoxContainerFormat.Size = new System.Drawing.Size(152, 24);
            this.comboBoxContainerFormat.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Container format:";
            // 
            // listBoxImages
            // 
            this.listBoxImages.FormattingEnabled = true;
            this.listBoxImages.ItemHeight = 16;
            this.listBoxImages.Location = new System.Drawing.Point(352, 87);
            this.listBoxImages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxImages.Name = "listBoxImages";
            this.listBoxImages.Size = new System.Drawing.Size(667, 260);
            this.listBoxImages.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(919, 374);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 34;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 393);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 35;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(352, 87);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(667, 279);
            this.listView1.TabIndex = 36;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Images
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 436);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxImages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxContainerFormat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDiskFormat);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBoxNameImage);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Images";
            this.Text = "Images";
            this.Load += new System.EventHandler(this.Images_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textBoxNameImage;
        private System.Windows.Forms.ComboBox comboBoxDiskFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxContainerFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxImages;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
    }
}