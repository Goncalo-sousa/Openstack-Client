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
    public partial class EditImage : Form
    {
        InstancesForm formInstances;
        public EditImage(InstancesForm instancesAux)
        {
            InitializeComponent();
            formInstances = instancesAux;
        }

        private void btnApplyChange_Click(object sender, EventArgs e)
        {
            formInstances.editInstances(this.textBox1.Text);
            formInstances.refreshListBox();
            this.Close();

        }
    }
}
