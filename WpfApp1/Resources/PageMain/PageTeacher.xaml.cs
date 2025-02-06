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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.DataFilesApp;
using WpfApp1.Teacher;

namespace WpfApp1.Resources.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageTeacher.xaml
    /// </summary>
    public partial class PageTeacher : Page
    {
        public PageTeacher()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void BtnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageAddStudent());
        }

        private void BtnAddEvaluation_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageAddEvluation());
        }
    }
}
