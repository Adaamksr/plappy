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
using System.Windows.Shapes;

namespace Plappy_v1
{
    /// <summary>
    /// Interaction logic for speelmomenten.xaml
    /// </summary>
    public partial class speelmomenten : Window
    {
        public speelmomenten()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            this.Close();
            MW.Show();
        }

        private void Aanwezigheden(object sender, MouseButtonEventArgs e)
        {
            aanwezigheden aanwezigheden = new aanwezigheden();
            this.Close();
            aanwezigheden.Show();
        }
        private void Leden(object sender, MouseButtonEventArgs e)
        {
            leden leden = new leden();
            this.Close();
            leden.Show();
        }
        private void Speelmomenten(object sender, MouseButtonEventArgs e)
        {
            speelmomenten speelmomenten = new speelmomenten();
            this.Close();
            speelmomenten.Show();
        }
        private void Sporthal(object sender, MouseButtonEventArgs e)
        {
            sporthal sporthal = new sporthal();
            this.Close();
            sporthal.Show();
        }
        private void Kalender(object sender, MouseButtonEventArgs e)
        {
            kalender Kalender = new kalender();
            this.Close();
            Kalender.Show();
        }
        private void Statistieken(object sender, MouseButtonEventArgs e)
        {
            statistieken statistieken = new statistieken();
            this.Close();
            statistieken.Show();
        }
        private void CoronaAlert(object sender, MouseButtonEventArgs e)
        {
            coronaalert coronaalert = new coronaalert();
            this.Close();
            coronaalert.Show();
        }
        private void Profiel(object sender, MouseButtonEventArgs e)
        {
            profiel profiel = new profiel();
            this.Close();
            profiel.Show();
        }
    }
}
