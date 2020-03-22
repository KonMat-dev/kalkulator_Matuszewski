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

namespace kalkulator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double liczba1 = 0;
        double liczba2 = 0;
        string operacja = "";
        string liczba;
        string liczbav2;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void siedem_Click(object sender, RoutedEventArgs e)
        {
            if (operacja == "" )
            {
                liczba = liczba + "7";
                ekran.Text = liczba;
                liczba1 = Convert.ToDouble(liczba);
            }
            else
            {
                liczbav2 = liczbav2 + "7";
                ekran.Text = liczbav2;
                liczba2 = Convert.ToDouble(liczbav2);
            }
            
        }

        private void jeden_Click(object sender, RoutedEventArgs e)
        {
            if (operacja == "")
            {
                liczba = liczba + "1";
                ekran.Text = liczba;
                liczba1 = Convert.ToDouble(liczba);
            }
            else
            {
                liczbav2 = liczbav2 + 1;
                ekran.Text = liczbav2;
                liczba2 = Convert.ToDouble(liczbav2);
            }

        }

        private void cztery_Click(object sender, RoutedEventArgs e)
        {

            if (operacja == "")
            {
                liczba = liczba + "4";
                ekran.Text = liczba;
                liczba1 = Convert.ToDouble(liczba);
            }
            else
            {
                liczbav2 = liczbav2 + 4;
                ekran.Text = liczbav2;
                liczba2 = Convert.ToDouble(liczbav2);
            }

        }

        private void osiem_Click(object sender, RoutedEventArgs e)
        {

            if (operacja == "")
            {
                liczba = liczba + "8";
                ekran.Text = liczba;
                liczba1 = Convert.ToDouble(liczba);
            }
            else
            {
                liczbav2 = liczbav2 + 8;
                ekran.Text = liczbav2;
                liczba2 = Convert.ToDouble(liczbav2);
            }

        }

        private void piec_Click(object sender, RoutedEventArgs e)
        {

            if (operacja == "")
            {
                liczba = liczba + "5";
                ekran.Text = liczba;
                liczba1 = Convert.ToDouble(liczba);
            }
            else
            {
                liczbav2 = liczbav2 + 5;
                ekran.Text = liczbav2;
                liczba2 = Convert.ToDouble(liczbav2);
            }


        }

        private void dwa_Click(object sender, RoutedEventArgs e)
        {

            if (operacja == "")
            {
                liczba = liczba + "2";
                ekran.Text = liczba;
                liczba1 = Convert.ToDouble(liczba);
            }
            else
            {
                liczbav2 = liczbav2 + 2;
                ekran.Text = liczbav2;
                liczba2 = Convert.ToDouble(liczbav2);
            }

        }

        private void dziewiec_Click(object sender, RoutedEventArgs e)
        {

            if (operacja == "")
            {
                liczba = liczba + "9";
                ekran.Text = liczba;
                liczba1 = Convert.ToDouble(liczba);
            }
            else
            {
                liczbav2 = liczbav2 + 9;
                ekran.Text = liczbav2;
                liczba2 = Convert.ToDouble(liczbav2);
            }

        }

        private void szesc_Click(object sender, RoutedEventArgs e)
        {

            if (operacja == "")
            {
                liczba = liczba + "6";
                ekran.Text = liczba;
                liczba1 = Convert.ToDouble(liczba);
            }
            else
            {
                liczbav2 = liczbav2 + 6;
                ekran.Text = liczbav2;
                liczba2 = Convert.ToDouble(liczbav2);
            }

        }

        private void trzy_Click(object sender, RoutedEventArgs e)
        {

            if (operacja == "")
            {
                liczba = liczba + "3";
                ekran.Text = liczba;
                liczba1 = Convert.ToDouble(liczba);
            }
            else
            {
                liczbav2 = liczbav2 + 3;
                ekran.Text = liczbav2;
                liczba2 = Convert.ToDouble(liczbav2);
            }

        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {

            if (operacja == "")
            {
                liczba = liczba + "0";
                ekran.Text = liczba;
                liczba1 = Convert.ToDouble(liczba);
            }
            else
            {
                liczbav2 = liczbav2 + 0;
                ekran.Text = liczbav2;
                liczba2 = Convert.ToDouble(liczbav2);
            }

        }

        private void kropka_Click(object sender, RoutedEventArgs e)
        {
            if (operacja == "")
            {
                liczba = liczba + ",";
                ekran.Text = liczba;
            }
            else
            {
                
                liczbav2 = liczbav2 + ",";
                ekran.Text = liczbav2;
                liczba2 = Convert.ToDouble(liczbav2);
            }
        }

        private void Lnawias_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Pnawias_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            operacja = "+";
            ekran.Text = "0".ToString();
             
         
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            operacja = "-";
            ekran.Text = "0".ToString();
        }

        private void mnozenie_Click(object sender, RoutedEventArgs e)
        {
            operacja = "*";
            ekran.Text = "0".ToString();
        }

        private void dzielenie_Click(object sender, RoutedEventArgs e)
        {
            operacja = "/";
            ekran.Text = "0".ToString();
        }

        private void rowna_Click(object sender, RoutedEventArgs e)
        {
            if (operacja == "+")
            {

                liczba1 = Convert.ToDouble(liczba);
                liczba2 = Convert.ToDouble(liczbav2);
                liczba1 = liczba1 + liczba2;
                ekran.Text = liczba1.ToString();
                liczba = liczba1.ToString();

            }

            else if (operacja == "-")
            {
                liczba1 = Convert.ToDouble(liczba);
                liczba2 = Convert.ToDouble(liczbav2);
                liczba1 = liczba1 - liczba2;
                ekran.Text = liczba1.ToString();
                liczba = liczba1.ToString();

            }
            else if (operacja == "*")
            {
                liczba1 = Convert.ToDouble(liczba);
                liczba2 = Convert.ToDouble(liczbav2);
                liczba1 = liczba1 * liczba2;
                ekran.Text = liczba1.ToString();
                liczba = liczba1.ToString();

            }
            else if (operacja == "/")
            {

                if (liczba2 != 0)
                {

                    liczba1 = liczba1 / liczba2;
                    ekran.Text = liczba1.ToString();
                    liczba = liczba1.ToString();


                }

                else
                {

                    ekran.Text = "Nie dzielimy przez zero !";
                }


            }

            else if (operacja == "potegadoy")
            {
                liczba1 = Math.Pow(liczba1, liczba2);
                ekran.Text = liczba1.ToString();
                liczba = liczba1.ToString();
            }

            else if (operacja == "log")
            {
                liczba1 = Math.Log(liczba1);
                ekran.Text = liczba1.ToString();
                liczba = liczba1.ToString();
            }

            liczba2 = 0;
            liczbav2 = "";
            operacja = "";
        }       
        

        private void usun_Click(object sender, RoutedEventArgs e)
        {
            liczba = "";
            liczbav2 = "";
            liczba2 = 0;
            liczba1 = 0;
            ekran.Text = "";
            operacja = "";
        }

        private void znak_odwrotny_Click(object sender, RoutedEventArgs e)
        {
            if (operacja == "")
            {
                liczba1 = Convert.ToDouble(liczba);
                liczba1 *= -1;
                ekran.Text = liczba1.ToString();
                liczba = liczba1.ToString();
                
            }
            else
            {
                liczba2 = Convert.ToDouble(liczbav2);
                liczba2 *= -1;
                ekran.Text = liczba2.ToString();
            }
        }

        private void pierwiastek_Click(object sender, RoutedEventArgs e)
        {

            liczba1 = Convert.ToDouble(liczba);
            liczba1 = Math.Sqrt(liczba1);
            ekran.Text = liczba1.ToString();
            
        }

        private void pierwiastek_Copy_Click(object sender, RoutedEventArgs e)
        {
            liczba1 = Convert.ToDouble(liczba);
            liczba1 = liczba1*liczba1;
            ekran.Text = liczba1.ToString();

        }

        private void potegadoy_Click(object sender, RoutedEventArgs e)
        {
            operacja = "potegadoy";
            liczba1 = Convert.ToDouble(liczba);
            liczba2 = Convert.ToDouble(liczbav2);
           
        }

       
    }
}
