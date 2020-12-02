using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using WPFCyberSecurityInfoParser.Model.Types;
using WPFCyberSecurityInfoParser.View;

namespace WPFCyberSecurityInfoParser
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ThreatData> ObservableCollection { get; set; } = null;

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
           MainFrame.NavigationService.Navigate(new Uri("View/ViewFullDatabasePage.xaml", UriKind.Relative));
        }

        private void ButtonShowShortInfo_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Uri("View/ViewReducedDatabasePage.xaml", UriKind.Relative));
        }

        private void ButtonUploadInfo_OnClick(object sender, RoutedEventArgs e)
        {
            var uploadOnDiskWindow = new UploadOnDiskWindow();
            uploadOnDiskWindow.ShowDialog();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            var applicationStartWindow = new ApplicationStartWindow();
            applicationStartWindow.ShowDialog();
            MainFrame.NavigationService.Navigate(new Uri("View/ViewFullDatabasePage.xaml", UriKind.Relative));
        }
    }
}
