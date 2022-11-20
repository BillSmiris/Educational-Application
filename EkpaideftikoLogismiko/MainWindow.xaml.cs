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

namespace EkpaideftikoLogismiko
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public User user;

        public MainWindow(User user)
        {
            InitializeComponent();
            this.user = user;
            contentControl.Content = new Menu();
            //manual.Source = new Uri(System.IO.Path.GetFullPath(@"./Resources/Data/Εγχειρίδιο Χρήστη - Εφαρμογή Desktop.pdf"));
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            manual.Source = new Uri(System.IO.Path.GetFullPath("Εγχειρίδιο Χρήστη - Εφαρμογή Desktop.pdf"));
        }
    }
}
