namespace MegaDesk___Greeff
{
    partial class SecondForm
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
            widthBox = new TextBox();
            button2 = new Button();
            depthBox = new TextBox();
            Width = new Label();
            Depth = new Label();
            submitButton = new Button();
            label1 = new Label();
            label2 = new Label();
            drawerBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            nameBox = new TextBox();
            materialBox = new ComboBox();
            rushBox = new ComboBox();
            SuspendLayout();
            // 
            // widthBox
            // 
            widthBox.Location = new Point(404, 226);
            widthBox.Name = "widthBox";
            widthBox.Size = new Size(44, 23);
            widthBox.TabIndex = 0;
            widthBox.Text = "0";
            widthBox.Validated += Width_Validating;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 336);
            button2.Name = "button2";
            button2.Size = new Size(121, 34);
            button2.TabIndex = 2;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // depthBox
            // 
            depthBox.Location = new Point(404, 269);
            depthBox.Name = "depthBox";
            depthBox.Size = new Size(44, 23);
            depthBox.TabIndex = 3;
            depthBox.Text = "0";
            depthBox.Validating += depthBox_Validating;
            // 
            // Width
            // 
            Width.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Width.Location = new Point(182, 223);
            Width.Name = "Width";
            Width.Size = new Size(216, 23);
            Width.TabIndex = 4;
            Width.Text = "Width (In inches Squared)";
            Width.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Depth
            // 
            Depth.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Depth.Location = new Point(182, 266);
            Depth.Name = "Depth";
            Depth.Size = new Size(216, 23);
            Depth.TabIndex = 5;
            Depth.Text = "Depth (In inches Squared)";
            Depth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // submitButton
            // 
            submitButton.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            submitButton.Location = new Point(486, 336);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(121, 34);
            submitButton.TabIndex = 6;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(182, 179);
            label1.Name = "label1";
            label1.Size = new Size(216, 23);
            label1.TabIndex = 10;
            label1.Text = "Material";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(182, 136);
            label2.Name = "label2";
            label2.Size = new Size(216, 23);
            label2.TabIndex = 9;
            label2.Text = "Number Of Drawers";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // drawerBox
            // 
            drawerBox.Location = new Point(404, 139);
            drawerBox.Name = "drawerBox";
            drawerBox.Size = new Size(44, 23);
            drawerBox.TabIndex = 7;
            drawerBox.Text = "0";
            drawerBox.Validating += drawerBox_Validating;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(182, 94);
            label3.Name = "label3";
            label3.Size = new Size(216, 23);
            label3.TabIndex = 14;
            label3.Text = "Rush order selection";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(182, 51);
            label4.Name = "label4";
            label4.Size = new Size(216, 23);
            label4.TabIndex = 13;
            label4.Text = "Customer Name";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(404, 54);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(89, 23);
            nameBox.TabIndex = 11;
            nameBox.Text = "name here";
            // 
            // materialBox
            // 
            materialBox.FormattingEnabled = true;
            materialBox.Location = new Point(404, 179);
            materialBox.Name = "materialBox";
            materialBox.Size = new Size(89, 23);
            materialBox.TabIndex = 16;
            materialBox.Text = "material";
            materialBox.Click += materialBox_Click;
            // 
            // rushBox
            // 
            rushBox.FormattingEnabled = true;
            rushBox.Items.AddRange(new object[] { "3", "5", "7", "14" });
            rushBox.Location = new Point(404, 97);
            rushBox.Name = "rushBox";
            rushBox.Size = new Size(89, 23);
            rushBox.TabIndex = 17;
            rushBox.Text = "days";
            // 
            // SecondForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 382);
            Controls.Add(rushBox);
            Controls.Add(materialBox);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(nameBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(drawerBox);
            Controls.Add(submitButton);
            Controls.Add(Depth);
            Controls.Add(Width);
            Controls.Add(depthBox);
            Controls.Add(button2);
            Controls.Add(widthBox);
            Name = "SecondForm";
            Text = "SecondForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox widthBox;
        private Button button2;
        private TextBox depthBox;
        private Label Width;
        private Label Depth;
        private Button submitButton;
        private Label label1;
        private Label label2;
        private TextBox drawerBox;
        private Label label3;
        private Label label4;
        private TextBox nameBox;
        private ComboBox materialBox;
        private ComboBox rushBox;
    }
}