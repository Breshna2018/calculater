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

namespace calculater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window


    {
        static int[] numbersArray = new int[10];
        static string[] operatorsArray = new string[9];

        static string storageVariable;
        static int numbersCounter = 0;
        static int operatorsCounter = 0;
        static int total = 0;
        static bool totalled = false;
        static int setnumber = 0;
        static int set = 10;
        static int num3 = 15;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void clearall_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = "";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (totalled == true)
            {
                Display.Content = "";
                totalled = false;
            }
            Display.Content += "1";
            storageVariable += "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (totalled == true)
            {
                Display.Content = "";
                totalled = false;
            }
            Display.Content += "2";
            storageVariable += "2";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (totalled == true)
            {
                Display.Content = "";
                totalled = false;
            }
            Display.Content += "3";
            storageVariable += "3";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (totalled == true)
            {
                Display.Content = "";
                totalled = false;
            }
            Display.Content += "4";
            storageVariable += "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (totalled == true)
            {
                Display.Content = "";
                totalled = false;
            }
            Display.Content += "5";
            storageVariable += "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (totalled == true)
            {
                Display.Content = "";
                totalled = false;
            }
            Display.Content += "6";
            storageVariable += "6";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (totalled == true)
            {
                Display.Content = "";
                totalled = false;
            }
            Display.Content += "7";
            storageVariable += "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (totalled == true)
            {
                Display.Content = "";
                totalled = false;
            }
            Display.Content += "8";
            storageVariable += "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (totalled == true)
            {
                Display.Content = "";
                totalled = false;
            }
            Display.Content += "9";
            storageVariable += "9";
        }

        private void zario_Click(object sender, RoutedEventArgs e)
        {
            if (totalled == true)
            {
                Display.Content = "";
                totalled = false;
            }
            Display.Content += "0";
            storageVariable += "0";
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {

            setNumber(storageVariable);
            setOperator("+");
            Display.Content += "+";

        }
        static void setNumber(String Number)
        {
            numbersArray[numbersCounter] = Convert.ToInt16(Number);
            storageVariable = null;
            numbersCounter++;
        }
        static void setOperator(String Op)
        {
            operatorsArray[operatorsCounter] = Op;
            operatorsCounter++;
        }

        private void subtract_Click(object sender, RoutedEventArgs e)
        {
            setNumber(storageVariable);
            setOperator("-");
            Display.Content += "-";
        }

        private void clearmain_Click(object sender, RoutedEventArgs e)
        {
            Display.Content = "";
            numbersArray = null;
            operatorsArray = null;
            storageVariable = null;
            numbersCounter = 0;
            operatorsCounter = 0;
            total = 0;
        }

        private void minuse_Click(object sender, RoutedEventArgs e)
        {
            setNumber(storageVariable);
            setOperator("*");
            Display.Content += "*";
        }

        private void divided_Click(object sender, RoutedEventArgs e)
        {
            setNumber(storageVariable);
            setOperator("/");
            Display.Content += "/";
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            setNumber(storageVariable);
            for (int i = 0; i < operatorsCounter; i++)
            {
                if (operatorsArray[i] == "+" && i == 0)
                {
                    total = numbersArray[i] + numbersArray[i + 1];
                }
                else if (operatorsArray[i] == "+")
                {
                    total = total + numbersArray[i + 1];
                }
                else if (operatorsArray[i] == "-" && i == 0)
                {
                    total = numbersArray[i] - numbersArray[i + 1];
                }
                else if (operatorsArray[i] == "-")
                {
                    total = total - numbersArray[i + 1];
                }
                else if (operatorsArray[i] == "*" && i == 0)
                {
                    total = numbersArray[i] * numbersArray[i + 1];
                }
                else if (operatorsArray[i] == "*")
                {
                    total = total * numbersArray[i + 1];
                }
                else if (operatorsArray[i] == "/" && i == 0)
                {
                    total = numbersArray[i] / numbersArray[i + 1];
                }
                else if (operatorsArray[i] == "/")
                {
                    total = total / numbersArray[i + 1];
                }
            }
            Display.Content = total;
            numbersArray = null;
            operatorsArray = null;
            storageVariable = null;
            numbersCounter = 0;
            operatorsCounter = 0;
            total = 0;
            totalled = true;
        }
    }
}