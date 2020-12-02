using System;
using System.Net;
using System.Windows;
using WPFCyberSecurityInfoParser.Model;
using WPFCyberSecurityInfoParser.View.AttentionPages;

namespace WPFCyberSecurityInfoParser.View
{
    /// <summary>
    /// Interaction logic for ApplicationStartWindow.xaml
    /// </summary>
    public partial class ApplicationStartWindow : Window
    {
        private readonly MainWindow _mainWindow = (MainWindow) Application.Current.MainWindow;
        public ApplicationStartWindow()
        {
            InitializeComponent();
        }

        private void ButtonEthernetDownload_OnClick(object sender, RoutedEventArgs e)
        {
            using (var webClient = new WebClient())
            {
                const string url = @"https://bdu.fstec.ru/files/documents/thrlist.xlsx";
                const string path = "thrlist.xlsx";

                try
                {
                    webClient.DownloadFile(url, path);
                    _mainWindow.ObservableCollection = FstekParser.ParseFullDatabase(path);
                    _mainWindow.ShortObservableCollection =
                        FstekParser.ParseShortDatabase(_mainWindow.ObservableCollection);
                }
                catch (Exception)
                {
                    var unableToDownloadPage = new UnableToDownloadDataBasePage { Owner = this };
                    unableToDownloadPage.ShowDialog();
                    return;
                }
            }


            var successPage = new SuccessPage() { Owner = this };
            successPage.ShowDialog();
            Close();
        }

        private void ButtonShutdownApp_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
