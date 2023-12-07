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

namespace Ex6
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
            int usableNo;
            bool parsed = Int32.TryParse(input.Text, out usableNo);
            if(!parsed || 0 >= usableNo)
            {
                output.Text = "";
                return;
            }
            Evaluator(usableNo);
        }

        public void Evaluator(int num)
        {
            if(num % 2 == 0)
            {
                output.Text = "Number is even";
                output.Background = Brushes.Green;
                output.Foreground = Brushes.Cyan;
            } else
            {
                output.Text = "Number is odd";
                output.Background = Brushes.Red;
                output.Foreground = Brushes.Yellow;
            }
        }
    }
}
