namespace PasswordManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loginbtn.Enabled = false;
            if (Untb1.Text == "Shreshthangshu" && Pwtb1.Text == "Dutta")
            {
                System.Threading.Thread.Sleep(4000);
                toolStripStatusLabel1.Text = "Access Granted";
                Form2 frm = new Form2();
                frm.Show();
                
            }
            else if (Untb1.Text == "" || Pwtb1.Text == "") 
            {
                System.Threading.Thread.Sleep(4000);
                toolStripStatusLabel1.Text = "Access Denied ! Please Enter Username and Password";
                Loginbtn.Enabled = true;
                Untb1.Focus();
            }
            else
            {
                System.Threading.Thread.Sleep(4000);
                toolStripStatusLabel1.Text = "Access Denied ! Please Enter correct Username and Password";
                Loginbtn.Enabled = true;
                Untb1.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Untb1.Clear();
        }

        private void Hidepassword(object sender, MouseEventArgs e)
        {
            Pwtb1.PasswordChar = '@';
        }
        private void Showpassword(object sender, MouseEventArgs e)
        {
            Pwtb1.PasswordChar = '\0';
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
