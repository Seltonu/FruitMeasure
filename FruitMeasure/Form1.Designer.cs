namespace FruitMeasure
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.typeOfFruitBox = new System.Windows.Forms.ComboBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.feetBox = new System.Windows.Forms.TextBox();
            this.feetLabel = new System.Windows.Forms.Label();
            this.inchesLabel = new System.Windows.Forms.Label();
            this.inchesBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.convertedOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.developers = new System.Windows.Forms.Label();
            this.fruitPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fruitPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // typeOfFruitBox
            // 
            this.typeOfFruitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfFruitBox.FormattingEnabled = true;
            this.typeOfFruitBox.Location = new System.Drawing.Point(151, 12);
            this.typeOfFruitBox.Name = "typeOfFruitBox";
            this.typeOfFruitBox.Size = new System.Drawing.Size(121, 21);
            this.typeOfFruitBox.TabIndex = 0;
            this.typeOfFruitBox.SelectedIndexChanged += new System.EventHandler(this.typeOfFruitBox_SelectedIndexChanged);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.heightLabel.Location = new System.Drawing.Point(12, 10);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(122, 20);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "YOUR HEIGHT";
            this.heightLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // feetBox
            // 
            this.feetBox.Location = new System.Drawing.Point(12, 51);
            this.feetBox.Name = "feetBox";
            this.feetBox.Size = new System.Drawing.Size(119, 20);
            this.feetBox.TabIndex = 2;
            this.feetBox.TextChanged += new System.EventHandler(this.feetBox_TextChanged);
            // 
            // feetLabel
            // 
            this.feetLabel.AutoSize = true;
            this.feetLabel.Location = new System.Drawing.Point(9, 35);
            this.feetLabel.Name = "feetLabel";
            this.feetLabel.Size = new System.Drawing.Size(34, 13);
            this.feetLabel.TabIndex = 3;
            this.feetLabel.Text = "FEET";
            // 
            // inchesLabel
            // 
            this.inchesLabel.AutoSize = true;
            this.inchesLabel.Location = new System.Drawing.Point(9, 74);
            this.inchesLabel.Name = "inchesLabel";
            this.inchesLabel.Size = new System.Drawing.Size(47, 13);
            this.inchesLabel.TabIndex = 4;
            this.inchesLabel.Text = "INCHES";
            this.inchesLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // inchesBox
            // 
            this.inchesBox.Location = new System.Drawing.Point(12, 90);
            this.inchesBox.Name = "inchesBox";
            this.inchesBox.Size = new System.Drawing.Size(119, 20);
            this.inchesBox.TabIndex = 5;
            this.inchesBox.TextChanged += new System.EventHandler(this.inchesBox_TextChanged);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(12, 186);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(260, 63);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "CONVERT!!";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // convertedOutput
            // 
            this.convertedOutput.Location = new System.Drawing.Point(12, 160);
            this.convertedOutput.Name = "convertedOutput";
            this.convertedOutput.Size = new System.Drawing.Size(121, 20);
            this.convertedOutput.TabIndex = 7;
            this.convertedOutput.TextChanged += new System.EventHandler(this.convertedOutput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(30, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "RESULTS";
            // 
            // developers
            // 
            this.developers.AutoSize = true;
            this.developers.Location = new System.Drawing.Point(124, 252);
            this.developers.Name = "developers";
            this.developers.Size = new System.Drawing.Size(155, 13);
            this.developers.TabIndex = 10;
            this.developers.Text = "CC 2016 Steven and Dani v1.0";
            // 
            // fruitPicture
            // 
            this.fruitPicture.Location = new System.Drawing.Point(151, 51);
            this.fruitPicture.Name = "fruitPicture";
            this.fruitPicture.Size = new System.Drawing.Size(121, 129);
            this.fruitPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fruitPicture.TabIndex = 9;
            this.fruitPicture.TabStop = false;
            this.fruitPicture.Click += new System.EventHandler(this.fruitPicture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 267);
            this.Controls.Add(this.developers);
            this.Controls.Add(this.fruitPicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convertedOutput);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.inchesBox);
            this.Controls.Add(this.inchesLabel);
            this.Controls.Add(this.feetLabel);
            this.Controls.Add(this.feetBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.typeOfFruitBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Fruit Measure";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fruitPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeOfFruitBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox feetBox;
        private System.Windows.Forms.Label feetLabel;
        private System.Windows.Forms.Label inchesLabel;
        private System.Windows.Forms.TextBox inchesBox;
        private System.Windows.Forms.Button convertButton;
        public System.Windows.Forms.TextBox convertedOutput;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox fruitPicture;
        private System.Windows.Forms.Label developers;
    }
}

