namespace MegaDesk___Greeff
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            searchButton = new Button();
            infoBox = new Label();
            button2 = new Button();
            materialBox = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(486, 338);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(121, 34);
            searchButton.TabIndex = 45;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // infoBox
            // 
            infoBox.BackColor = SystemColors.ButtonHighlight;
            infoBox.BorderStyle = BorderStyle.FixedSingle;
            infoBox.Location = new Point(189, 10);
            infoBox.Name = "infoBox";
            infoBox.Size = new Size(222, 289);
            infoBox.TabIndex = 44;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(11, 338);
            button2.Name = "button2";
            button2.Size = new Size(121, 34);
            button2.TabIndex = 42;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // materialBox
            // 
            materialBox.FormattingEnabled = true;
            materialBox.Items.AddRange(new object[] { "Pine", "Vaneer", "Rosewood", "Oak", "Laminate" });
            materialBox.Location = new Point(11, 59);
            materialBox.Name = "materialBox";
            materialBox.Size = new Size(164, 23);
            materialBox.TabIndex = 47;
            materialBox.Text = "material";
            materialBox.Click += materialBox_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 22);
            label1.Name = "label1";
            label1.Size = new Size(173, 23);
            label1.TabIndex = 46;
            label1.Text = "Search By Material";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 382);
            Controls.Add(materialBox);
            Controls.Add(label1);
            Controls.Add(searchButton);
            Controls.Add(infoBox);
            Controls.Add(button2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SearchForm";
            Text = "SearchForm";
            ResumeLayout(false);
        }

        #endregion

        private Button searchButton;
        private Label infoBox;
        private Button button2;
        private ComboBox materialBox;
        private Label label1;
    }
}