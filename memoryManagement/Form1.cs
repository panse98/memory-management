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
    public partial class mainForm : Form
    {

        Color[] colors;
        private bool isPushed = true;

        public mainForm()
        {
            InitializeComponent();

            colors = new Color[6];
            colors[0] = Color.FromArgb(245, 155, 75);
            colors[1] = Color.FromArgb(243, 255, 226);
            colors[2] = Color.FromArgb(172, 240, 242);
            colors[3] = Color.FromArgb(22, 149, 163);
            colors[4] = Color.FromArgb(34, 83, 120);
            colors[5] = Color.FromArgb(140, 40, 0);
        }

        //to close  whole app
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //forms take user input "holes/memSize"forms"
        private void btnMemSize_Click_1(object sender, EventArgs e)
        {
            memSize mem = new memSize();
            mem.Show();
        }
        private void btnAddHoles_Click(object sender, EventArgs e)
        {
            addHole holeForm = new addHole();
            holeForm.Show();
        }
       
        
        
                           /*add new process*/
        //view addProcess panel""
        private void btnAddProcess_Click(object sender, EventArgs e)
        {
            this.plAddProcess.Visible = true;
            this.PLmemLayout.Visible = false;
            this.plPending.Visible = false;
        }
        // Choose allocation method  " in addProcess panel""
        private void btnAllocation_Click_1(object sender, EventArgs e)
        {
            if (isPushed)
            {
                this.btnBestFit.Visible = true;
                this.btnFisrtFit.Visible = true;
                this.btnWorstFit.Visible = true;
                isPushed = false;
            }
            else
            {
                this.btnBestFit.Visible = false;
                this.btnFisrtFit.Visible = false;
                this.btnWorstFit.Visible = false;
                isPushed = true;
            }
        }
        private void btnFisrtFit_Click(object sender, EventArgs e)
        {
            isPushed = true;
            this.btnBestFit.Visible = false;
            this.btnFisrtFit.Visible = false;
            this.btnWorstFit.Visible = false;
            Management.allocationType = "first fit"; 
           

        }
        private void btnBestFit_Click_1(object sender, EventArgs e)
        {
            isPushed = true;
            this.btnBestFit.Visible = false;
            this.btnFisrtFit.Visible = false;
            this.btnWorstFit.Visible = false;
            Management.allocationType = "best fit";
        }
        private void btnWorstFit_Click(object sender, EventArgs e)
        {
            isPushed = true;
            this.btnBestFit.Visible = false;
            this.btnFisrtFit.Visible = false;
            this.btnWorstFit.Visible = false;
            Management.allocationType = "WorstFit";
        }
        //add new process and redraw memory
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check if l fields is empty
            object name, num;
            name = this.txtPname.Text;
            num = this.txtSegNum.Text;
            if (num == "" || name == "")
            {
                ShowMessageBox();
                return;
            }

            if (Management.allocationType == null)
            {
                ShowMessageBox("please choose allocation type first");
                return;
            }

            string Pname = name.ToString();
            int Snum = Int32.Parse(num.ToString());
            //if user enter segment nuber as a negative number
            if (Math.Sign(Snum) == -1)
            {
                ShowMessageBox("Size should be positive number");
            }

            Process P = new Process(Pname, Snum);
            object a, b;
            for (int i = 0; i < DGSegments.Rows.Count; i++)
            {
                a = DGSegments.Rows[i].Cells[0].Value;
                b = DGSegments.Rows[i].Cells[1].Value;
                if (a != null && b != null)
                {
                    P.listofsegments.Add(new Segment(a.ToString(), Int32.Parse(b.ToString())));
                }

            }
            if (Snum == P.listofsegments.Count)
            {
                if (Management.Isfit(P, Management.allocationType))
                {
                    switch (Management.allocationType)
                     {
                        case "first fit":
                            Management.Firstfit(P);
                            break;
                        case "best fit":
                            Management.Bestfit(P);
                            break;
                        case "worst fit":
                            Management.Worstfit(P);
                            break;
                     }
                    drawMemory();
                }
                else
                {

                    ShowMessageBox("Process doesn't fit, Added to pending list");
                    this.plPending.Visible = true;
                    DrawPendingList();
                }
               this.plAddProcess.Visible = false;
                this.PLmemLayout.Visible = true;

            }
            else
            {
               ShowMessageBox("please enter same number of segment ");
            }

            this.DGSegments.Rows.Clear();
            this.txtPname.Clear();
            this.txtSegNum.Clear();

        }
        private void btnCloseProcess_Click(object sender, EventArgs e)
        {
            this.plAddProcess.Visible = false;
            drawMemory();
        }



        //bar apear when mouse points to button "شكليات"
        private void btnMemSize_MouseHover(object sender, EventArgs e)
        {
            this.plSlide.Visible = true;
        }
        private void btnMemSize_MouseLeave(object sender, EventArgs e)
        {
            this.plSlide.Visible = false;

        }
        private void btnAddHoles_MouseHover(object sender, EventArgs e)
        {
            this.panel3.Visible = true;
        }
        private void btnAddHoles_MouseLeave(object sender, EventArgs e)
        {
            this.panel3.Visible = false;
        }
        private void btnAddProcess_MouseHover(object sender, EventArgs e)
        {
            this.panel4.Visible = true;
        }
        private void btnAddProcess_MouseLeave(object sender, EventArgs e)
        {
            this.panel4.Visible = false;
        }


        //Run button in middle of main form
        private void pbRun_Click(object sender, EventArgs e)
        {

            Management.Firstinput();
            Management.BindingHoles();
            drawMemory();
            this.PLmemLayout.Visible = true;
            this.pbRun.Visible = false;
            this.pbBack.Visible = true;

        }


        //add process to pending list and remove it when click on it
        public void DrawPendingProcess(Process p , int i)
        { 
            Label pendingProcess = new Label();
            pendingProcess.Size = new System.Drawing.Size(this.plPending.Size.Width,40);
            pendingProcess.Location = new Point(0, i*40);
            pendingProcess.Name = "pendingProcess";
            pendingProcess.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic);
            pendingProcess.Text = p.processname;
            pendingProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            pendingProcess.BackColor = colors[i%6];
            pendingProcess.ForeColor= Color.FromArgb(33, 36, 45);
            //create click event to allocate process "move from pending to memory" 
            pendingProcess.MouseClick += new System.Windows.Forms.MouseEventHandler(allocatePending);
            this.plPending.Controls.Add(pendingProcess);
        }  
        public void DrawPendingList()
        {
            this.plPending.Controls.Clear();
            for (int i = 0; i < Management.pendingprocess.Count(); i++)
                DrawPendingProcess(Management.pendingprocess[i], i);
        }
        public void allocatePending(object sender, EventArgs e)
        {
            chooseAllocationMessage box = new chooseAllocationMessage();
            box.ShowDialog();
            
            Label p = sender as Label;
            string processName = p.Text;

            Process P = Management.pendingprocess.Single(r => r.processname == processName);
            if (Management.Isfit(P, Management.allocationType))
            {
                switch (Management.allocationType)
                {
                    case "first fit":
                        Management.Firstfit(P);
                        break;
                    case "best fit":
                        Management.Bestfit(P);
                        break;
                    case "worst fit":
                        Management.Worstfit(P);
                        break;
                }
                Management.pendingprocess.Remove(P);
            }
            drawMemory();
        }



        //handler of memory layout "double click to deallocate process, MouseHover to show segment table"
        private void deallocHandler(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            string name = p.Controls.OfType<Label>().Single(l => l.Name == "processName").Text;
            Management.deallocation(name);
            Management.BindingHoles();
            drawMemory();
        }
        private void viewSegmenTable(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToDeleteRows=true;
            this.dataGridView1.Rows.Clear();
            Panel p = sender as Panel;
            string name = p.Controls.OfType<Label>().Single(l => l.Name == "processName").Text;
            if(name == "holes")
                  return;
            else if (name.Length>8)
            if ((name.Substring(0,9) == "allocated"))
                return;
            Process processTodraw= Management.inputprocesses.Single(r => r.processname == name);
            dataGridView1.AllowUserToAddRows = true;
            for (int i = 0; i < processTodraw.storedtable.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                row.Cells[0].Value = processTodraw.storedtable[i].indexofsegment;
                row.Cells[1].Value = processTodraw.storedtable[i].segmentname;
                row.Cells[2].Value = processTodraw.storedtable[i].baseaddress;
                row.Cells[3].Value = processTodraw.storedtable[i].limit;
                dataGridView1.Rows.Add(row);

            }
            this.dataGridView1.Visible = true;
        }
        private void hideSegTable(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            this.dataGridView1.Visible = false;

        }


        //draw new panel for processes
        private void draw_Seg(FinalTable segPanel, int newYlocation,int i)
        {
            Panel new_seg = new Panel();

            //to handle size of each segment
            float percentage = (Convert.ToSingle(segPanel.size) / Convert.ToSingle(Management.totalmemorysize));
            int ySize = Convert.ToInt32(percentage * this.PLmemLayout.Height);
            if (ySize < 30)
                ySize = 40;
            new_seg.Size = new System.Drawing.Size(this.PLmemLayout.Size.Width, ySize);
            segPanel.nextLocationY = new_seg.Size.Height + newYlocation;

            new_seg.Location = new Point(0, newYlocation);
            new_seg.Name = "Lb" + segPanel.id;
            new_seg.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Italic);
            new_seg.BackColor = colors[i % 6];
            new_seg.ForeColor= Color.FromArgb(33, 36, 45); 
            //create double click event for deallocation  
            new_seg.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(deallocHandler);
            new_seg.MouseLeave += new System.EventHandler(hideSegTable);
            new_seg.MouseHover += new System.EventHandler(viewSegmenTable);          
            
            //labels on panels
            Label processName = new Label();
            processName.Name = "processName";
            processName.Text = segPanel.label;
            processName.Size = new System.Drawing.Size(this.PLmemLayout.Size.Width, 19);
            processName.Location = new Point(new_seg.Size.Width / 5, new_seg.Size.Height / 3); ;
            processName.Visible = true;


            Label segName = new Label();
            segName.Text = segPanel.id;
            segName.Size = new System.Drawing.Size(this.PLmemLayout.Size.Width, 19);
            segName.Location = new Point(new_seg.Size.Width /2 , new_seg.Size.Height / 3); ;
            segName.Visible = true;


            Label endAddress = new Label();
            endAddress.Text = segPanel.endAddress.ToString();
            endAddress.Size = new System.Drawing.Size(this.PLmemLayout.Size.Width, 19);
            endAddress.Dock = System.Windows.Forms.DockStyle.Bottom;
            endAddress.Visible = true;

            Label startAddress = new Label();
            startAddress.Text = segPanel.startAddress.ToString();
            startAddress.Size = new System.Drawing.Size(this.PLmemLayout.Size.Width, 19);
            startAddress.Location = new Point(0, 0);
            startAddress.Visible = true;

            new_seg.Controls.Add(segName);
            new_seg.Controls.Add(startAddress);
            new_seg.Controls.Add(processName);
            new_seg.Controls.Add(endAddress);
            new_seg.Visible = true;
            this.PLmemLayout.Controls.Add(new_seg);
        }
        //draw mem layout "msh brsm 7aga kant mrsoma abl kda->a2ol l reem "
        public void drawMemory()
        {

            this.PLmemLayout.Controls.Clear();
            //hia hattsrsm kol lma a call l fun bs msh l2ia 7aga a7san
            draw_Seg(Management.finalOutput[0], 0,0);
            Management.finalOutput[0].drawnUp = true;

            for (int i = 1; i < Management.finalOutput.Count(); i++)
            {  
                    draw_Seg(Management.finalOutput[i], Management.finalOutput[i - 1].nextLocationY,i);
                    Management.finalOutput[i].drawnUp = true;
               
            }
        }

       

        //to clear all lists
        private void pbBack_Click(object sender, EventArgs e)
        {
            PLmemLayout.Controls.Clear();
            plPending.Controls.Clear();
            Management.finalOutput.Clear();
            Management.inputprocesses.Clear();
            Management.pendingprocess.Clear();
            Management.inputholes.Clear();
            Management.Sortholes();
            this.PLmemLayout.Visible = false;
            this.pbRun.Visible = true;
            this.pbBack.Visible = false;
            this.plPending.Visible = false;
        }

       

        public void ShowMessageBox()
        {
            myMessageBox box = new myMessageBox();
            box.ShowDialog();
            return;
        }

        public void ShowMessageBox(string text)
        {
            myMessageBox box = new myMessageBox();
            box.label1.Text = text;
            box.ShowDialog();
            return;
        }
    }
}
