using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int num1;

        public MainWindow()
        {
            InitializeComponent();
        }


        public void RunInteger(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(input.Text.EndsWith("="))
            {
                input.Text = "";
                input2.Text = "";
            }

            input2.Text += (string)btn.Content; 
        }

        public void RunClear(object sender, EventArgs e)
        {
            input.Text = "";
            input2.Text = "";
        }

        public void RunCE(object sender, EventArgs e)
        {
            if(input.Text.EndsWith("+") || input.Text.EndsWith("-") || input.Text.EndsWith("*") || input.Text.EndsWith("/") )
            {
                input2.Text = "";
            }
            else
            {
                input.Text = "";
                input2.Text = "";
            }
        }

        public void RunBack(object sender, EventArgs e)
        {
            string str = input2.Text;
            if (str.Length > 0)
            {
                input2.Text = str.Remove(str.Length - 1);
            }
            else
            {
                return;
            }
            

        }
        public void RunOperator(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (input.Text.EndsWith("+") || input.Text.EndsWith("-") || input.Text.EndsWith("*") || input.Text.EndsWith("/"))
            {
                return;
            }

            if (input.Text.EndsWith('=')) 
            {
                input.Text = "";
            }

            input.Text += input2.Text + (string) btn.Content;
        }

        public void RunNegatif(object sender, EventArgs e)
        {
            double num, nb;
            
            if (input2.Text.Length > 0)
            {
                double.TryParse(input2.Text, out num);

                nb = num*-1;
                input2.Text = nb.ToString();
            }
            
        }
        public void RunCalcule(object sender, EventArgs e)
        {

            if (input.Text.Contains('+'))
            {
                double num1,num2,result;
                //suprimmer opérateur
                input.Text = input.Text.Remove(input.Text.Length - 1);
                //conversion string to double
                double.TryParse(input.Text, out num1);
                double.TryParse(input2.Text, out num2);
                //calcule
                result = num1 + num2;
                //resultat
                input.Text = num1.ToString() + "+" + num2.ToString() + "="; 
                input2.Text = result.ToString();
            }
            if (input.Text.Contains('-'))
            {
                double num1, num2, result;
                //suprimmer opérateur
                input.Text = input.Text.Remove(input.Text.Length - 1);
                //conversion string to double
                double.TryParse(input.Text, out num1);
                double.TryParse(input2.Text, out num2);
                //calcule
                result = num1 - num2;
                //resultat
                input.Text = num1.ToString() + "-" + num2.ToString() + "=";
                input2.Text = result.ToString();
            }
            if (input.Text.Contains('*'))
            {
                double num1, num2, result;
                //suprimmer opérateur
                input.Text = input.Text.Remove(input.Text.Length - 1);
                //conversion string to double
                double.TryParse(input.Text, out num1);
                double.TryParse(input2.Text, out num2);
                //calcule
                result = num1 * num2;
                //resultat
                input.Text = num1.ToString() + "*" + num2.ToString() + "=";
                input2.Text = result.ToString();
            }
            if (input.Text.Contains('/'))
            {
                double num1, num2, result;
                //suprimmer opérateur
                input.Text = input.Text.Remove(input.Text.Length - 1);
                //conversion string to double
                double.TryParse(input.Text, out num1);
                double.TryParse(input2.Text, out num2);
                //calcule
                result = num1 / num2;
                //resultat
                input.Text = num1.ToString() + "/" + num2.ToString() + "=";
                input2.Text = result.ToString();
            }
        }
    }
}
