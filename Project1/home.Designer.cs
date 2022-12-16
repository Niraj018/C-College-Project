namespace Project1
{
    partial class home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managaeRoutineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRoutineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTeaccherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managaeRoutineToolStripMenuItem,
            this.manageTeacherToolStripMenuItem,
            this.manageStudentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managaeRoutineToolStripMenuItem
            // 
            this.managaeRoutineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRoutineToolStripMenuItem,
            this.displayToolStripMenuItem});
            this.managaeRoutineToolStripMenuItem.Name = "managaeRoutineToolStripMenuItem";
            this.managaeRoutineToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.managaeRoutineToolStripMenuItem.Text = "Manage Routine";
            this.managaeRoutineToolStripMenuItem.Click += new System.EventHandler(this.managaeRoutineToolStripMenuItem_Click);
            // 
            // newRoutineToolStripMenuItem
            // 
            this.newRoutineToolStripMenuItem.Name = "newRoutineToolStripMenuItem";
            this.newRoutineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newRoutineToolStripMenuItem.Text = "New Routine";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // manageTeacherToolStripMenuItem
            // 
            this.manageTeacherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTeacherToolStripMenuItem,
            this.displayTeaccherToolStripMenuItem});
            this.manageTeacherToolStripMenuItem.Name = "manageTeacherToolStripMenuItem";
            this.manageTeacherToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.manageTeacherToolStripMenuItem.Text = "Manage Teacher";
            // 
            // newTeacherToolStripMenuItem
            // 
            this.newTeacherToolStripMenuItem.Name = "newTeacherToolStripMenuItem";
            this.newTeacherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newTeacherToolStripMenuItem.Text = "New Teacher";
            this.newTeacherToolStripMenuItem.Click += new System.EventHandler(this.newTeacherToolStripMenuItem_Click);
            // 
            // displayTeaccherToolStripMenuItem
            // 
            this.displayTeaccherToolStripMenuItem.Name = "displayTeaccherToolStripMenuItem";
            this.displayTeaccherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayTeaccherToolStripMenuItem.Text = "Display Teacher";
            // 
            // manageStudentToolStripMenuItem
            // 
            this.manageStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.displayStudentToolStripMenuItem});
            this.manageStudentToolStripMenuItem.Name = "manageStudentToolStripMenuItem";
            this.manageStudentToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.manageStudentToolStripMenuItem.Text = "Manage Student";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // displayStudentToolStripMenuItem
            // 
            this.displayStudentToolStripMenuItem.Name = "displayStudentToolStripMenuItem";
            this.displayStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayStudentToolStripMenuItem.Text = "Display Student";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "home";
            this.Text = "home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem managaeRoutineToolStripMenuItem;
        private ToolStripMenuItem newRoutineToolStripMenuItem;
        private ToolStripMenuItem displayToolStripMenuItem;
        private ToolStripMenuItem manageTeacherToolStripMenuItem;
        private ToolStripMenuItem newTeacherToolStripMenuItem;
        private ToolStripMenuItem displayTeaccherToolStripMenuItem;
        private ToolStripMenuItem manageStudentToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem displayStudentToolStripMenuItem;
    }
}