using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form17_jo : MetroFramework.Forms.MetroForm
    {
        public Form17_jo()
        {
            InitializeComponent();
        }

        private void Form17_jo_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
<<<<<<< HEAD
            Form16 Form16 = new Form16();
=======
            Form16 Form16 = new Form16();//4
>>>>>>> 2c4943974f7e009d32315ec622de7451bae59a70
            Form16.Show();//2
        }
    }
}
