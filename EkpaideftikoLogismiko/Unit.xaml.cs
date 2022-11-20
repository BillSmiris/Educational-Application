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
using System.IO;
using System.Windows.Resources;
using System.Diagnostics;

namespace EkpaideftikoLogismiko
{
    /// <summary>
    /// Interaction logic for Unit.xaml
    /// </summary>
    public partial class Unit : UserControl
    {
        private string unit;
       
        public Unit(string unit)
        {
            InitializeComponent();
            this.unit = unit;
            StreamResourceInfo info = Application.GetResourceStream(new Uri("/Resources/Data/unitdata/" + unit + ".txt", UriKind.Relative));
            StreamReader sr = new StreamReader(info.Stream);
            string line;
            sr.ReadLine();
            int i = 0;
            while ((line = sr.ReadLine()) != null && i < 6)
            {
                Image img = new Image();
                Border b = new Border();
                b.Name = line;
                b.AddHandler(Border.MouseUpEvent, new RoutedEventHandler(ShowDetails));
                b.Style = Resources["UnitPersonImageHover"] as Style;
                var y = (System.Windows.SystemParameters.PrimaryScreenWidth) / 6 - b.Width / 2 - b.BorderThickness.Left;
                b.Margin = new Thickness(y, b.Margin.Top, y, b.Margin.Bottom);
                img.Source = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Resources/Images/People/" + line + ".jpg"));
                img.Style = Resources["UnitPersonImage"] as Style;
                b.Child = img;
                wrapPanel.Children.Add(b);
                i++;
            }
            sr.Close();
            Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Resources/Images/Backgrounds/" + unit + ".jpg")));
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            (VisualTreeHelper.GetParent(VisualTreeHelper.GetParent(this)) as ContentControl).Content = new UnitMenu();
        }

        private void ShowDetails(object sender, RoutedEventArgs e)
        {
           string name = (sender as Border).Name;
            StreamResourceInfo info = Application.GetResourceStream(new Uri("/Resources/Data/peopledata/peopleinfo/" + name + ".txt", UriKind.Relative));
            StreamReader sr = new StreamReader(info.Stream);
            detailsPanel.name.Text = sr.ReadLine();
            detailsPanel.portrait.Source = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Resources/Images/People/" + name + ".jpg"));
            detailsPanel.birthDate.Text = sr.ReadLine();
            detailsPanel.birthPlace.Text = sr.ReadLine();
            detailsPanel.deathDate.Text = sr.ReadLine();
            detailsPanel.deathPlace.Text = sr.ReadLine();
            wrapPanel.Visibility = Visibility.Collapsed;
            backButton.Visibility = Visibility.Collapsed;
            detailsPanel.Visibility = Visibility.Visible;
            //new Uri(BaseUriHelper.GetBaseUri(this), "Resources/Data/peopledata/peopledesc/" + name + ".xaml")
            detailsPanel.flowDocumentScrollViewer.Document = Application.LoadComponent(new Uri("/Resources/Data/peopledata/peopledesc/" + name + ".xaml", UriKind.Relative)) as FlowDocument;
            sr.Close();
        }
    }
}
