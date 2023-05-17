using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk___Greeff {
    public partial class SearchForm : Form {
            public SearchForm() {
                InitializeComponent();
                button2.Click += new EventHandler(button2_Click);
                searchButton.Click += new EventHandler(searchButton_Click);
            }



            private void button2_Click(object sender, EventArgs e) {
                Type previousType = Tag.GetType();
                Form previousForm = (Form) Activator.CreateInstance(previousType);
                previousForm.Tag = this;
                previousForm.Show(this);
                Hide();
            }



            private void label4_Click(object sender, EventArgs e) {

            }

            private void materialBox_SelectedIndexChanged(object sender, EventArgs e) {
            }

            private void label3_Click(object sender, EventArgs e) {
            }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            }

            private void textBox4_TextChanged(object sender, EventArgs e) {
            }

            private void label1_Click(object sender, EventArgs e) {
            }

            private void label2_Click(object sender, EventArgs e) {
            }

            private void drawerBox_TextChanged(object sender, EventArgs e) {
            }

            private void Depth_Click(object sender, EventArgs e) {
            }

            private void Width_Click(object sender, EventArgs e) {
            }



            private void depthBox_TextChanged(object sender, EventArgs e) {
            }

            private void widthBox_TextChanged(object sender, EventArgs e) {
            }

            private void textBox6_TextChanged(object sender, EventArgs e) {

            }

            private void loadButton_Click(object sender, EventArgs e) {





            }

            private void infoBox_Click(object sender, EventArgs e) {

            }

            private void searchButton_Click(object sender, EventArgs e) {
                infoBox.Text = File.ReadAllText("deskQuote.txt");
            }
        }
    }
