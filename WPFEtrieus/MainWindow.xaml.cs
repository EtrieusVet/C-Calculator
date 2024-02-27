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

        private void Calculation()
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
            result_container.Content = "";
            result_container.Content += Convert.ToString(result);
        }
        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            
            switch (e.Key)
            {
                case Key.NumPad0:
                case Key.D0:
                    result_container.Content += "0";
                    break;

                case Key.NumPad1:
                case Key.D1:
                    result_container.Content += "1";
                    break;

                case Key.NumPad2:
                case Key.D2:
                    result_container.Content += "2";
                    break;

                case Key.NumPad3:
                case Key.D3:
                    result_container.Content += "3";
                    break;

                case Key.NumPad4:
                case Key.D4:
                    result_container.Content += "4";
                    break;

                case Key.NumPad5:
                case Key.D5:
                    result_container.Content += "5";
                    break;

                case Key.NumPad6:
                case Key.D6:
                    result_container.Content += "6";
                    break;

                case Key.NumPad7:
                case Key.D7:
                    result_container.Content += "7";
                    break;

                case Key.NumPad8:
                case Key.D8:
                    result_container.Content += "8";
                    break;

                case Key.NumPad9:
                case Key.D9:
                    result_container.Content += "9";
                    break;

                case Key.Add:
                case Key.OemPlus:
                    variableA = Convert.ToInt64(result_container.Content);
                    result_container.Content = "";
                    numOperator = "addition";
                    break;

                case Key.Subtract:
                case Key.OemMinus:
                    variableA = Convert.ToInt64(result_container.Content);
                    result_container.Content = "";
                    numOperator = "subtraction";
                    break;

                case Key.Multiply:

                    variableA = Convert.ToInt64(label_value.Content);
                    result_container.Content = "";
                    numOperator = "multiplication";
                    break;

                case Key.Divide:
                    variableA = Convert.ToInt64(label_value.Content);
                    result_container.Content = "";
                    numOperator = "division";
                    break;

                case Key.Back:
                    result_container.Content = "";
                    break;

                case Key.Enter:
                    Calculation();
                    break;
            }
            
            
            //if (e.Key == Key.NumPad7 || e.Key == Key.D7)
            //{
            //    label_value.Content += "7";
            //}
        }
        private void seven_Click(object sender, RoutedEventArgs e)
        {
            result_container.Content += "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            result_container.Content += "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            result_container.Content += "9";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            result_container.Content += "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            result_container.Content += "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            result_container.Content += "6";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            result_container.Content += "3";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            result_container.Content += "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            result_container.Content += "2";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            result_container.Content = "";
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            result_container.Content += "0";
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            Calculation();
        }

        private void addition_Click(object sender, RoutedEventArgs e)
        {
            variableA = Convert.ToInt64(result_container.Content);
            result_container.Content = "";
            numOperator = "addition";
        }
        private void subtraction_Click(object sender, RoutedEventArgs e)
        {
            variableA = Convert.ToInt64(result_container.Content);
            result_container.Content = "";
            numOperator = "subtraction";
        }

        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            variableA = Convert.ToInt64(result_container.Content);
            result_container.Content = "";
            numOperator = "multiplication";
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            variableA = Convert.ToInt64(result_container.Content);
            result_container.Content = "";
            numOperator = "division";
        }
    }
}
