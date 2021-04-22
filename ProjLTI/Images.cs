using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjLTI
{
    public partial class Images : Form
    {
        Main formMain;
        public Images(Main mainAux)
        {
            InitializeComponent();
            this.comboBoxDiskFormat.SelectedItem = null;
            this.comboBoxDiskFormat.Text = "--- Select ---";
            this.comboBoxContainerFormat.SelectedIndex = 3;
            formMain = mainAux;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Images_Load(object sender, EventArgs e)
        {
            var images = formMain.images();
            if (images == null)
            {
                return;
            }
            Console.WriteLine(images);
            foreach (var field in images.images)
            {
                createlistBoxImages(field.Name, field.Status, field.Visibility, field.Size, field.DiskFormat);
            }
        }

        public void createlistBoxImages(string name, string status, string visibility, long size, string disk_format)
        {

            string aux = "Name: " + name + " Status: " + status + " Visibility: " + visibility + " Size: " + size + " Disk Format: " + disk_format;

            this.listBoxImages.Items.Add(aux);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string name =this.textBoxNameImage.Text;
            string disk = this.comboBoxDiskFormat.Text;
            string container = this.comboBoxContainerFormat.Text;
            formMain.uploadImage(  name, disk.ToLower(), container.ToLower());
            refreshListBox();
        }

        public void refreshListBox()
        {
            this.listBoxImages.Items.Clear();
            var images = formMain.images();
            if (images == null)
            {
                return;
            }
            Console.WriteLine(images);
            foreach (var field in images.images)
            {
                createlistBoxImages(field.Name, field.Status, field.Visibility, field.Size, field.DiskFormat);
            }
            
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            var images = formMain.images();
            if (images == null)
            {
                return;
            }
            var index = this.listBoxImages.SelectedIndex;
            var idImage = images.images[index].Id;
            formMain.deleteImage(idImage);
            refreshListBox();
        }
    }
}
