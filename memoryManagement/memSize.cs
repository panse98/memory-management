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
    public partial class memSize : Form
    {
        public memSize()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Size= Int32.Parse(this.txtMem.Text);
            if (Math.Sign(Size) == -1|| Math.Sign(Size) == 0)
            {
                ShowMessageBox();
            }
            else {
                Management.totalmemorysize = Size;
                this.Close();
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void memSize_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void ShowMessageBox()
        {
            myMessageBox box = new myMessageBox();
            box.ShowDialog();
            return;
        }

    }
}
