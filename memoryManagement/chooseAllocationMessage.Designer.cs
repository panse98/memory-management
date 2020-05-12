namespace memoryManagement
{
    partial class chooseAllocationMessage
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnBest = new System.Windows.Forms.Button();
            this.btnWorst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please choose allocation method";
            // 
            // btnFirst
            // 
            this.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(155)))), ((int)(((byte)(75)))));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Location = new System.Drawing.Point(57, 121);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(98, 41);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "First fit";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnBest
            // 
            this.btnBest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(155)))), ((int)(((byte)(75)))));
            this.btnBest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBest.Location = new System.Drawing.Point(206, 121);
            this.btnBest.Name = "btnBest";
            this.btnBest.Size = new System.Drawing.Size(98, 41);
            this.btnBest.TabIndex = 2;
            this.btnBest.Text = "Best fit";
            this.btnBest.UseVisualStyleBackColor = true;
            this.btnBest.Click += new System.EventHandler(this.btnBest_Click);
            // 
            // btnWorst
            // 
            this.btnWorst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(155)))), ((int)(((byte)(75)))));
            this.btnWorst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorst.Location = new System.Drawing.Point(346, 120);
            this.btnWorst.Name = "btnWorst";
            this.btnWorst.Size = new System.Drawing.Size(98, 41);
            this.btnWorst.TabIndex = 3;
            this.btnWorst.Text = "worst fit";
            this.btnWorst.UseVisualStyleBackColor = true;
            this.btnWorst.Click += new System.EventHandler(this.btnWorst_Click);
            // 
            // chooseAllocationMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(520, 190);
            this.ControlBox = false;
            this.Controls.Add(this.btnWorst);
            this.Controls.Add(this.btnBest);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Italic);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(155)))), ((int)(((byte)(75)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "chooseAllocationMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnBest;
        private System.Windows.Forms.Button btnWorst;
    }
}