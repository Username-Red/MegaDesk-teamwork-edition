using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace MegaDesk___Greeff
{
    public partial class ThirdForm : Form
    {
        public ThirdForm()
        {
            InitializeComponent();
            loadButton.Click += new EventHandler(loadButton_Click);
            button2.Click += new EventHandler(button2_Click);
        }

        private void Button2_Click(object? sender, EventArgs e) {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 viewSecondForm = new Form1();
            viewSecondForm.Tag = this;
            viewSecondForm.Show(this);
            Hide();
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void materialBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void drawerBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void Depth_Click(object sender, EventArgs e)
        {
        }

        private void Width_Click(object sender, EventArgs e)
        {
        }



        private void depthBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void widthBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText("deskQuote.txt");
            var deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
            if (deskQuotes == null)
                deskQuotes = new List<DeskQuote>();
            
            foreach (DeskQuote deskQuote in deskQuotes) {
                infoBox.Text += "Customer Name: " + deskQuote._customerName +
                    "\n" + "Width: " + deskQuote._desk._width.ToString() + " in." +
                    "\n" + "Depth: " + deskQuote._desk._depth.ToString() + " in." +
                    "\n" + "Drawers: " + deskQuote._desk._drawerCount.ToString() +
                    "\n" + "Material: " + deskQuote._desk._material +
                    "\n" + "Rush Days: " + deskQuote._rushDays.ToString() +
                    "\n" + "Total: " + String.Format("{0, 0:C2}", deskQuote.CalculateTotal()) +
                    "\n\n";
            }
            /*
            string file = "deskQuote.txt";
            string str = File.ReadAllText(file);
            infoBox.Text = str;
            */
        }

        private void infoBox_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e) {
            SearchForm searchForm = new SearchForm();
            searchForm.Tag = this;
            searchForm.Show(this);
            Hide();
        }
    }
}
