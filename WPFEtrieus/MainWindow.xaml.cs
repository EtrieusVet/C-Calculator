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
        float variableA;
        float variableB;

        float result;
        string numOperator;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculation()
        {
            variableB = (float)Convert.ToDecimal(userInputContainer.Content);
            switch (numOperator)
            {
                case "addition":
                    result = variableA + variableB;
                    displayContainer.Content = $"{variableA} + {variableB} =";
                    variableA = result;
                    break;

                case "subtraction":
                    result = variableA - variableB;
                    displayContainer.Content = $"{variableA} - {variableB} =";
                    variableA = result;
                    break;

                case "multiplication":
                    result = variableA * variableB;
                    displayContainer.Content = $"{variableA} * {variableB}  =";
                    variableA = result;
                    break;

                case "division":
                    result = variableA / variableB;
                    displayContainer.Content = $"{variableA} / {variableB} =";
                    variableA = result;
                    break;
            }
            userInputContainer.Content = "";
            resultContainer.Content = "";
            resultContainer.Content += Convert.ToString(result);
        }
        private void Clear()
        {
            userInputContainer.Content = "";
            displayContainer.Content = "";
            resultContainer.Content = "";
        }
        private bool DecimalChecker()
        {
            
            if (userInputContainer.Content != null)
            {
                return userInputContainer.Content.ToString().Contains(".");  
            }
            else
            {
                userInputContainer.Content += "0";
            }
            return false;
        }
        private void KeyPressAddition()
        {
            if (Convert.ToDecimal(userInputContainer.Content == "" ? 0 : userInputContainer.Content) != 0)
            {
                variableA = (float)Convert.ToDecimal(userInputContainer.Content);
            }
            userInputContainer.Content = "";
            displayContainer.Content = $"{variableA} +";
            numOperator = "addition";
        }
        private void KeyPressSubtraction()
        {
            if (Convert.ToDecimal(userInputContainer.Content == "" ? 0 : userInputContainer.Content) != 0)
            {
                variableA = (float)Convert.ToDecimal(userInputContainer.Content);
            }
            userInputContainer.Content = "";
            displayContainer.Content = $"{variableA} -";
            numOperator = "subtraction";
        }

        private void KeyPressMultiplication()
        {
            if (Convert.ToDecimal(userInputContainer.Content == "" ? 0 : userInputContainer.Content) != 0)
            {
                variableA = (float)Convert.ToDecimal(userInputContainer.Content);
            }
            userInputContainer.Content = "";
            displayContainer.Content = $"{variableA} *";
            numOperator = "multiplication";
        }

        private void KeyPressDivision()
        {
            if (Convert.ToDecimal(userInputContainer.Content == "" ? 0 : userInputContainer.Content) != 0)
            {
                variableA = (float)Convert.ToDecimal(userInputContainer.Content);
            }
            userInputContainer.Content = "";
            displayContainer.Content = $"{variableA} /";
            numOperator = "division";
        }
        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            
            switch (e.Key)
            {
                case Key.NumPad0:
                case Key.D0:
                    userInputContainer.Content += "0";
                    break;

                case Key.NumPad1:
                case Key.D1:
                    userInputContainer.Content += "1";
                    break;

                case Key.NumPad2:
                case Key.D2:
                    userInputContainer.Content += "2";
                    break;

                case Key.NumPad3:
                case Key.D3:
                    userInputContainer.Content += "3";
                    break;

                case Key.NumPad4:
                case Key.D4:
                    userInputContainer.Content += "4";
                    break;

                case Key.NumPad5:
                case Key.D5:
                    userInputContainer.Content += "5";
                    break;

                case Key.NumPad6:
                case Key.D6:
                    userInputContainer.Content += "6";
                    break;

                case Key.NumPad7:
                case Key.D7:
                    userInputContainer.Content += "7";
                    break;

                case Key.NumPad8:
                case Key.D8:
                    userInputContainer.Content += "8";
                    break;

                case Key.NumPad9:
                case Key.D9:
                    userInputContainer.Content += "9";
                    break;

                case Key.Add:
                case Key.OemPlus:
                    KeyPressAddition();
                    break;

                case Key.Subtract:
                case Key.OemMinus:
                    KeyPressSubtraction();
                    break;

                case Key.Multiply:
                    KeyPressMultiplication();
                    break;

                case Key.Divide:
                    KeyPressDivision();
                    break;

                case Key.OemPeriod:
                    if (DecimalChecker())
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        userInputContainer.Content += ".";
                    }
                    break;

                case Key.Back:
                    Clear();
                    break;

                case Key.Enter:
                    Calculation();
                    break;
            }
            
            e.Handled=true;
            //if (e.Key == Key.NumPad7 || e.Key == Key.D7)
            //{
            //    label_value.Content += "7";
            //}
        }
        private void seven_Click(object sender, RoutedEventArgs e)
        {
            userInputContainer.Content += "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            userInputContainer.Content += "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            userInputContainer.Content += "9";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            userInputContainer.Content += "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            userInputContainer.Content += "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            userInputContainer.Content += "6";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            userInputContainer.Content += "3";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            userInputContainer.Content += "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            userInputContainer.Content += "2";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }
        private void zero_Click(object sender, RoutedEventArgs e)
        {
            userInputContainer.Content += "0";
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            Calculation();
        }

        private void decimals_Click(object sender, RoutedEventArgs e)
        {
            if (DecimalChecker())
            {
                e.Handled = true;
            }
            else
            {
                userInputContainer.Content += ".";
            }
        }
        private void addition_Click(object sender, RoutedEventArgs e)
        {
            KeyPressAddition();
        }
        private void subtraction_Click(object sender, RoutedEventArgs e)
        {
            KeyPressSubtraction();
        }

        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            KeyPressMultiplication();
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            KeyPressDivision();
        }
    }
}
