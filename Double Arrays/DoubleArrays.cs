/* Programmer: Austin Parker
   Date: March 14th, 2020
   Purpose: This program creates three arrays to display in a pop up window
 */
using System.Windows.Forms;
using System;


namespace Double_Arrays
{
    class DoubleArrays
    {
        static void Main()
        {
            //Creation of two arrays with different number of elements
            double[] one = { 8, 3 };
            double[] two = { 10, 2, 14 };


            // Multiplies first two arrays, then multiplies by 1
            double[] three = { one[0] * two[0] * 1, one[1] * two[1], two[2] * 1 };

            foreach (var total in three)
            {
                string oneValue = Convert.ToString(one);
                oneValue = string.Join(" , ", one);

                string twoValue = Convert.ToString(two);
                twoValue = string.Join(" , ", two);

                string threeValue = Convert.ToString(three);
                threeValue = string.Join(" , ", three);

                //Displays results of arrays
                MessageBox.Show("First Array: " + oneValue + Environment.NewLine +
                                "\nSecond Array: " + twoValue + Environment.NewLine +
                                "\nThird Array: " + threeValue);
                //Thank you message
                if (MessageBox.Show("Thanks for displaying Double Arrays !") == DialogResult.OK)
                {
                    break;
                }
            }

        }

    }
}






