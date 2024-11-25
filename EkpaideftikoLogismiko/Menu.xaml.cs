﻿using System;
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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void unitsButton_Click(object sender, RoutedEventArgs e)
        {
            (VisualTreeHelper.GetParent(VisualTreeHelper.GetParent(this)) as ContentControl).Content = new UnitMenu();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }

        private void quizButton_Click(object sender, RoutedEventArgs e)
        {
            (VisualTreeHelper.GetParent(VisualTreeHelper.GetParent(this)) as ContentControl).Content = new QuizMenu();
        }
    }
}
