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

namespace Ex4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _big = false;
        private int _firstNo = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void gameStart_Click(object sender, RoutedEventArgs e)
        {
            _firstNo = InitialDisplayChange();
            selectBig.IsEnabled = true;
            selectSmall.IsEnabled = true;
        }

        public int InitialDisplayChange()
        {
            Random rnd = new Random();
            int displayed = rnd.Next(1, 21);
            firstNumber.Text = "Initial Number: " + displayed.ToString();
            return displayed;
        }

        private void selectBig_Click(object sender, RoutedEventArgs e)
        {
            _big = true;
            guess.IsEnabled = true;
        }

        private void selectSmall_Click(object sender, RoutedEventArgs e)
        {
            _big = false;
            guess.IsEnabled = true;
        }

        private void guess_Click(object sender, RoutedEventArgs e)
        {
            int selection = SecondDisplayChange(_firstNo);
            EvaluateWin(selection);
        }

        public int SecondDisplayChange(int prevNumber)
        {
            Random rand = new Random();
            int selectedNumber;
            do
            {
                selectedNumber = rand.Next(1, 21);
            } while (selectedNumber == prevNumber);
            secondNumber.Text = "Second Number: " + selectedNumber.ToString();
            return selectedNumber;
        }

        public void EvaluateWin(int prevNumber)
        {
            if((_big == true && prevNumber > _firstNo) || (_big == false && prevNumber < _firstNo))
            {
                display.Text = "You won!";
            } else
            {
                display.Text = "You lost!";
            }
        }
    }
}
