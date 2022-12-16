namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shapes shape = new Rectangle();
            string message = shape.Area();
            string message2 = shape.Draw();
            MessageBox.Show(message);
            MessageBox.Show(message2);
        }
    }
}