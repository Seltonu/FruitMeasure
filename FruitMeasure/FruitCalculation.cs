using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitMeasure
{
    public class FruitCalculation
    {

        Fruits fruits = new Fruits();
        //run the calculation method, divide human height by fruit height
        public double calculation(int height, double fruit)
        {
            double answer;
            answer = Convert.ToDouble(height) / fruit;
            return Math.Round(answer, 2); //sanitize output slightly to two decimal places. Avoids super long answers.
        }

        public double selectedFruit(int index)
        {
            double fruitHeight = 0;
            //Form1 Form1 = new Form1();
           // form = System.Windows.Forms.Form.ActiveForm;

            switch(index)
            {
                case 0: //Apple
                    fruitHeight = fruits.apple;
                    //Form1.convertedOutput.Text += " worked";
                    //fruitPicture.Image = apple.png;
                    break;
                case 1: //Avocado
                    fruitHeight = fruits.avocado;
                    break;
                case 2: //Banana
                    fruitHeight = fruits.banana;
                    break;
                case 3: //Blueberry
                    fruitHeight = fruits.blueberry;
                    break;
                case 4: //Coconut
                    fruitHeight = fruits.coconut;
                    break;
                case 5: //Grape
                    fruitHeight = fruits.grape;
                    break;
                case 6: //Kiwi
                    fruitHeight = fruits.kiwi;
                    break;
                case 7: //Orange
                    fruitHeight = fruits.orange;
                    break;
                case 8: //Pear
                    fruitHeight = fruits.pear;
                    break;
                case 9: //Pineapple
                    fruitHeight = fruits.pineapple;
                    break;
                case 10: //Watermelon
                    fruitHeight = fruits.watermelon;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("Somehow, you selected an index out of bounds. How'd you do that? Let me know.");
                    break;
            }

            return fruitHeight;
        }

       // public static void testButt(Form1 form)
        //{
            //form.convertedOutput.Text += " worked";
       // }
    }
}
