using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void managaeRoutineToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //// home form1 = new home();
//form1.Show();
        }

        private void newTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addstudent = new AddStudent();
            addstudent.Show();
        }
    }
}
