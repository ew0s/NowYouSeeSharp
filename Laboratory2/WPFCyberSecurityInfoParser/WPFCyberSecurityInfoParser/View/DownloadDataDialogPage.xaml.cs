using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFCyberSecurityInfoParser.View.AttentionPages;

namespace WPFCyberSecurityInfoParser.View
{
    /// <summary>
    /// Логика взаимодействия для DownloadDataDialogPage.xaml
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
                const string url = "https://bdu.fstec.ru/files/documents/thrlist.xlsx";
                const string fileName = "thrlist.xlsx";

                try
                {
                    webClient.DownloadFile(url, fileName);
                }
                catch (Exception)
                {
                    var unableToDownloadPage = new UnableToDownloadDataBasePage {Owner = this};
                    unableToDownloadPage.ShowDialog();
                    return;
                }
            }

            var successPage = new SuccessPage() {Owner = this};
            successPage.ShowDialog();
            Close();
        }
    }
}
