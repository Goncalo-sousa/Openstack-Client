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
            //Console.WriteLine(images);
            this.listView1.View = View.Details;
            this.listView1.Columns.Clear();
            this.listView1.Columns.Add("Name", -2, HorizontalAlignment.Left);
            this.listView1.Columns.Add("Status", -2, HorizontalAlignment.Left);
            this.listView1.Columns.Add("Visibility", -2, HorizontalAlignment.Left);
            this.listView1.Columns.Add("Size", -2, HorizontalAlignment.Left);
            this.listView1.Columns.Add("Disk Format", -2, HorizontalAlignment.Left);

            foreach (var field in images.images)
            {

                createlistBoxImages(field.Name, field.Status, field.Visibility, field.Size, field.DiskFormat);
            }
        }

        public void createlistBoxImages(string name, string status, string visibility, string size, string disk_format)
        {

            //string aux = "Name: " + name + " Status: " + status + " Visibility: " + visibility + " Size: " + size + " Disk Format: " + disk_format;
            //string sizeHuman = string.Empty;
            /*if (size.Equals(null))
            {*/
            string sizeHuman = BytesToString(long.Parse(size));
            /*}
            else
            {
                sizeHuman = "0";
            }*/

            string[] row = { name, status, visibility, sizeHuman, disk_format };
            var listItem = new ListViewItem(row);
            /*listView1.Items.Add(listViewItem);*/
            // this.listBoxImages.Items.Add(aux);
            this.listView1.Items.Add(listItem);
            this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnCreateImage_Click(object sender, EventArgs e)
        {

            string name = this.textBoxNameImage.Text;
            string disk = this.comboBoxDiskFormat.Text;
            string container = this.comboBoxContainerFormat.Text;
            formMain.uploadImage(name, disk.ToLower(), container.ToLower());
            refreshListBox();
        }

        public void refreshListBox()
        {
            // this.listBoxImages.Items.Clear();
            this.listView1.Items.Clear();
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
            // var index = this.listBoxImages.SelectedIndex;
            // int index = this.listView1.SelectedItems.;
            //int indexx = this.listView1.SelectedItems.IndexOfKey(listView1.SelectedItems.ToString());
            int indexx = this.listView1.FocusedItem.Index;
            var idImage = images.images[indexx].Id;
            formMain.deleteImage(idImage);
            refreshListBox();
        }
        private String BytesToString(long byteCount)
        {
            string[] suf = { " B", " KB", " MB", " GB", " TB", " PB", " EB" };
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }
    }
}
