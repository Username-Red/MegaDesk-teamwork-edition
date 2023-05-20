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
            FormClosed += new FormClosedEventHandler(ThirdForm_FormClosed);
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

        private void loadButton_Click(object sender, EventArgs eArgs)
        {
            var deskQuotes = new List<DeskQuote>();
            try {
                string json = File.ReadAllText("deskQuote.txt");
                deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
            }
            catch (Exception e) { } // handling unexpected values ourselves
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

            DataTable table = new DataTable("Quotes");
            /*
            table.Columns.Add(new DataColumn("Name", typeof(string)));
            DataRow row = table.NewRow();
            row["Name"] = "Craig Bitner";
            table.Rows.Add(row);
            */

            table.Columns.Add(new DataColumn("Name", typeof(string)));
            table.Columns.Add(new DataColumn("Width", typeof(int)));
            table.Columns.Add(new DataColumn("Depth", typeof(int)));
            table.Columns.Add(new DataColumn("Drawers", typeof(int)));
            table.Columns.Add(new DataColumn("Material", typeof(string)));
            table.Columns.Add(new DataColumn("Rush Days", typeof(int)));
            table.Columns.Add(new DataColumn("Total", typeof(double)));

            foreach (DeskQuote deskQuote in deskQuotes) {
                DataRow row = table.NewRow();
                row["Name"] = deskQuote._customerName;
                row["Width"] = deskQuote._desk._width;
                row["Depth"] = deskQuote._desk._depth;
                row["Drawers"] = deskQuote._desk._drawerCount;
                row["Material"] = deskQuote._desk._material;
                row["Rush Days"] = deskQuote._rushDays;
                row["Total"] = deskQuote.CalculateTotal();
                table.Rows.Add(row);
            }

            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(table);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = table;
            dataGridView1.DataSource = bindingSource;

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
        private void ThirdForm_FormClosed(object sender, FormClosedEventArgs e) {
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
