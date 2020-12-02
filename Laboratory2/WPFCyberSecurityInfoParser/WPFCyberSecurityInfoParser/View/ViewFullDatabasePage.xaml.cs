using System;
using System.Collections.ObjectModel;
using System.Windows;
using WPFCyberSecurityInfoParser.Model.Types;
using WPFCyberSecurityInfoParser.View.AttentionPages;
using Page = System.Windows.Controls.Page;

namespace WPFCyberSecurityInfoParser.View
{
    /// <summary>
    /// Interaction logic for ViewFullDatabasePage.xaml
    /// </summary>
    public partial class ViewFullDatabasePage : Page
    {
        public int PagesCount =>
            _collection.Count % RowsPerPage == 0
                ? _collection.Count / RowsPerPage
                : _collection.Count / RowsPerPage + 1;
        private const int RowsPerPage = 15;
        private int _currentPageNumber = 1;
        private readonly MainWindow _mainWindow = (MainWindow) Application.Current.MainWindow;
        private ObservableCollection<ThreatData> _collection;
        private readonly ObservableCollection<ThreatData> _currentPageCollection = new ObservableCollection<ThreatData>();

        public ViewFullDatabasePage()
        {
            InitializeComponent();
        }

        private void GenerateCurrentPage(int pageNumber)
        {
            if (pageNumber < 1 || pageNumber > PagesCount)
            {
                var invalidPageCountWindow = new InvalidPageCountWindow();
                invalidPageCountWindow.ShowDialog();
                return;
            }

            _currentPageNumber = pageNumber;
            _currentPageCollection.Clear();
            for (var i = (pageNumber - 1) * RowsPerPage; i < pageNumber * RowsPerPage; i++)
            {
                if (i == _collection.Count) break;
                _currentPageCollection.Add(_collection[i]);
            }

            CurrentPage.Text = _currentPageNumber.ToString();
            FullDatabaseDataGrid.ItemsSource = _currentPageCollection;
        }

        private void ViewFullDatabasePage_OnInitialized(object sender, EventArgs e)
        {
            _collection = _mainWindow.ObservableCollection;
            GenerateCurrentPage(_currentPageNumber);
            CurrentPage.Text = _currentPageNumber.ToString();
            CountOfPages.Text = PagesCount.ToString();
        }

        private void ButtonPrevPage_OnClick(object sender, RoutedEventArgs e)
        {
            if (_currentPageNumber <= 1) return;
            _currentPageNumber--;
            GenerateCurrentPage(_currentPageNumber);
        }

        private void ButtonNextPage_OnClick(object sender, RoutedEventArgs e)
        {
            if (_currentPageNumber >= PagesCount) return;
            _currentPageNumber++;
            GenerateCurrentPage(_currentPageNumber);
        }

        private void ButtonOk_OnClick(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(SelectPageTextBox.Text, out var number))
            {
                var invalidPageCountWindow = new InvalidPageCountWindow();
                invalidPageCountWindow.ShowDialog();
                return;
            }

            GenerateCurrentPage(number);
        }
    }
}
