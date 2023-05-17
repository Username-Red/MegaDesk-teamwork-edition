using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk___Greeff
{
    public partial class ForthForm : Form
    {
        public ForthForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 viewSecondForm = new Form1();
            viewSecondForm.Tag = this;
            viewSecondForm.Show(this);
            Hide();
        }
    }
}
