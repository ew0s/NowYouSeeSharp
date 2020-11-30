﻿using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WPFCyberSecurityInfoParser.View.AttentionPages
{
    /// <summary>
    /// Логика взаимодействия для UnableToDownloadDataBasePage.xaml
    /// </summary>
    public partial class UnableToDownloadDataBasePage : Window
    {
        public UnableToDownloadDataBasePage()
        {
            InitializeComponent();
        }

        private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
