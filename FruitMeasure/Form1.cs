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
        //Initialize a calculation object to call on button press
        FruitCalculation fc = new FruitCalculation();
        double totalInchesFruit; //initialize this variable here so typeOfFruitBox and the button can both access it
        int pictureClicked = 0; //For mandatory easter egg

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] fruitTypes = { "Apple", "Avocado", "Banana", "Blueberry", "Coconut",
                "Grape", "Kiwi", "Orange", "Pear", "Pineapple", "Watermelon" };
            typeOfFruitBox.Items.AddRange(fruitTypes);
            typeOfFruitBox.SelectedIndex = 0;
            
            fruitPicture.Image = FruitMeasure.Properties.Resources.apple;

        }

        private void typeOfFruitBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fruitPicture.Image = apple;
            totalInchesFruit = fc.selectedFruit(typeOfFruitBox.SelectedIndex);
            fruitPicture.Image = FruitMeasure.Properties.Resources.banana;


            switch (typeOfFruitBox.SelectedIndex)
            {
                case 0: //Apple
                    fruitPicture.Image = FruitMeasure.Properties.Resources.apple;
                    break;
                case 1: //Avocado
                    fruitPicture.Image = FruitMeasure.Properties.Resources.avocado;
                    break;
                case 2: //Banana
                    fruitPicture.Image = FruitMeasure.Properties.Resources.banana;
                    break;
                case 3: //Blueberry
                    fruitPicture.Image = FruitMeasure.Properties.Resources.blueberry;
                    break;
                case 4: //Coconut
                    fruitPicture.Image = FruitMeasure.Properties.Resources.coconut;
                    break;
                case 5: //Grape
                    fruitPicture.Image = FruitMeasure.Properties.Resources.grapes;
                    break;
                case 6: //Kiwi
                    fruitPicture.Image = FruitMeasure.Properties.Resources.kiwi;
                    break;
                case 7: //Orange
                    fruitPicture.Image = FruitMeasure.Properties.Resources.orange;
                    break;
                case 8: //Pear
                    fruitPicture.Image = FruitMeasure.Properties.Resources.pear;
                    break;
                case 9: //Pineapple
                    fruitPicture.Image = FruitMeasure.Properties.Resources.pineapple;
                    break;
                case 10: //Watermelon
                    fruitPicture.Image = FruitMeasure.Properties.Resources.watermelon;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("Somehow, you selected an index out of bounds. How'd you do that? Let me know.");
                    break;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void feetBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inchesBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void convertedOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int feetInInches = 0;
            int inches = 0;

            try
            {
                if (feetBox.Text != "")
                {
                    feetInInches = int.Parse(feetBox.Text) * 12;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid number for feet.");
            }

            try
            {
                if (inchesBox.Text != "")
                {
                    inches = int.Parse(inchesBox.Text);
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid number for inches.");
            }

            int totalInchesHeight = feetInInches + inches;
            //convertedOutput.Text = totalInchesHeight.ToString();
            convertedOutput.Text = Convert.ToString(fc.calculation(totalInchesHeight, totalInchesFruit));

            //Add the name of the fruit after the converted number, for clarity.
            string selectedFruit = Convert.ToString(typeOfFruitBox.SelectedItem);
            convertedOutput.Text += (" " + selectedFruit);

           // fc.testButt();
            //fc.selectedFruit(typeOfFruitBox.SelectedIndex, this);
        }

        public void fruitPicture_Click(object sender, EventArgs e)
        {
            // fruitPicture.Image
            pictureClicked += 1;

            if (pictureClicked >= 10)
            {
                developers.Text = "CC 2016 NICK and NICK v1.0";
            }
        }

        
    }

}
