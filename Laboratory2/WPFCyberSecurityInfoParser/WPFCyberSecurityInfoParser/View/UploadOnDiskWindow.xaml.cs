using System.Windows;

namespace WPFCyberSecurityInfoParser.View
{
    /// <summary>
    /// Interaction logic for UploadOnDiskWindow.xaml
    /// </summary>
    public partial class UploadOnDiskWindow : Window
    {
        public UploadOnDiskWindow()
        {
            InitializeComponent();
        }

        private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
