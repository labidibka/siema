using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Egzamin_Probny_WPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int liczba_znakow = int.Parse(znaki.Text);

            Random random = new Random();
            string[] tablica = new string[liczba_znakow];
            string[] litery = { "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM" };
            string[] liczby = { "0123456789" };
            string[] specjalne = {"!@#$%^&*()_+-="};

            for (int i = 0; i < tablica.Length; i++) 
            {
                if (Wielkie_male.IsChecked == true && Cyfry.IsChecked == false && Specjalne.IsChecked == false )
                {
                    tablica[0] = litery[random.Next(0, litery.Length)];
                }
                else if (Cyfry.IsChecked == true && Wielkie_male.IsChecked == false && Specjalne.IsChecked == false) 
                {
                    tablica[1] = liczby[random.Next(0, liczby.Length)];
                }
                else if (Specjalne.IsChecked == true && Cyfry.IsChecked == false && Wielkie_male.IsChecked == false) 
                {
                    tablica[2] = specjalne[random.Next(0, specjalne.Length)];
                }
            }

            MessageBox.Show($"Losowe Hasło Wynosi: {tablica[2]} ");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            MessageBox.Show($"Witaj! {imie.Text}, {Nazwisko.Text},{stanowisko.SelectedItem}");
        }
    }
}