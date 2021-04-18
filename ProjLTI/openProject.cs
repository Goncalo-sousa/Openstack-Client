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
    public partial class openProject : Form
    {
        Main formMain;
        int indexSelect;
        public openProject(Main mainAux, int index)
        {
            InitializeComponent();
            formMain = mainAux;
            indexSelect = index;
        }

        private void openProject_Load(object sender, EventArgs e)
        {
            formMain.projectDetails();
        }
    }
}
