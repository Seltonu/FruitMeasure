﻿namespace FruitMeasure
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
            this.typeOfFruitBox = new System.Windows.Forms.ComboBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.feetBox = new System.Windows.Forms.TextBox();
            this.feetLabel = new System.Windows.Forms.Label();
            this.inchesLabel = new System.Windows.Forms.Label();
            this.inchesBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.convertedOutput = new System.Windows.Forms.TextBox();
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
            this.heightLabel.Location = new System.Drawing.Point(41, 15);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(48, 13);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "HEIGHT";
            this.heightLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // feetBox
            // 
            this.feetBox.Location = new System.Drawing.Point(12, 76);
            this.feetBox.Name = "feetBox";
            this.feetBox.Size = new System.Drawing.Size(119, 20);
            this.feetBox.TabIndex = 2;
            this.feetBox.TextChanged += new System.EventHandler(this.feetBox_TextChanged);
            // 
            // feetLabel
            // 
            this.feetLabel.AutoSize = true;
            this.feetLabel.Location = new System.Drawing.Point(12, 51);
            this.feetLabel.Name = "feetLabel";
            this.feetLabel.Size = new System.Drawing.Size(34, 13);
            this.feetLabel.TabIndex = 3;
            this.feetLabel.Text = "FEET";
            // 
            // inchesLabel
            // 
            this.inchesLabel.AutoSize = true;
            this.inchesLabel.Location = new System.Drawing.Point(12, 121);
            this.inchesLabel.Name = "inchesLabel";
            this.inchesLabel.Size = new System.Drawing.Size(47, 13);
            this.inchesLabel.TabIndex = 4;
            this.inchesLabel.Text = "INCHES";
            this.inchesLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // inchesBox
            // 
            this.inchesBox.Location = new System.Drawing.Point(12, 146);
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
            this.convertedOutput.Location = new System.Drawing.Point(151, 146);
            this.convertedOutput.Name = "convertedOutput";
            this.convertedOutput.Size = new System.Drawing.Size(121, 20);
            this.convertedOutput.TabIndex = 7;
            this.convertedOutput.TextChanged += new System.EventHandler(this.convertedOutput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.convertedOutput);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.inchesBox);
            this.Controls.Add(this.inchesLabel);
            this.Controls.Add(this.feetLabel);
            this.Controls.Add(this.feetBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.typeOfFruitBox);
            this.Name = "Form1";
            this.Text = "Fruit Measure";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox convertedOutput;
    }
}

