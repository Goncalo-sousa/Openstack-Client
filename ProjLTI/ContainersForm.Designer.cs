
namespace ProjLTI
{
    partial class ContainersForm
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
            this.listViewContainers = new System.Windows.Forms.ListView();
            this.btnDeleteContainer = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreateContainer = new System.Windows.Forms.Button();
            this.textBoxNameContainer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxImageContainer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartContainer = new System.Windows.Forms.Button();
            this.btnStopContainer = new System.Windows.Forms.Button();
            this.btnRefreshContainers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewContainers
            // 
            this.listViewContainers.HideSelection = false;
            this.listViewContainers.Location = new System.Drawing.Point(251, 49);
            this.listViewContainers.Name = "listViewContainers";
            this.listViewContainers.Size = new System.Drawing.Size(522, 270);
            this.listViewContainers.TabIndex = 0;
            this.listViewContainers.UseCompatibleStateImageBehavior = false;
            // 
            // btnDeleteContainer
            // 
            this.btnDeleteContainer.Location = new System.Drawing.Point(698, 325);
            this.btnDeleteContainer.Name = "btnDeleteContainer";
            this.btnDeleteContainer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteContainer.TabIndex = 1;
            this.btnDeleteContainer.Text = "Delete";
            this.btnDeleteContainer.UseVisualStyleBackColor = true;
            this.btnDeleteContainer.Click += new System.EventHandler(this.btnDeleteContainer_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 332);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreateContainer
            // 
            this.btnCreateContainer.Location = new System.Drawing.Point(121, 173);
            this.btnCreateContainer.Name = "btnCreateContainer";
            this.btnCreateContainer.Size = new System.Drawing.Size(75, 23);
            this.btnCreateContainer.TabIndex = 3;
            this.btnCreateContainer.Text = "Create";
            this.btnCreateContainer.UseVisualStyleBackColor = true;
            this.btnCreateContainer.Click += new System.EventHandler(this.btnCreateContainer_Click);
            // 
            // textBoxNameContainer
            // 
            this.textBoxNameContainer.Location = new System.Drawing.Point(75, 93);
            this.textBoxNameContainer.Name = "textBoxNameContainer";
            this.textBoxNameContainer.Size = new System.Drawing.Size(121, 20);
            this.textBoxNameContainer.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // comboBoxImageContainer
            // 
            this.comboBoxImageContainer.FormattingEnabled = true;
            this.comboBoxImageContainer.Items.AddRange(new object[] {
            "cirros",
            "ubuntu",
            "centos"});
            this.comboBoxImageContainer.Location = new System.Drawing.Point(75, 133);
            this.comboBoxImageContainer.Name = "comboBoxImageContainer";
            this.comboBoxImageContainer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxImageContainer.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Image:";
            // 
            // btnStartContainer
            // 
            this.btnStartContainer.Location = new System.Drawing.Point(617, 20);
            this.btnStartContainer.Name = "btnStartContainer";
            this.btnStartContainer.Size = new System.Drawing.Size(75, 23);
            this.btnStartContainer.TabIndex = 8;
            this.btnStartContainer.Text = "Start";
            this.btnStartContainer.UseVisualStyleBackColor = true;
            this.btnStartContainer.Click += new System.EventHandler(this.btnStartContainer_Click);
            // 
            // btnStopContainer
            // 
            this.btnStopContainer.Location = new System.Drawing.Point(698, 20);
            this.btnStopContainer.Name = "btnStopContainer";
            this.btnStopContainer.Size = new System.Drawing.Size(75, 23);
            this.btnStopContainer.TabIndex = 9;
            this.btnStopContainer.Text = "Stop";
            this.btnStopContainer.UseVisualStyleBackColor = true;
            this.btnStopContainer.Click += new System.EventHandler(this.btnStopContainer_Click);
            // 
            // btnRefreshContainers
            // 
            this.btnRefreshContainers.Location = new System.Drawing.Point(251, 325);
            this.btnRefreshContainers.Name = "btnRefreshContainers";
            this.btnRefreshContainers.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshContainers.TabIndex = 10;
            this.btnRefreshContainers.Text = "Refresh";
            this.btnRefreshContainers.UseVisualStyleBackColor = true;
            this.btnRefreshContainers.Click += new System.EventHandler(this.btnRefreshContainers_Click);
            // 
            // ContainersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 367);
            this.Controls.Add(this.btnRefreshContainers);
            this.Controls.Add(this.btnStopContainer);
            this.Controls.Add(this.btnStartContainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxImageContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameContainer);
            this.Controls.Add(this.btnCreateContainer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteContainer);
            this.Controls.Add(this.listViewContainers);
            this.Name = "ContainersForm";
            this.Text = "Containers";
            this.Load += new System.EventHandler(this.ContainersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewContainers;
        private System.Windows.Forms.Button btnDeleteContainer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreateContainer;
        private System.Windows.Forms.TextBox textBoxNameContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxImageContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartContainer;
        private System.Windows.Forms.Button btnStopContainer;
        private System.Windows.Forms.Button btnRefreshContainers;
    }
}