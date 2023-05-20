using Newtonsoft.Json;
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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            button2.Click += new EventHandler(button2_Click);
            searchButton.Click += new EventHandler(searchButton_Click);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Type previousType = Tag.GetType();
            Form previousForm = (Form)Activator.CreateInstance(previousType);
            previousForm.Tag = this;
            previousForm.Show(this);
            Hide();
        }


        private void searchButton_Click(object sender, EventArgs eArgs)
        {
            var deskQuotes = new List<DeskQuote>();
            try {
                string json = File.ReadAllText("deskQuote.txt");
                deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
            }
            catch (Exception e) { } // handling unexpected values ourselves
            if (deskQuotes == null)
                deskQuotes = new List<DeskQuote>();

            var filteredQuotes = new List<DeskQuote>();
            foreach (DeskQuote deskQuote in deskQuotes)
            {
                if (deskQuote._desk._material == materialBox.Text)
                    filteredQuotes.Add(deskQuote);
            }

            infoBox.Text = "";
            foreach (DeskQuote deskQuote in filteredQuotes)
            {
                infoBox.Text += "Customer Name: " + deskQuote._customerName +
                    "\n" + "Width: " + deskQuote._desk._width.ToString() + " in." +
                    "\n" + "Depth: " + deskQuote._desk._depth.ToString() + " in." +
                    "\n" + "Drawers: " + deskQuote._desk._drawerCount.ToString() +
                    "\n" + "Material: " + deskQuote._desk._material +
                    "\n" + "Rush Days: " + deskQuote._rushDays.ToString() +
                    "\n" + "Total: " + String.Format("{0, 0:C2}", deskQuote.CalculateTotal()) +
                    "\n\n";
            }
        }

        private void materialBox_Click(object sender, EventArgs e)
        {
            List<string> materials = new List<string>();
            materials.Add("Pine");
            materials.Add("Vaneer");
            materials.Add("Rosewood");
            materials.Add("Laminate");
            materials.Add("Oak");

            materialBox.DataSource = materials;
        }
    }
}
