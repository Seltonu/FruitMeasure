using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitMeasure
{
    public partial class Form1 : Form
    {

        FruitCalculation fc = new FruitCalculation();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] fruitTypes = { "Apple", "Avocado", "Banana", "Blueberry",
                "Coconut", "Grape", "Kiwi", "Orange", "Pear", "Pineapple", "Watermelon"};
            //typeOfFruitBox.Items.AddRange("Apple", "Banana", "Orange", "Grape");
            typeOfFruitBox.Items.AddRange(fruitTypes);
            typeOfFruitBox.SelectedIndex = 0;
            
        }

        private void typeOfFruitBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void feetBox_TextChanged(object sender, EventArgs e)
        {
            //int feetInInches = int.Parse(feetBox.Text) / 12; //TODO use float not int
        }

        private void inchesBox_TextChanged(object sender, EventArgs e)
        {
            //int inches = int.Parse(feetBox.Text);
        }

        private void convertedOutput_TextChanged(object sender, EventArgs e)
        {
            //convertedOutput.Text = inchesBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int feetInInches = 0;
            int inches = 0;

            try
            {
                feetInInches = int.Parse(feetBox.Text) * 12;
                inches = int.Parse(inchesBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid number for height.");
            }

            int totalInchesHeight = feetInInches + inches;
            //convertedOutput.Text = totalInchesHeight.ToString();

            if (totalInchesHeight > 0) //little bit of cleanup, won't output a zero anymore when the user enters nothing
            {
                convertedOutput.Text = Convert.ToString(fc.calculation(totalInchesHeight, fc.selectedFruit(typeOfFruitBox.SelectedIndex)));
                convertedOutput.Text += (" " + typeOfFruitBox.Text);
            }

            //int selectedFruit = typeOfFruitBox.SelectedIndex; //WE DON'T ACTUALLY NEED TO STORE THIS
            //convertedOutput.Text = selectedFruit;
        }

    }
}
