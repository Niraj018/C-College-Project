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
    public partial class AddStudent : Form
    {
        int index = 0;
        Student[] students = new Student[3];
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Student student = new Student();
            student.Name = Name.Text;
            student.Address = Address.Text; 
            student.Email = Email.Text;
            students[index] = student;
            index++;
            MessageBox.Show("Great job");
            Name.Text = "";
            Address.Text = "";
            Email.Text = "";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayStudent displayStudent = new DisplayStudent(students);
            displayStudent.Show();
            ///displayStudent.students = students;
        }
    }
}
