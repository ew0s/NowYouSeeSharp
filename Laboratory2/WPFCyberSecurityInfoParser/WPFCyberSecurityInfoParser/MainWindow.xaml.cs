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
using WPFCyberSecurityInfoParser.View;

namespace WPFCyberSecurityInfoParser
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonPower_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonHide_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void ButtonScale_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }
        private void GridBarTitle_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonUpdateInfo_OnClick(object sender, RoutedEventArgs e)
        {
            var downloadDataDialogPage = new DownloadDataDialogPage();
            downloadDataDialogPage.ShowDialog();
        }

        private void ButtonShowFullInfo_OnClick(object sender, RoutedEventArgs e)
        {
           MainFrame.NavigationService.Navigate(new Uri("View/ViewFullDatabase.xaml", UriKind.Relative));
        }
    }
}
