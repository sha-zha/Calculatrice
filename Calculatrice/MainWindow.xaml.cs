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

        public MainWindow()
        {
            InitializeComponent();
        }


        public void RunInteger(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            input2.Text += (string)btn.Content; 
        }

        public void RunClear(object sender, EventArgs e)
        {
            input.Text = "";
            input2.Text = "";
        }

        public void RunOperator(object sender, EventArgs e)
        {
            Button btn = sender as Button;
           
            input.Text += input2.Text + (string) btn.Content;
        }

        public void RunAddRun (object sender, EventArgs e)
        {
            
            double num1, num2;
            double.TryParse(input.Text, out num1); 

            if(input.Text.Contains('+') )
            {
             
            }

        }

    }
}
