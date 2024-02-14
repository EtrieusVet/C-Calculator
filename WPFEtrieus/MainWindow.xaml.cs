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

namespace WPFEtrieus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long variableA;
        long variableB;
        long result;
        string numOperator;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            
            switch (e.Key)
            {
                case Key.NumPad0:
                case Key.D0:
                    label_value.Content += "0";
                    break;

                case Key.NumPad1:
                case Key.D1:
                    label_value.Content += "1";
                    break;

                case Key.NumPad2:
                case Key.D2:
                    label_value.Content += "2";
                    break;

                case Key.NumPad3:
                case Key.D3:
                    label_value.Content += "3";
                    break;

                case Key.NumPad4:
                case Key.D4:
                    label_value.Content += "4";
                    break;

                case Key.NumPad5:
                case Key.D5:
                    label_value.Content += "5";
                    break;

                case Key.NumPad6:
                case Key.D6:
                    label_value.Content += "6";
                    break;

                case Key.NumPad7:
                case Key.D7:
                    label_value.Content += "7";
                    break;

                case Key.NumPad8:
                case Key.D8:
                    label_value.Content += "8";
                    break;

                case Key.NumPad9:
                case Key.D9:
                    label_value.Content += "9";
                    break;

                case Key.Add:
                    variableA = Convert.ToInt64(label_value.Content);
                    label_value.Content = "";
                    numOperator = "addition";
                    break;

                case Key.Subtract:
                    variableA = Convert.ToInt64(label_value.Content);
                    label_value.Content = "";
                    numOperator = "subtraction";
                    break;

                case Key.Multiply:
                    variableA = Convert.ToInt64(label_value.Content);
                    label_value.Content = "";
                    numOperator = "multiplication";
                    break;

                case Key.Divide:
                    variableA = Convert.ToInt64(label_value.Content);
                    label_value.Content = "";
                    numOperator = "division";
                    break;

                case Key.Back:
                    label_value.Content = "";
                    break;

                case Key.Enter:
                    variableB = Convert.ToInt64(label_value.Content);
                    switch (numOperator)
                    {
                        case "addition":
                            result = variableA + variableB;
                            break;

                        case "subtraction":
                            result = variableA - variableB;
                            break;

                        case "multiplication":
                            result = variableA * variableB;
                            break;

                        case "division":
                            result = variableA / variableB;
                            break;
                    }
                    label_value.Content = "";
                    label_value.Content += Convert.ToString(result);
                    break;
            }
            
            
            //if (e.Key == Key.NumPad7 || e.Key == Key.D7)
            //{
            //    label_value.Content += "7";
            //}
        }
        private void seven_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "9";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "6";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "3";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "2";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content = "";
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "0";
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            variableB = Convert.ToInt64(label_value.Content);
            switch (numOperator)
            {
                case "addition":
                    result = variableA + variableB;
                    break;

                case "subtraction":
                    result = variableA - variableB;
                    break;

                case "multiplication":
                    result = variableA * variableB;
                    break;

                case "division":
                    result = variableA / variableB;
                    break;
            }
            label_value.Content = "";
            label_value.Content += Convert.ToString(result);
        }

        private void addition_Click(object sender, RoutedEventArgs e)
        {
            variableA = Convert.ToInt64(label_value.Content);
            label_value.Content = "";
            numOperator = "addition";
        }
        private void subtraction_Click(object sender, RoutedEventArgs e)
        {
            variableA = Convert.ToInt64(label_value.Content);
            label_value.Content = "";
            numOperator = "subtraction";
        }

        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            variableA = Convert.ToInt64(label_value.Content);
            label_value.Content = "";
            numOperator = "multiplication";
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            variableA = Convert.ToInt64(label_value.Content);
            label_value.Content = "";
            numOperator = "division";
        }
    }
}