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
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.NumPad7 || e.Key == Key.D7)
            {
                label_value.Content += "7";
            }
        }
        private void seven_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "7";
        }



        private void addition_Click(object sender, RoutedEventArgs e)
        {
            result = variableA + variableB;
            label_value.Content = "";
            label_value.Content += result.ToString();
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "7";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "7";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "7";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "7";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "7";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "7";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "7";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "7";
        }

        private void idk_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "7";
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "7";
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "7";
        }

        private void subtraction_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "7";
        }

        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "7";
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            label_value.Content += "7";
        }
    }
}
