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
    public partial class Volumes : Form
    {
        Main formMain;
        
        public Volumes(Main mainAux)
        {
            InitializeComponent();
            formMain = mainAux;
         
        }

        private void openProject_Load(object sender, EventArgs e)
        {
            
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
            string aux = "Name: " + name +"\t||Size: " + size + "\t|| description: " + description + "\t|| Type: " + volume_type + "\t|| Status: " + status + "\t|| Availability zone: " + zone + "\t|| Bootable: " + bootable;
            string auxDireito = "Name: " + name + " Size: " + size + " description: " + description + " Type: " + volume_type + " Status: " + status + " Availability zone: " + zone + " Bootable: " + bootable;

           /* this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[]
            {
                "Name: " + name +" Size: " + size + " description: " + description + " Type: " + volume_type + " Status: " + status + " Availability zone: " + zone + " Bootable: " + bootable
        });*/
            this.listBox1.Items.Add(auxDireito);
           // this.listBox1.MultiColumn = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreationVolume_Click(object sender, EventArgs e)
        {
            
            if (this.textBoxSizeCreation.Text != null)
            {
                string dataCreation = "{\"volume\":" +"{\"size\":" + this.textBoxSizeCreation.Text + "," +"\"availability_zone\":\"nova\"," +     "\"description\":"+"\""+ this.textBoxDescriptionCreation.Text +"\""+ "," +"\"name\":"+"\"" + this.textBoxNameCreation.Text +"\""+ "," +"\"volume_type\":\"lvmdriver-1\"}}";
                formMain.creationVolume(dataCreation);
            }
            
        }

        private void btnRefreshVolume_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            var volumes = formMain.projectDetails();
            foreach (var item in volumes.volumes)
            {
                createlistBoxVolumes(item.Size, item.Name, item.Description, item.Volume_type, item.Status, item.Availability_zone, item.Bootable);
            }
        }
    }
}
