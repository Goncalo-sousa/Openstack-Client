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

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

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
            foreach (var itemVM in instances.servers)
            {
                createlistBoxVMS(itemVM.Id, itemVM.Name);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
