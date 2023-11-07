namespace FingerprintBiometricVotingSystem
{
    partial class Collation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Collation));
            this.txtElectionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtNoOfVotes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWinner = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoCandidate = new System.Windows.Forms.TextBox();
            this.txtImg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtVote1 = new System.Windows.Forms.TextBox();
            this.txtVote2 = new System.Windows.Forms.TextBox();
            this.txtVote3 = new System.Windows.Forms.TextBox();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtName3 = new System.Windows.Forms.TextBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // txtElectionID
            // 
            this.txtElectionID.Location = new System.Drawing.Point(149, 152);
            this.txtElectionID.Name = "txtElectionID";
            this.txtElectionID.ReadOnly = true;
            this.txtElectionID.Size = new System.Drawing.Size(205, 23);
            this.txtElectionID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(102)))), ((int)(((byte)(175)))));
            this.label1.Location = new System.Drawing.Point(-11, -40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "VOTE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(102)))), ((int)(((byte)(175)))));
            this.panel1.Location = new System.Drawing.Point(-14, -17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 10);
            this.panel1.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Election ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtNoOfVotes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtWinner);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dataGridViewEmployee);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNoCandidate);
            this.groupBox1.Controls.Add(this.txtElectionID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 395);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Candidate Results";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(102)))), ((int)(((byte)(175)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(266, 350);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 32);
            this.btnSubmit.TabIndex = 42;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtNoOfVotes
            // 
            this.txtNoOfVotes.Location = new System.Drawing.Point(149, 317);
            this.txtNoOfVotes.Name = "txtNoOfVotes";
            this.txtNoOfVotes.ReadOnly = true;
            this.txtNoOfVotes.Size = new System.Drawing.Size(205, 23);
            this.txtNoOfVotes.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "No. of Votes:";
            // 
            // txtWinner
            // 
            this.txtWinner.Location = new System.Drawing.Point(149, 278);
            this.txtWinner.Name = "txtWinner";
            this.txtWinner.ReadOnly = true;
            this.txtWinner.Size = new System.Drawing.Size(205, 23);
            this.txtWinner.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Winner:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 240);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 23);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "End Date:";
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewEmployee.ColumnHeadersHeight = 25;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(10, 22);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewEmployee.RowHeadersWidth = 25;
            this.dataGridViewEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(458, 109);
            this.dataGridViewEmployee.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Candidate\'s ID";
            // 
            // txtNoCandidate
            // 
            this.txtNoCandidate.Location = new System.Drawing.Point(149, 195);
            this.txtNoCandidate.Name = "txtNoCandidate";
            this.txtNoCandidate.ReadOnly = true;
            this.txtNoCandidate.Size = new System.Drawing.Size(205, 23);
            this.txtNoCandidate.TabIndex = 4;
            // 
            // txtImg
            // 
            this.txtImg.Location = new System.Drawing.Point(199, 515);
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(195, 20);
            this.txtImg.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(102)))), ((int)(((byte)(175)))));
            this.label2.Location = new System.Drawing.Point(-1, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "COLLATION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(102)))), ((int)(((byte)(175)))));
            this.panel2.Location = new System.Drawing.Point(-7, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 10);
            this.panel2.TabIndex = 83;
            // 
            // txtVote1
            // 
            this.txtVote1.Location = new System.Drawing.Point(751, 188);
            this.txtVote1.Name = "txtVote1";
            this.txtVote1.ReadOnly = true;
            this.txtVote1.Size = new System.Drawing.Size(133, 20);
            this.txtVote1.TabIndex = 42;
            // 
            // txtVote2
            // 
            this.txtVote2.Location = new System.Drawing.Point(751, 224);
            this.txtVote2.Name = "txtVote2";
            this.txtVote2.ReadOnly = true;
            this.txtVote2.Size = new System.Drawing.Size(133, 20);
            this.txtVote2.TabIndex = 84;
            // 
            // txtVote3
            // 
            this.txtVote3.Location = new System.Drawing.Point(751, 261);
            this.txtVote3.Name = "txtVote3";
            this.txtVote3.ReadOnly = true;
            this.txtVote3.Size = new System.Drawing.Size(133, 20);
            this.txtVote3.TabIndex = 85;
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(590, 188);
            this.txtName1.Name = "txtName1";
            this.txtName1.ReadOnly = true;
            this.txtName1.Size = new System.Drawing.Size(155, 20);
            this.txtName1.TabIndex = 42;
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(590, 224);
            this.txtName2.Name = "txtName2";
            this.txtName2.ReadOnly = true;
            this.txtName2.Size = new System.Drawing.Size(155, 20);
            this.txtName2.TabIndex = 86;
            // 
            // txtName3
            // 
            this.txtName3.Location = new System.Drawing.Point(590, 261);
            this.txtName3.Name = "txtName3";
            this.txtName3.ReadOnly = true;
            this.txtName3.Size = new System.Drawing.Size(155, 20);
            this.txtName3.TabIndex = 87;
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.ForeColor = System.Drawing.Color.Red;
            this.lblmsg.Location = new System.Drawing.Point(34, 466);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 13);
            this.lblmsg.TabIndex = 43;
            // 
            // Collation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(511, 495);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.txtName3);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.txtVote3);
            this.Controls.Add(this.txtVote2);
            this.Controls.Add(this.txtVote1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtImg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Collation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Collation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtElectionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNoCandidate;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNoOfVotes;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtWinner;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtVote1;
        public System.Windows.Forms.TextBox txtVote2;
        public System.Windows.Forms.TextBox txtVote3;
        public System.Windows.Forms.TextBox txtName1;
        public System.Windows.Forms.TextBox txtName2;
        public System.Windows.Forms.TextBox txtName3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblmsg;
    }
}