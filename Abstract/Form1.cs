using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Shape shape = new ShapeProvider().GetShapeObject("circle");
            MessageBox.Show(shape.Area().ToString());
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shape rectangle = new ShapeProvider().GetShapeObject("Rectangle");
            MessageBox.Show(rectangle.Area().ToString());
        }
    }
}
