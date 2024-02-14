using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = idTextbox.Text;
            string pw = passwordTextBox.Text;


            this.Visible = false;
            main form1 = new main();
            form1.Show();
        


        }

        private void idTextbox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.MaxLength = 14;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.MaxLength = 14;

        }
    }
}
