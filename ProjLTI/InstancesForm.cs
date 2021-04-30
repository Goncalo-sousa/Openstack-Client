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
    public partial class InstancesForm : Form
    {
        MainForm formMain;
        public InstancesForm(MainForm mainAux)
        {
            InitializeComponent();
            formMain = mainAux;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var getFlavors = formMain.getFlavors();
            var getNetworks = formMain.getNetworks();
            var getImages = formMain.images();
            if (getFlavors == null && getNetworks == null)
            {
                return;
            }
            var flavorTocreate = getFlavors.flavors[this.comboBoxFlavorInstance.SelectedIndex].Id;
            var networkTocreate = getNetworks.networks[this.comboBoxNetworkInstance.SelectedIndex].Id;
            var imageTocreate = getImages.images[this.comboBoxImageInstance.SelectedIndex].Id;
            formMain.createInstances(this.textBoxNameInstance.Text, flavorTocreate, imageTocreate, networkTocreate);
            refreshListBox();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditImage formAux = new EditImage(this);
            formAux.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var instances = formMain.instances();
            if (instances == null)
            {
                return;
            }
            int indexx = this.listViewVMs.FocusedItem.Index;
            // var index = this.listBoxVMs.SelectedIndex;
            var idInstance = instances.servers[indexx].id;
            formMain.deleteInstance(idInstance);
            refreshListBox();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshListBox();
        }

        private void Instances_Load(object sender, EventArgs e)
        {
            this.listViewVMs.View = View.Details;
            this.listViewVMs.Columns.Clear();
            this.listViewVMs.Columns.Add("Name", -2, HorizontalAlignment.Left);
            this.listViewVMs.Columns.Add("Flavor", -2, HorizontalAlignment.Left);
            this.listViewVMs.Columns.Add("Status", -2, HorizontalAlignment.Left);
            this.listViewVMs.Columns.Add("Image", -2, HorizontalAlignment.Left);

            var instances = formMain.instances();
            if (instances == null)
            {
                return;
            }
            foreach (var itemVM in instances.servers)
            {
                createlistBoxVMS(itemVM.name, itemVM.flavor.id, itemVM.status, itemVM.accessIPv4, itemVM.image.id);
            }

            var getFlavors = formMain.getFlavors();
            var getNetworks = formMain.getNetworks();
            var images = formMain.images();
            if (getFlavors == null && getNetworks == null)
            {
                return;
            }

            foreach (var flavorName in getFlavors.flavors)
            {
                this.comboBoxFlavorInstance.Items.Add(flavorName.Name);
            }
            foreach (var imageName in images.images)
            {
                this.comboBoxImageInstance.Items.Add(imageName.Name);
            }
            foreach (var networkName in getNetworks.networks)
            {
                this.comboBoxNetworkInstance.Items.Add(networkName.Name);
            }
        }

        public void createlistBoxVMS(string name, string flavorid, string status, string power_state, string imageid)
        {
            string flavor="";
            string image="";
            var getFlavors = formMain.getFlavors();
            foreach (var item in getFlavors.flavors)
            {
                if (item.Id.Equals(flavorid))
                {
                    flavor = item.Name;
                }  
            }
            var getimages = formMain.images();
            foreach (var item in getimages.images)
            {
                if (item.Id.Equals(imageid))
                {
                    image = item.Name;
                }
            }
            
            string[] row = { name, flavor, status, image };
            var listItem = new ListViewItem(row);
            this.listViewVMs.Items.Add(listItem);
            // this.listBoxVMs.Items.Add(aux);
            this.listViewVMs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        public void refreshListBox()
        {
            // this.listBoxVMs.Items.Clear();
            this.listViewVMs.Items.Clear();
            var instances = formMain.instances();
            if (instances == null)
            {
                return;
            }
            // this.listBoxVMs.Items.Clear();
            foreach (var itemVM in instances.servers)
            {
                createlistBoxVMS(itemVM.name, itemVM.flavor.id, itemVM.status, itemVM.accessIPv4, itemVM.image.id);
            }

        }
        public void editInstances(string name)
        {
            var instances = formMain.instances();
            //var idInstance = instances.servers[this.listBoxVMs.SelectedIndex].Id;
            var idInstance = instances.servers[this.listViewVMs.FocusedItem.Index].id;
            formMain.editInstance(name, idInstance);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
