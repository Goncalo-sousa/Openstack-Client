﻿using System;
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
    public partial class Instances : Form
    {
        Main formMain;
        public Instances(Main mainAux)
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
            var index = this.listBoxVMs.SelectedIndex;
            var idInstance = instances.servers[index].Id;
            formMain.deleteInstance(idInstance);
            refreshListBox();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshListBox();
        }

        private void Instances_Load(object sender, EventArgs e)
        {
            
            var instances = formMain.instances();
            if (instances == null)
            {
                return;
            }
            foreach (var itemVM in instances.servers)
            {
                createlistBoxVMS(itemVM.Id, itemVM.Name);
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

        public void createlistBoxVMS(string id, string name)
        {

            string aux = "Id:" + id + " || Name:" + name;

            this.listBoxVMs.Items.Add(aux);
        }

        public void refreshListBox()
        {
            this.listBoxVMs.Items.Clear();
            var instances = formMain.instances();
            if (instances == null)
            {
                return;
            }
            this.listBoxVMs.Items.Clear();
            foreach (var itemVM in instances.servers)
            {
                createlistBoxVMS(itemVM.Id, itemVM.Name);
            }

        }
        public void editInstances(string name)
        {
            var instances = formMain.instances();
            var idInstance = instances.servers[this.listBoxVMs.SelectedIndex].Id;
            formMain.editInstance(name,idInstance);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
