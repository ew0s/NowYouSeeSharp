using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows;
using System.Windows.Input;
using WPFCyberSecurityInfoParser.Model;
using WPFCyberSecurityInfoParser.Model.Types;
using WPFCyberSecurityInfoParser.View.AttentionPages;

namespace WPFCyberSecurityInfoParser.View
{
    /// <summary>
    /// Interaction logic for UpdateDatabaseWindow.xaml
    /// </summary>
    public partial class UpdateDatabaseWindow : Window
    {
        private readonly MainWindow _mainWindow = (MainWindow) Application.Current.MainWindow;
        public UpdateDatabaseWindow()
        {
            InitializeComponent();
        }

        private void GridBarTitle_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonPower_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void UpdateDatabaseWindow_OnInitialized(object sender, EventArgs e)
        {
            using (var webClient = new WebClient())
            {
                const string url = @"https://bdu.fstec.ru/files/documents/thrlist.xlsx";
                const string path = "thrlist.xlsx";

                try
                {
                    webClient.DownloadFile(url, path);
                    var observableCollectionBefore = new ObservableCollection<ThreatData>(_mainWindow.ObservableCollection);
                    FstekParser.ParseFullDatabase(path);
                    FstekParser.GenerateComparedCollection(
                        observableCollectionBefore,
                        _mainWindow.ObservableCollection,
                        out var comparedCollection);

                    FullDatabaseDataGridBefore.ItemsSource = observableCollectionBefore;
                    FullDatabaseDataAfter.ItemsSource = comparedCollection;
                }
                catch (Exception)
                {
                    var unableToDownloadPage = new UnableToDownloadDataBasePage {Owner = this};
                    unableToDownloadPage.ShowDialog();
                    Close();
                }
            }
        }
    }
}
