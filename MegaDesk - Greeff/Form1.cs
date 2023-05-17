using System.Configuration;

namespace MegaDesk___Greeff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecondForm viewSecondForm = new SecondForm();
            viewSecondForm.Tag = this;
            viewSecondForm.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThirdForm viewSecondForm = new ThirdForm();
            viewSecondForm.Tag = this;
            viewSecondForm.Show(this);
            Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Tag = this;
            searchForm.Show(this);
            Hide();
        }

                
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}