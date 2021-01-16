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

namespace Plappy_v1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool toggle = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Aanwezig(object sender, RoutedEventArgs e)
        {
            aanwezigheden aanwezigheden = new aanwezigheden();
            this.Close();
            aanwezigheden.Show();
        }

        private void Btn_Leden(object sender, RoutedEventArgs e)
        {
            leden leden = new leden();
            this.Close();
            leden.Show();
        }

        private void Btn_Speelmoment(object sender, RoutedEventArgs e)
        {
            speelmomenten speelmomenten = new speelmomenten();
            this.Close();
            speelmomenten.Show();
        }

        private void Btn_sporthal(object sender, RoutedEventArgs e)
        {
            sporthal sporthal = new sporthal();
            this.Close();
            sporthal.Show();
        }

        private void Btn_Statistieken(object sender, RoutedEventArgs e)
        {
            statistieken statistieken = new statistieken();
            this.Close();
            statistieken.Show();
        }

        private void Btn_CoronaAlert(object sender, RoutedEventArgs e)
        {
            coronaalert coronaalert = new coronaalert();
            this.Close();
            coronaalert.Show();
        }

        private void Btn_Kalender(object sender, RoutedEventArgs e)
        {
            kalender Kalender = new kalender();
            this.Close();
            Kalender.Show();
        }

        private void Btn_Profiel(object sender, RoutedEventArgs e)
        {
            profiel profiel = new profiel();
            this.Close();
            profiel.Show();
        }

        private void Btn_Uitloggen(object sender, RoutedEventArgs e)
        {
             login login = new login();
            this.Close();
            login.Show();

            //RectUitloggen.Fill = new SolidColorBrush(toggle ? Colors.Aquamarine : Colors.DarkRed);
            //toggle = !toggle;
        }

    }
}
