using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoryManagement
{
    public partial class chooseAllocationMessage : Form
    {
        public chooseAllocationMessage()
        {
            InitializeComponent();
        }


        private void btnFirst_Click(object sender, EventArgs e)
        {
            Management.allocationType = "first fit";
            this.Close();
        }

        private void btnBest_Click(object sender, EventArgs e)
        {
            Management.allocationType = "best fit";
            this.Close();
        }

        private void btnWorst_Click(object sender, EventArgs e)
        {
            Management.allocationType = "worst fit";
            this.Close();
        }
    }
}
