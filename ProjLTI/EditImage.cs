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
        Instances formInstances;
        public EditImage(Instances instancesAux)
        {
            InitializeComponent();
            formInstances = instancesAux;
        }
    }
}
