﻿using System;
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
                input.Text = input.Text.Remove(input.Text.Length - 1);
            }
            

        }

            public void RunOperator(object sender, EventArgs e)
        {
            Button btn = sender as Button;
           
            input.Text += input2.Text + (string) btn.Content;
        }

        public void RunAddRun (object sender, EventArgs e)
        {

            if(input.Text.Contains('+') )
            {
             
            }

        }

    }
}
