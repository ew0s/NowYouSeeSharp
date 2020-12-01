using System.Windows;

namespace WPFCyberSecurityInfoParser.View
{
    /// <summary>
    /// Interaction logic for DownloadDataFromFileSystemWindow.xaml
    /// </summary>
    public partial class DownloadDatabaseFromFileSystem : Window
    {
        public DownloadDatabaseFromFileSystem()
        {
            InitializeComponent();
        }

        private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
