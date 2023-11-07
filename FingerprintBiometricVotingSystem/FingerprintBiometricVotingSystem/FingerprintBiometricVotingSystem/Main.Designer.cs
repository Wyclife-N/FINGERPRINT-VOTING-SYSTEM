namespace FingerprintBiometricVotingSystem
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newVoterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCandidateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeNow = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.date = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.day = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.White;
            this.menuStrip3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.addCandidateToolStripMenuItem,
            this.resultsToolStripMenuItem1,
            this.resultsToolStripMenuItem,
            this.StudentsToolStripMenuItem,
            this.LogoutToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(971, 77);
            this.menuStrip3.TabIndex = 11;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newVoterToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = global::FingerprintBiometricVotingSystem.Properties.Resources.Enrollment1;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 73);
            this.toolStripMenuItem1.Text = "Voter Registration";
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // newVoterToolStripMenuItem
            // 
            this.newVoterToolStripMenuItem.Name = "newVoterToolStripMenuItem";
            this.newVoterToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.newVoterToolStripMenuItem.Text = "Enroll Voter";
            this.newVoterToolStripMenuItem.Click += new System.EventHandler(this.newVoterToolStripMenuItem_Click);
            // 
            // addCandidateToolStripMenuItem
            // 
            this.addCandidateToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCandidateToolStripMenuItem.Image = global::FingerprintBiometricVotingSystem.Properties.Resources.personal;
            this.addCandidateToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addCandidateToolStripMenuItem.Name = "addCandidateToolStripMenuItem";
            this.addCandidateToolStripMenuItem.Size = new System.Drawing.Size(131, 73);
            this.addCandidateToolStripMenuItem.Text = "Add Candidate";
            this.addCandidateToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addCandidateToolStripMenuItem.Click += new System.EventHandler(this.addCandidateToolStripMenuItem_Click);
            // 
            // resultsToolStripMenuItem1
            // 
            this.resultsToolStripMenuItem1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsToolStripMenuItem1.Image = global::FingerprintBiometricVotingSystem.Properties.Resources.todo;
            this.resultsToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.resultsToolStripMenuItem1.Name = "resultsToolStripMenuItem1";
            this.resultsToolStripMenuItem1.Size = new System.Drawing.Size(109, 73);
            this.resultsToolStripMenuItem1.Text = "Vote Result";
            this.resultsToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.resultsToolStripMenuItem1.Click += new System.EventHandler(this.resultsToolStripMenuItem1_Click);
            // 
            // resultsToolStripMenuItem
            // 
            this.resultsToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 11.25F);
            this.resultsToolStripMenuItem.Image = global::FingerprintBiometricVotingSystem.Properties.Resources.excercise;
            this.resultsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            this.resultsToolStripMenuItem.Size = new System.Drawing.Size(120, 73);
            this.resultsToolStripMenuItem.Text = "View Results";
            this.resultsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.resultsToolStripMenuItem.Click += new System.EventHandler(this.resultsToolStripMenuItem_Click);
            // 
            // StudentsToolStripMenuItem
            // 
            this.StudentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem});
            this.StudentsToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsToolStripMenuItem.Image = global::FingerprintBiometricVotingSystem.Properties.Resources.attendance_list_icon;
            this.StudentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem";
            this.StudentsToolStripMenuItem.Size = new System.Drawing.Size(106, 73);
            this.StudentsToolStripMenuItem.Text = "New Admin";
            this.StudentsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StudentsToolStripMenuItem.Click += new System.EventHandler(this.StudentsToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutToolStripMenuItem.Image = global::FingerprintBiometricVotingSystem.Properties.Resources.logout;
            this.LogoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(70, 73);
            this.LogoutToolStripMenuItem.Text = "Logout";
            this.LogoutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // timeNow
            // 
            this.timeNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.timeNow.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeNow.ForeColor = System.Drawing.Color.White;
            this.timeNow.Name = "timeNow";
            this.timeNow.Size = new System.Drawing.Size(64, 27);
            this.timeNow.Text = "time";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripStatusLabel8.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel8.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(77, 27);
            this.toolStripStatusLabel8.Text = "Time:";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripStatusLabel7.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel7.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(26, 27);
            this.toolStripStatusLabel7.Text = "|";
            // 
            // date
            // 
            this.date.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.date.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(63, 27);
            this.date.Text = "date";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(75, 27);
            this.toolStripStatusLabel5.Text = "Date:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(26, 27);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // day
            // 
            this.day.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.day.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.ForeColor = System.Drawing.Color.White;
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(70, 27);
            this.day.Text = "Days";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripStatusLabel2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLabel2.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 27);
            this.toolStripStatusLabel2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(116, 27);
            this.toolStripStatusLabel1.Text = "Today is:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Black;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.day,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel5,
            this.date,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8,
            this.timeNow});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(971, 32);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.BackgroundImage = global::FingerprintBiometricVotingSystem.Properties.Resources.Biometric_Voting_System2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 471);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fingerprint Biometric Voting System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.ToolStripMenuItem addCandidateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newVoterToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        internal System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem StudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel timeNow;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel date;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel day;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}