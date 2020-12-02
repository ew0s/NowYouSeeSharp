using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Xml.Serialization;
using DocumentFormat.OpenXml.Drawing.Charts;
using WPFCyberSecurityInfoParser.Model.Types;

namespace WPFCyberSecurityInfoParser.View
{
    /// <summary>
    /// Interaction logic for UploadOnDiskWindow.xaml
    /// </summary>
    public partial class UploadOnDiskWindow : Window
    {
        private readonly MainWindow _mainWindow = (MainWindow) Application.Current.MainWindow;
        public UploadOnDiskWindow()
        {
            InitializeComponent();
        }

        private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonOk_OnClick(object sender, RoutedEventArgs e)
        {
            var formatter = new XmlSerializer(typeof(ObservableCollection<ThreatData>));
            using (var fs = new FileStream(FilePath.Text, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, _mainWindow.ObservableCollection);
            }
            Close();
        }
    }
}
