
namespace ProjLTI
{
    partial class Instances
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxVMs = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNameInstance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFlavorInstance = new System.Windows.Forms.ComboBox();
            this.comboBoxImageInstance = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxNetworkInstance = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listViewVMs = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(951, 346);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete VM";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(843, 346);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit VM";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(204, 234);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 28);
            this.btnCreate.TabIndex = 23;
            this.btnCreate.Text = "Create VM";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(951, 30);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "VMs";
            // 
            // listBoxVMs
            // 
            this.listBoxVMs.FormattingEnabled = true;
            this.listBoxVMs.ItemHeight = 16;
            this.listBoxVMs.Location = new System.Drawing.Point(328, 65);
            this.listBoxVMs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxVMs.Name = "listBoxVMs";
            this.listBoxVMs.Size = new System.Drawing.Size(721, 244);
            this.listBoxVMs.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 395);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 26;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // textBoxNameInstance
            // 
            this.textBoxNameInstance.Location = new System.Drawing.Point(119, 90);
            this.textBoxNameInstance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNameInstance.Name = "textBoxNameInstance";
            this.textBoxNameInstance.Size = new System.Drawing.Size(184, 22);
            this.textBoxNameInstance.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name:";
            // 
            // comboBoxFlavorInstance
            // 
            this.comboBoxFlavorInstance.FormattingEnabled = true;
            this.comboBoxFlavorInstance.Location = new System.Drawing.Point(119, 123);
            this.comboBoxFlavorInstance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxFlavorInstance.Name = "comboBoxFlavorInstance";
            this.comboBoxFlavorInstance.Size = new System.Drawing.Size(184, 24);
            this.comboBoxFlavorInstance.TabIndex = 31;
            // 
            // comboBoxImageInstance
            // 
            this.comboBoxImageInstance.FormattingEnabled = true;
            this.comboBoxImageInstance.Location = new System.Drawing.Point(119, 156);
            this.comboBoxImageInstance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxImageInstance.Name = "comboBoxImageInstance";
            this.comboBoxImageInstance.Size = new System.Drawing.Size(184, 24);
            this.comboBoxImageInstance.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Flavor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Image:";
            // 
            // comboBoxNetworkInstance
            // 
            this.comboBoxNetworkInstance.FormattingEnabled = true;
            this.comboBoxNetworkInstance.Location = new System.Drawing.Point(119, 190);
            this.comboBoxNetworkInstance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxNetworkInstance.Name = "comboBoxNetworkInstance";
            this.comboBoxNetworkInstance.Size = new System.Drawing.Size(184, 24);
            this.comboBoxNetworkInstance.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Network:";
            // 
            // listViewVMs
            // 
            this.listViewVMs.HideSelection = false;
            this.listViewVMs.Location = new System.Drawing.Point(328, 65);
            this.listViewVMs.Name = "listViewVMs";
            this.listViewVMs.Size = new System.Drawing.Size(723, 274);
            this.listViewVMs.TabIndex = 37;
            this.listViewVMs.UseCompatibleStateImageBehavior = false;
            // 
            // Instances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 438);
            this.Controls.Add(this.listViewVMs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxNetworkInstance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxImageInstance);
            this.Controls.Add(this.comboBoxFlavorInstance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameInstance);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxVMs);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Instances";
            this.Text = "Instances";
            this.Load += new System.EventHandler(this.Instances_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxVMs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNameInstance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFlavorInstance;
        private System.Windows.Forms.ComboBox comboBoxImageInstance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxNetworkInstance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewVMs;
    }
}