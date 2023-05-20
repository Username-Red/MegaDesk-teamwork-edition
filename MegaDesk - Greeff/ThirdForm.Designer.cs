namespace MegaDesk___Greeff
{
    partial class ThirdForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(14, 448);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadButton.Location = new System.Drawing.Point(267, 448);
            this.loadButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(138, 45);
            this.loadButton.TabIndex = 39;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoBox.Location = new System.Drawing.Point(217, 12);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(253, 385);
            this.infoBox.TabIndex = 40;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(555, 448);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(138, 45);
            this.searchButton.TabIndex = 41;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(708, 426);
            this.dataGridView1.TabIndex = 42;
            // 
            // ThirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 509);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ThirdForm";
            this.Text = "ThirdForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBox1;
        private Button button2;
        private Button loadButton;
        private Label infoBox;
        private Button searchButton;
        private DataGridView dataGridView1;
    }
}