using System;
using Microsoft.Win32;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //private string imgsource1 = @"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\Anna_Petrenko\Downloads\d.jpg";
        //private string imgsource2 = @"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\Anna_Petrenko\Downloads\d.jpg";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Window1 = new MainWindow();
            Window1.Show();
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Приложение закроется");
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            TextBlock.Text = "SUS";
            //DisplayImage.Source = new BitmapImage(new Uri(imgsource1));
            //OpenFileDialog openFileDialog = new OpenFileDialog { Filter ="Image Files| *.jpg;*.jpeg;*.png;*.gif;*.bmp;"};
            //if (openFileDialog.ShowDialog() == true)
            //{
            //BitmapImage bitmapImage = new BitmapImage(new Uri(openFileDialog.FileName));
            //DisplayImage.Source = bitmapImage;

            //}
        }

        //private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        //{
            //DisplayImage.Source = new BitmapImage(new Uri(imgsource2));
        //}
        //<MenuItem Header="Файл1" Click="MenuItem_Click_1"></MenuItem>
        //<MenuItem Header = "Файл2" Click="MenuItem_Click_2"></MenuItem>
    }
}
