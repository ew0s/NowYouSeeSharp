using System;
using System.Net;
using System.Windows;
using WPFCyberSecurityInfoParser.View.AttentionPages;

namespace WPFCyberSecurityInfoParser.View
{
    /// <summary>
    /// Логика взаимодействия для DownloadDataDialogWindow.xaml
    /// </summary>
    public partial class DownloadDataDialogPage : Window
    {
        public DownloadDataDialogPage()
        {
            InitializeComponent();
        }

        private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
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
                }
                catch (Exception)
                {
                    var unableToDownloadPage = new UnableToDownloadDataBasePage {Owner = this};
                    unableToDownloadPage.ShowDialog();
                    return;
                }
            }

            
            var successPage = new SuccessPage() { Owner = this };
            successPage.ShowDialog();
            Close();
        }

        private void ButtonFileSystemDownload_OnClick(object sender, RoutedEventArgs e)
        {
            var downloadDatabaseFromFileSystem = new DownloadDatabaseFromFileSystem();

            try
            {
                downloadDatabaseFromFileSystem.ShowDialog();
            }
            catch (Exception)
            {
                var unableToDownloadPage = new UnableToDownloadDataBasePage { Owner = this };
                unableToDownloadPage.ShowDialog();
                return;
            }

            var successPage = new SuccessPage() {Owner = this};
            successPage.ShowDialog();

            Close();
        }
    }
}
