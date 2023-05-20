using System.Configuration;

namespace MegaDesk___Greeff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(Form1_FormClosed);
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
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            if (getFormsCount() == 0)
                Application.Exit();
        }
        private int getFormsCount() {
            int count = 0;
            foreach (Form form in Application.OpenForms)
                if (form.Visible)
                    count++;

            return count;
        }

    }
}