using System;
using System.Collections.Generic;
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

namespace EkpaideftikoLogismiko
{
    /// <summary>
    /// Interaction logic for QuizMenu.xaml
    /// </summary>
    public partial class QuizMenu : UserControl
    {
        public QuizMenu()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            (VisualTreeHelper.GetParent(VisualTreeHelper.GetParent(this)) as ContentControl).Content = new Menu();
        }

        public void startQuiz(object sender, RoutedEventArgs e)
        {
            (VisualTreeHelper.GetParent(VisualTreeHelper.GetParent(this)) as ContentControl).Content = new Quiz((sender as Button).Name);
        }
    }
}
