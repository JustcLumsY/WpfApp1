using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
     
        private double firstNumber;
        private double secoundNumber;
        private double resultNumber;
        private bool btnClicked = false;
       


        public MainWindow()
        {
            InitializeComponent();
        }


        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            CountLabel.Content = "-";
            btnClicked = false;
            resultNumber = firstNumber - secoundNumber;
            CountLabel.Content = resultNumber.ToString();
        }

        private void Pluss_Click(object sender, RoutedEventArgs e)
        {
            CountLabel.Content = "+";
            btnClicked = true;
            resultNumber = firstNumber + secoundNumber;
            CountLabel.Content = resultNumber.ToString();
        }

      

        public void Equals_Click(object sender, RoutedEventArgs e)
        {
            if (btnClicked)
            {
                Pluss_Click(sender,e);
            }
            if (!btnClicked)
            {
                Minus_Click(sender, e);
            }
        }


        private void One_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = 1;
            CountLabel.Content = firstNumber;
        }
     

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            secoundNumber = 2;
            CountLabel.Content = secoundNumber;
           
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
        }

      
    }
}
