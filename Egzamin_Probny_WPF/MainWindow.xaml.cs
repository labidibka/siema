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
            Random random = new Random();
            int[] tablica = new int[10];
            string[] litery = { "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM" };
            string[] liczby = { "0123456789" };
            string[] specjalne = {"!@#$%^&*()_+-="};

            for (int i = 0; i < tablica.Length; i++) 
            {
                int losowa = random.Next(0, 10);
                tablica[i] = losowa;
            }

            MessageBox.Show($"Losowe Hasło Wynosi: {tablica} ");
        }
    }
}