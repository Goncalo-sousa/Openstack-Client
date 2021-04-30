using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjLTI
{
    public partial class VolumesForm : Form
    {
        MainForm formMain;

        public VolumesForm(MainForm mainAux)
        {
            InitializeComponent();
            formMain = mainAux;

        }

        private void openProject_Load(object sender, EventArgs e)
        {
            this.listViewVolumes.View = View.Details;
            this.listViewVolumes.Columns.Clear();
            this.listViewVolumes.Columns.Add("Name", -2, HorizontalAlignment.Left);
            this.listViewVolumes.Columns.Add("Size", -2, HorizontalAlignment.Left);
            this.listViewVolumes.Columns.Add("Description", -2, HorizontalAlignment.Left);
            this.listViewVolumes.Columns.Add("Type", -2, HorizontalAlignment.Left);
            this.listViewVolumes.Columns.Add("Status", -2, HorizontalAlignment.Left);
            this.listViewVolumes.Columns.Add("Availability Zone", -2, HorizontalAlignment.Left);
            this.listViewVolumes.Columns.Add("Bootable", -2, HorizontalAlignment.Left);
            var volumes = formMain.projectDetails();
            if (volumes == null)
            {
                return;
            }
            foreach (var item in volumes.volumes)
            {
                createlistBoxVolumes(item.Size, item.Name, item.Description, item.Volume_type, item.Status, item.Availability_zone, item.Bootable);
            }
        }

        public void createlistBoxVolumes(long size, string name, string description, string volume_type, string status, string zone, bool bootable)
        {
            //funcao para formatar a string de modo a entrar para a listBox no formato correto, separa os inputs dos outputs atraves
            // da seq "-->" e os tipos dos caminhos atraves da seq <+>
            //string aux = "Name: " + name +"\t||Size: " + size + "\t|| description: " + description + "\t|| Type: " + volume_type + "\t|| Status: " + status + "\t|| Availability zone: " + zone + "\t|| Bootable: " + bootable;
            //  string auxDireito = "Name: " + name + " Size: " + size + " description: " + description + " Type: " + volume_type + " Status: " + status + " Availability zone: " + zone + " Bootable: " + bootable;

            /* this.listBox1.FormattingEnabled = true;
             this.listBox1.Items.AddRange(new object[]
             {
                 "Name: " + name +" Size: " + size + " description: " + description + " Type: " + volume_type + " Status: " + status + " Availability zone: " + zone + " Bootable: " + bootable
         });*/
            string sizeHuman = size + " GiB";
            string[] row = { name, sizeHuman, description, volume_type, status, zone, bootable.ToString() };
            var listItem = new ListViewItem(row);
            this.listViewVolumes.Items.Add(listItem);

            // this.listBox1.Items.Add(auxDireito);
            // this.listBox1.MultiColumn = true;
            this.listViewVolumes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreationVolume_Click(object sender, EventArgs e)
        {

            if (this.textBoxSizeCreation.Text != null)
            {
                string dataCreation = "{\"volume\":" + "{\"size\":" + this.textBoxSizeCreation.Text + "," + "\"availability_zone\":\"nova\"," + "\"description\":" + "\"" + this.textBoxDescriptionCreation.Text + "\"" + "," + "\"name\":" + "\"" + this.textBoxNameCreation.Text + "\"" + "," + "\"volume_type\":\"lvmdriver-1\"}}";
                formMain.creationVolume(dataCreation);
            }

        }

        private void btnRefreshVolume_Click(object sender, EventArgs e)
        {
            // this.listBox1.Items.Clear();
            this.listViewVolumes.Items.Clear();
            var volumes = formMain.projectDetails();
            foreach (var item in volumes.volumes)
            {
                createlistBoxVolumes(item.Size, item.Name, item.Description, item.Volume_type, item.Status, item.Availability_zone, item.Bootable);
            }
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
