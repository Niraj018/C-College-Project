namespace Project1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = UsernameField.Text;
            string pname = PasswordField.Text;
            string message;
            if(uname == "Niraj" && pname == "niraj")
            {
                message = "Login Success";
            }
            else
            {
                message = "Try Again";
            }
            MessageBox.Show(message , "Message");
        }

        private void UsernameField_TextChanged(object sender, EventArgs e) { 

        }
    }
}