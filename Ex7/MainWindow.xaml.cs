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

namespace Ex7
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

        private void input_GotFocus(object sender, RoutedEventArgs e)
        {
            input.Text = "";
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            double usableNo;
            bool parsed = double.TryParse(input.Text, out usableNo);
            if (!parsed || -273.15 >= usableNo)
            {
                output.Text = "Temperature in Fahrenheit: ";
                return;
            }
            TempConverter(usableNo);
        }

        public void TempConverter(double num)
        {
            double fahrenheit = num * 9 / 5 + 32;
            output.Text = "Temperature in Fahrenheit: " + fahrenheit;
        }
    }
}
