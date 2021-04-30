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
    public partial class ContainersForm : Form
    {
        MainForm formAux;
        public ContainersForm(MainForm mainAux)
        {
            InitializeComponent();
            formAux = mainAux;
        }

        private async void btnDeleteContainer_Click(object sender, EventArgs e)
        {
            var containers = formAux.getContainers();
            if (containers == null)
            {
                return;
            }
            int indexx = this.listViewContainers.FocusedItem.Index;
            // var index = this.listBoxVMs.SelectedIndex;
            var idContainer = containers.containers[indexx].uuid;
            var statusContainer = containers.containers[indexx].status;
            this.listViewContainers.Items[indexx].SubItems.Add("Deleting ......");
            this.listViewContainers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            formAux.deleteContainer(idContainer, statusContainer);
            await Task.Delay(8000);
            this.listViewContainers.Items[indexx].SubItems.Add("");
            refreshListView();
        }

        private void btnCreateContainer_Click(object sender, EventArgs e)
        {
            if (this.comboBoxImageContainer.SelectedIndex == -1)
            {
                MessageBox.Show("Select image!");
            }
            else
            {
                formAux.createContainer(this.textBoxNameContainer.Text, this.comboBoxImageContainer.Text);
                refreshListView();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ContainersForm_Load(object sender, EventArgs e)
        {
            this.listViewContainers.View = View.Details;
            this.listViewContainers.Columns.Clear();
            this.listViewContainers.Columns.Add("Name", -2, HorizontalAlignment.Left);
            this.listViewContainers.Columns.Add("Image", -2, HorizontalAlignment.Left);
            this.listViewContainers.Columns.Add("Status", -2, HorizontalAlignment.Left);
            this.listViewContainers.Columns.Add("Task Status", -2, HorizontalAlignment.Left);


            var containers = formAux.getContainers();
            if (containers == null)
            {
                return;
            }
            foreach (var item in containers.containers)
            {
                createlistViewContainers(item.name, item.image, item.status);
            }
        }

        private void createlistViewContainers(string name, string image, string status)
        {

            string[] row = { name, image, status };
            var listItem = new ListViewItem(row);
            this.listViewContainers.Items.Add(listItem);
            this.listViewContainers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void refreshListView()
        {

            this.listViewContainers.Items.Clear();
            var containers = formAux.getContainers();
            if (containers == null)
            {
                return;
            }

            foreach (var item in containers.containers)
            {
                createlistViewContainers(item.name, item.image, item.status);
            }

        }

        private void btnRefreshContainers_Click(object sender, EventArgs e)
        {
            refreshListView();
        }

        private async void btnStartContainer_Click(object sender, EventArgs e)
        {
            var containers = formAux.getContainers();
            if (containers == null)
            {
                return;
            }
            int indexx = this.listViewContainers.FocusedItem.Index;
            // var index = this.listBoxVMs.SelectedIndex;
            var idContainer = containers.containers[indexx].uuid;
            var statusContainer = containers.containers[indexx].status;
            this.listViewContainers.Items[indexx].SubItems.Add("Starting ......");
            this.listViewContainers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            formAux.startContainer(idContainer, statusContainer);
            await Task.Delay(10000);
            this.listViewContainers.Items[indexx].SubItems.Add("");
            refreshListView();
        }

        private async void btnStopContainer_Click(object sender, EventArgs e)
        {
            var containers = formAux.getContainers();
            if (containers == null)
            {
                return;
            }
            int indexx = this.listViewContainers.FocusedItem.Index;
            // var index = this.listBoxVMs.SelectedIndex;
            var idContainer = containers.containers[indexx].uuid;
            var statusContainer = containers.containers[indexx].status;
            this.listViewContainers.Items[indexx].SubItems.Add("Stopping ......");
            this.listViewContainers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            formAux.stopContainer(idContainer, statusContainer);
            await Task.Delay(8000);
            this.listViewContainers.Items[indexx].SubItems.Add("");
            refreshListView();
        }
    }
}
