using System;
using System.Collections.ObjectModel;
using System.Windows;
using WPFCyberSecurityInfoParser.Model.Types;
using Page = System.Windows.Controls.Page;

namespace WPFCyberSecurityInfoParser.View
{
    /// <summary>
    /// Interaction logic for ViewFullDatabasePage.xaml
    /// </summary>
    public partial class ViewFullDatabasePage : Page
    {
        private readonly MainWindow _mainWindow = (MainWindow) Application.Current.MainWindow;
        private ObservableCollection<ThreatData> _collection = null;
        public ViewFullDatabasePage()
        {
            InitializeComponent();
        }

        private void ViewFullDatabasePage_OnInitialized(object sender, EventArgs e)
        {
            _collection = _mainWindow.ObservableCollection;
            FullDatabaseDataGrid.ItemsSource = _mainWindow.ObservableCollection;
        }
    }
}
