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
using System.Windows.Shapes;

namespace EkpaideftikoLogismiko
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            if(!(String.IsNullOrEmpty(username.Text) || String.IsNullOrEmpty(password.Password)))
            {
                var d = new DataAccess();
                User user = d.AuthenticateUser(username.Text, password.Password);
                if (user != null)
                {
                    new MainWindow(user).Show();
                    this.Close();
                }
                else
                {
                    username.Clear();
                    password.Clear();
                }
            }
        }
    }
}
