﻿using Newtonsoft.Json;
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
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(SecondForm_FormClosed);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 viewSecondForm = new Form1();
            viewSecondForm.Tag = this;
            viewSecondForm.Show(this);
            Hide();
        }

        private void Width_Validating(object sender, EventArgs e)
        {
            double width = 0;


            try
            {
                width = Convert.ToInt32(widthBox.Text);


            }
            catch (Exception c)
            {
                Console.WriteLine(c.Message);
                widthBox.Text = "Numbers only";
                widthBox.BackColor = Color.Tomato;

            }

            if (width < Desk.MINWIDTH)
            {
                // Do the good code
                width = Desk.MINWIDTH;
            }

            else if (width < Desk.MAXWIDTH)
            {
                // Do the bad code
                width = Desk.MAXWIDTH;
            }



            else
            {
                // Do the whoopsy code
            }
        }

        private void depthBox_Validating(object sender, CancelEventArgs e)
        {
            double depth = 0;

            try
            {
                depth = Convert.ToInt32(depthBox.Text);

            }
            catch (Exception c)
            {
                Console.WriteLine(c.Message);
                depthBox.Text = "Number only";
                depthBox.BackColor = Color.Tomato;

            }

            if (depth < Desk.MAXDEPTH)
            {
                // Do the bad code
                depth = Desk.MAXDEPTH;
            }

            else if (depth > Desk.MAXDEPTH)
            {
                // Do the bad code
                depth = Desk.MAXDEPTH;
            }
        }

        private void submitButton_Click(object sender, EventArgs eArgs)
        {
            double width1 = Convert.ToDouble(widthBox.Text);
            double depth1 = Convert.ToDouble(depthBox.Text);
            int drawerCount = Convert.ToInt32(drawerBox.Text);
            string material = materialBox.Text;


            int rushDays = Convert.ToInt32(rushBox.Text);
            string name = nameBox.Text;
            DateTime date = DateTime.Now;



            Desk desk = new Desk(width1, depth1, drawerCount, material);


            DeskQuote quote = new DeskQuote(desk, rushDays, name, date);
            double total = quote.CalculateTotal();

            var deskQuotes = new List<DeskQuote>();
            try {
                string json = File.ReadAllText("deskQuote.txt");
                deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
            } catch (Exception e) {} // handling unexpected values ourselves
            if (deskQuotes == null)
                deskQuotes = new List<DeskQuote>();

            deskQuotes.Add(quote);
            File.WriteAllText("deskQuote.txt", JsonConvert.SerializeObject(deskQuotes));

            /*
            string info = $"Width: {width1}" +
                $"\nDepth: {depth1}" +
                $"\nNumber of Drawers: {drawerCount}" +
                $"\nDesktop Material: {material}" +
                $"\nDays to Delivery: {rushDays}" +
                $"\nClient Name: {name}" +
                $"\nQuote Date: {date}" +
                $"\nTotal Amount: {total}";

            string file = "deskQuote.txt";

            File.WriteAllText(file, info);
            */

            ThirdForm viewThirdForm = new ThirdForm();


            viewThirdForm.Tag = this;
            viewThirdForm.Show(this);
            Hide();


        }


        private void drawerBox_Validating(object sender, CancelEventArgs e)
        {
            double drawerCount = 0;

            try
            {
                drawerCount = Convert.ToInt32(drawerBox.Text);

            }
            catch (Exception c)
            {
                Console.WriteLine(c.Message);
                drawerBox.Text = "Number only";
                drawerBox.BackColor = Color.Tomato;

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
        private void SecondForm_FormClosed(object sender, FormClosedEventArgs e) {
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
