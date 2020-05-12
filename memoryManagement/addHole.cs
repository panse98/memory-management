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

    public partial class addHole : Form
    {
        public addHole()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void   btnAdd_Click(object sender, EventArgs e)
        {
            object a, b;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                a = dataGridView1.Rows[i].Cells[0].Value;
                b = dataGridView1.Rows[i].Cells[1].Value;
                if (a != null && b != null)
                {
                   Management.inputholes.Add(new Hole(Int32.Parse(a.ToString()), Int32.Parse(b.ToString())));
                }
            }
            Management.Sortholes();
            this.Close();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
