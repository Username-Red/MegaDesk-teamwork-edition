namespace MegaDesk___Greeff {
    partial class SearchForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.searchButton = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.materialBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(556, 450);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(138, 45);
            this.searchButton.TabIndex = 45;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoBox.Location = new System.Drawing.Point(216, 14);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(253, 385);
            this.infoBox.TabIndex = 44;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(13, 450);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 45);
            this.button2.TabIndex = 42;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // materialBox
            // 
            this.materialBox.FormattingEnabled = true;
            this.materialBox.Items.AddRange(new object[] {
            "Pine",
            "Vaneer",
            "Rosewood",
            "Oak",
            "Laminate"});
            this.materialBox.Location = new System.Drawing.Point(13, 79);
            this.materialBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(187, 28);
            this.materialBox.TabIndex = 47;
            this.materialBox.Text = "material";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 31);
            this.label1.TabIndex = 46;
            this.label1.Text = "Search By Material";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 509);
            this.Controls.Add(this.materialBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.button2);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button searchButton;
        private Label infoBox;
        private Button button2;
        private ComboBox materialBox;
        private Label label1;
    }
}