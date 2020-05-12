namespace memoryManagement
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.TopmostPL = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.plSlide = new System.Windows.Forms.Panel();
            this.btnAddProcess = new System.Windows.Forms.Button();
            this.btnAddHoles = new System.Windows.Forms.Button();
            this.btnMemSize = new System.Windows.Forms.Button();
            this.btnWorstFit = new System.Windows.Forms.Button();
            this.btnBestFit = new System.Windows.Forms.Button();
            this.btnFisrtFit = new System.Windows.Forms.Button();
            this.btnAllocation = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PLmemLayout = new System.Windows.Forms.Panel();
            this.plAddProcess = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.DGSegments = new System.Windows.Forms.DataGridView();
            this.Segname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSegNum = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCloseProcess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSegName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaseAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbRun = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.plPending = new System.Windows.Forms.Panel();
            this.TopmostPL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.plAddProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGSegments)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // TopmostPL
            // 
            this.TopmostPL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.TopmostPL.Controls.Add(this.btnClose);
            this.TopmostPL.ForeColor = System.Drawing.Color.White;
            this.TopmostPL.Location = new System.Drawing.Point(357, 2);
            this.TopmostPL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TopmostPL.Name = "TopmostPL";
            this.TopmostPL.Size = new System.Drawing.Size(1034, 34);
            this.TopmostPL.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(957, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 44);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(155)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(63, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Memory Configuration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.plSlide);
            this.panel2.Controls.Add(this.btnAddProcess);
            this.panel2.Controls.Add(this.btnAddHoles);
            this.panel2.Controls.Add(this.btnMemSize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 153);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 619);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(155)))), ((int)(((byte)(75)))));
            this.panel4.Location = new System.Drawing.Point(0, 132);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 66);
            this.panel4.TabIndex = 9;
            this.panel4.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(155)))), ((int)(((byte)(75)))));
            this.panel3.Location = new System.Drawing.Point(0, 66);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 66);
            this.panel3.TabIndex = 8;
            this.panel3.Visible = false;
            // 
            // plSlide
            // 
            this.plSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(155)))), ((int)(((byte)(75)))));
            this.plSlide.Location = new System.Drawing.Point(0, 0);
            this.plSlide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plSlide.Name = "plSlide";
            this.plSlide.Size = new System.Drawing.Size(5, 66);
            this.plSlide.TabIndex = 6;
            this.plSlide.Visible = false;
            // 
            // btnAddProcess
            // 
            this.btnAddProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btnAddProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddProcess.FlatAppearance.BorderSize = 0;
            this.btnAddProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProcess.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddProcess.Location = new System.Drawing.Point(0, 132);
            this.btnAddProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProcess.Name = "btnAddProcess";
            this.btnAddProcess.Size = new System.Drawing.Size(328, 66);
            this.btnAddProcess.TabIndex = 4;
            this.btnAddProcess.Text = "Add new process";
            this.btnAddProcess.UseVisualStyleBackColor = false;
            this.btnAddProcess.Click += new System.EventHandler(this.btnAddProcess_Click);
            this.btnAddProcess.MouseLeave += new System.EventHandler(this.btnAddProcess_MouseLeave);
            this.btnAddProcess.MouseHover += new System.EventHandler(this.btnAddProcess_MouseHover);
            // 
            // btnAddHoles
            // 
            this.btnAddHoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btnAddHoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddHoles.FlatAppearance.BorderSize = 0;
            this.btnAddHoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHoles.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddHoles.Location = new System.Drawing.Point(0, 66);
            this.btnAddHoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddHoles.Name = "btnAddHoles";
            this.btnAddHoles.Size = new System.Drawing.Size(328, 66);
            this.btnAddHoles.TabIndex = 3;
            this.btnAddHoles.Text = "Add initial holes ";
            this.btnAddHoles.UseVisualStyleBackColor = false;
            this.btnAddHoles.Click += new System.EventHandler(this.btnAddHoles_Click);
            this.btnAddHoles.MouseLeave += new System.EventHandler(this.btnAddHoles_MouseLeave);
            this.btnAddHoles.MouseHover += new System.EventHandler(this.btnAddHoles_MouseHover);
            // 
            // btnMemSize
            // 
            this.btnMemSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btnMemSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemSize.FlatAppearance.BorderSize = 0;
            this.btnMemSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemSize.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMemSize.Location = new System.Drawing.Point(0, 0);
            this.btnMemSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMemSize.Name = "btnMemSize";
            this.btnMemSize.Size = new System.Drawing.Size(328, 66);
            this.btnMemSize.TabIndex = 2;
            this.btnMemSize.Text = "Add memory size ";
            this.btnMemSize.UseVisualStyleBackColor = false;
            this.btnMemSize.Click += new System.EventHandler(this.btnMemSize_Click_1);
            this.btnMemSize.MouseLeave += new System.EventHandler(this.btnMemSize_MouseLeave);
            this.btnMemSize.MouseHover += new System.EventHandler(this.btnMemSize_MouseHover);
            // 
            // btnWorstFit
            // 
            this.btnWorstFit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btnWorstFit.FlatAppearance.BorderSize = 0;
            this.btnWorstFit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorstFit.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnWorstFit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnWorstFit.Location = new System.Drawing.Point(26, 465);
            this.btnWorstFit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWorstFit.Name = "btnWorstFit";
            this.btnWorstFit.Size = new System.Drawing.Size(324, 62);
            this.btnWorstFit.TabIndex = 10;
            this.btnWorstFit.Text = "Worst fit method";
            this.btnWorstFit.UseVisualStyleBackColor = false;
            this.btnWorstFit.Visible = false;
            this.btnWorstFit.Click += new System.EventHandler(this.btnWorstFit_Click);
            // 
            // btnBestFit
            // 
            this.btnBestFit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btnBestFit.FlatAppearance.BorderSize = 0;
            this.btnBestFit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBestFit.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnBestFit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBestFit.Location = new System.Drawing.Point(26, 406);
            this.btnBestFit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBestFit.Name = "btnBestFit";
            this.btnBestFit.Size = new System.Drawing.Size(324, 62);
            this.btnBestFit.TabIndex = 7;
            this.btnBestFit.Text = "Best fit method";
            this.btnBestFit.UseVisualStyleBackColor = false;
            this.btnBestFit.Visible = false;
            this.btnBestFit.Click += new System.EventHandler(this.btnBestFit_Click_1);
            // 
            // btnFisrtFit
            // 
            this.btnFisrtFit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btnFisrtFit.FlatAppearance.BorderSize = 0;
            this.btnFisrtFit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFisrtFit.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnFisrtFit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFisrtFit.Location = new System.Drawing.Point(26, 345);
            this.btnFisrtFit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFisrtFit.Name = "btnFisrtFit";
            this.btnFisrtFit.Size = new System.Drawing.Size(324, 62);
            this.btnFisrtFit.TabIndex = 6;
            this.btnFisrtFit.Text = "First fit method";
            this.btnFisrtFit.UseVisualStyleBackColor = false;
            this.btnFisrtFit.Visible = false;
            this.btnFisrtFit.Click += new System.EventHandler(this.btnFisrtFit_Click);
            // 
            // btnAllocation
            // 
            this.btnAllocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.btnAllocation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btnAllocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllocation.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btnAllocation.Image = ((System.Drawing.Image)(resources.GetObject("btnAllocation.Image")));
            this.btnAllocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllocation.Location = new System.Drawing.Point(26, 302);
            this.btnAllocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAllocation.Name = "btnAllocation";
            this.btnAllocation.Size = new System.Drawing.Size(324, 43);
            this.btnAllocation.TabIndex = 5;
            this.btnAllocation.Text = "Choose allocation method";
            this.btnAllocation.UseVisualStyleBackColor = false;
            this.btnAllocation.Click += new System.EventHandler(this.btnAllocation_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 772);
            this.panel1.TabIndex = 5;
            // 
            // PLmemLayout
            // 
            this.PLmemLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PLmemLayout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.PLmemLayout.Location = new System.Drawing.Point(1068, 66);
            this.PLmemLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PLmemLayout.Name = "PLmemLayout";
            this.PLmemLayout.Size = new System.Drawing.Size(287, 614);
            this.PLmemLayout.TabIndex = 6;
            this.PLmemLayout.Visible = false;
            // 
            // plAddProcess
            // 
            this.plAddProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plAddProcess.Controls.Add(this.btnWorstFit);
            this.plAddProcess.Controls.Add(this.btnAdd);
            this.plAddProcess.Controls.Add(this.DGSegments);
            this.plAddProcess.Controls.Add(this.txtPname);
            this.plAddProcess.Controls.Add(this.label4);
            this.plAddProcess.Controls.Add(this.btnBestFit);
            this.plAddProcess.Controls.Add(this.label5);
            this.plAddProcess.Controls.Add(this.btnFisrtFit);
            this.plAddProcess.Controls.Add(this.txtSegNum);
            this.plAddProcess.Controls.Add(this.btnAllocation);
            this.plAddProcess.Controls.Add(this.panel5);
            this.plAddProcess.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plAddProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.plAddProcess.Location = new System.Drawing.Point(367, 87);
            this.plAddProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plAddProcess.Name = "plAddProcess";
            this.plAddProcess.Size = new System.Drawing.Size(883, 556);
            this.plAddProcess.TabIndex = 12;
            this.plAddProcess.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(155)))), ((int)(((byte)(75)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(409, 486);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(444, 43);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DGSegments
            // 
            this.DGSegments.BackgroundColor = System.Drawing.Color.White;
            this.DGSegments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGSegments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Segname,
            this.size});
            this.DGSegments.Location = new System.Drawing.Point(409, 118);
            this.DGSegments.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DGSegments.Name = "DGSegments";
            this.DGSegments.Size = new System.Drawing.Size(444, 356);
            this.DGSegments.TabIndex = 11;
            // 
            // Segname
            // 
            this.Segname.HeaderText = "Segment  name";
            this.Segname.Name = "Segname";
            this.Segname.Width = 200;
            // 
            // size
            // 
            this.size.HeaderText = "Segment size";
            this.size.Name = "size";
            this.size.Width = 200;
            // 
            // txtPname
            // 
            this.txtPname.Location = new System.Drawing.Point(61, 121);
            this.txtPname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(209, 24);
            this.txtPname.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Process name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Add segment number";
            // 
            // txtSegNum
            // 
            this.txtSegNum.Location = new System.Drawing.Point(63, 214);
            this.txtSegNum.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSegNum.Name = "txtSegNum";
            this.txtSegNum.Size = new System.Drawing.Size(209, 24);
            this.txtSegNum.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.panel5.Controls.Add(this.btnCloseProcess);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(879, 46);
            this.panel5.TabIndex = 0;
            // 
            // btnCloseProcess
            // 
            this.btnCloseProcess.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseProcess.FlatAppearance.BorderSize = 0;
            this.btnCloseProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCloseProcess.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseProcess.Image")));
            this.btnCloseProcess.Location = new System.Drawing.Point(818, 0);
            this.btnCloseProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseProcess.Name = "btnCloseProcess";
            this.btnCloseProcess.Size = new System.Drawing.Size(61, 46);
            this.btnCloseProcess.TabIndex = 1;
            this.btnCloseProcess.UseVisualStyleBackColor = true;
            this.btnCloseProcess.Click += new System.EventHandler(this.btnCloseProcess_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add process";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idx,
            this.colSegName,
            this.colBaseAddress,
            this.colLimit});
            this.dataGridView1.Location = new System.Drawing.Point(667, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // idx
            // 
            this.idx.HeaderText = "idx";
            this.idx.Name = "idx";
            this.idx.Width = 50;
            // 
            // colSegName
            // 
            this.colSegName.HeaderText = "segName";
            this.colSegName.Name = "colSegName";
            // 
            // colBaseAddress
            // 
            this.colBaseAddress.HeaderText = "bsaseAddress";
            this.colBaseAddress.Name = "colBaseAddress";
            // 
            // colLimit
            // 
            this.colLimit.HeaderText = "limit";
            this.colLimit.Name = "colLimit";
            // 
            // pbRun
            // 
            this.pbRun.Image = ((System.Drawing.Image)(resources.GetObject("pbRun.Image")));
            this.pbRun.Location = new System.Drawing.Point(788, 308);
            this.pbRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbRun.Name = "pbRun";
            this.pbRun.Size = new System.Drawing.Size(150, 135);
            this.pbRun.TabIndex = 7;
            this.pbRun.TabStop = false;
            this.pbRun.Click += new System.EventHandler(this.pbRun_Click);
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(388, 880);
            this.pbBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(61, 62);
            this.pbBack.TabIndex = 9;
            this.pbBack.TabStop = false;
            this.pbBack.Visible = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // plPending
            // 
            this.plPending.Location = new System.Drawing.Point(385, 43);
            this.plPending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plPending.Name = "plPending";
            this.plPending.Size = new System.Drawing.Size(254, 600);
            this.plPending.TabIndex = 10;
            this.plPending.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.ControlBox = false;
            this.Controls.Add(this.plAddProcess);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PLmemLayout);
            this.Controls.Add(this.TopmostPL);
            this.Controls.Add(this.plPending);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.pbRun);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TopmostPL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plAddProcess.ResumeLayout(false);
            this.plAddProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGSegments)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopmostPL;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAllocation;
        private System.Windows.Forms.Button btnAddProcess;
        private System.Windows.Forms.Button btnAddHoles;
        private System.Windows.Forms.Button btnMemSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBestFit;
        private System.Windows.Forms.Button btnFisrtFit;
        private System.Windows.Forms.Panel plSlide;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        public  System.Windows.Forms.Panel PLmemLayout;
        private System.Windows.Forms.PictureBox pbRun;
        private System.Windows.Forms.Button btnWorstFit;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Panel plAddProcess;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseProcess;
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSegNum;
        private System.Windows.Forms.DataGridView DGSegments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Segname;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel plPending;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idx;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSegName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBaseAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimit;
    }
}

