
namespace ProjLTI
{
    partial class Volumes
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameCreation = new System.Windows.Forms.TextBox();
            this.textBoxDescriptionCreation = new System.Windows.Forms.TextBox();
            this.textBoxSizeCreation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreationVolume = new System.Windows.Forms.Button();
            this.btnRefreshVolume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(242, 53);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(526, 225);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Volumes";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(11, 325);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 19);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Create Volumes";
            // 
            // textBoxNameCreation
            // 
            this.textBoxNameCreation.Location = new System.Drawing.Point(83, 87);
            this.textBoxNameCreation.Name = "textBoxNameCreation";
            this.textBoxNameCreation.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameCreation.TabIndex = 4;
            // 
            // textBoxDescriptionCreation
            // 
            this.textBoxDescriptionCreation.Location = new System.Drawing.Point(83, 139);
            this.textBoxDescriptionCreation.Name = "textBoxDescriptionCreation";
            this.textBoxDescriptionCreation.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescriptionCreation.TabIndex = 5;
            // 
            // textBoxSizeCreation
            // 
            this.textBoxSizeCreation.Location = new System.Drawing.Point(83, 113);
            this.textBoxSizeCreation.Name = "textBoxSizeCreation";
            this.textBoxSizeCreation.Size = new System.Drawing.Size(100, 20);
            this.textBoxSizeCreation.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description";
            // 
            // btnCreationVolume
            // 
            this.btnCreationVolume.Location = new System.Drawing.Point(108, 178);
            this.btnCreationVolume.Name = "btnCreationVolume";
            this.btnCreationVolume.Size = new System.Drawing.Size(75, 23);
            this.btnCreationVolume.TabIndex = 10;
            this.btnCreationVolume.Text = "Create";
            this.btnCreationVolume.UseVisualStyleBackColor = true;
            this.btnCreationVolume.Click += new System.EventHandler(this.btnCreationVolume_Click);
            // 
            // btnRefreshVolume
            // 
            this.btnRefreshVolume.Location = new System.Drawing.Point(693, 295);
            this.btnRefreshVolume.Name = "btnRefreshVolume";
            this.btnRefreshVolume.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshVolume.TabIndex = 11;
            this.btnRefreshVolume.Text = "Refresh";
            this.btnRefreshVolume.UseVisualStyleBackColor = true;
            this.btnRefreshVolume.Click += new System.EventHandler(this.btnRefreshVolume_Click);
            // 
            // Volumes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.btnRefreshVolume);
            this.Controls.Add(this.btnCreationVolume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSizeCreation);
            this.Controls.Add(this.textBoxDescriptionCreation);
            this.Controls.Add(this.textBoxNameCreation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Volumes";
            this.Text = "Volumes";
            this.Load += new System.EventHandler(this.openProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNameCreation;
        private System.Windows.Forms.TextBox textBoxDescriptionCreation;
        private System.Windows.Forms.TextBox textBoxSizeCreation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreationVolume;
        private System.Windows.Forms.Button btnRefreshVolume;
    }
}