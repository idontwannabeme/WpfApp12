using System;
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

namespace WpfApp1.Resources.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageAddStudent.xaml
    /// </summary>
    public partial class PageAddStudent : Page
    {
        public PageAddStudent()
        {
            InitializeComponent();

            CmbSpecial.SelectedValuePath = "Id";
            CmbSpecial.DisplayMemberPath = "Name";
            CmbSpecial.ItemsSource = OdbConnectHelper.entObj.Special.ToList();

            CbmYear.SelectedValuePath = "Id";
            CbmYear.DisplayMemberPath= "Year";
            CbmYear.ItemsSource = OdbConnectHelper.entObj.YearAdd.ToList();

            CbmFormTime.SelectedValuePath = "Id";
            CbmFormTime.DisplayMemberPath = "Name";
            CbmFormTime.ItemsSource = OdbConnectHelper.entObj.FormTime.ToList();

            CbmNameGroup.SelectedValuePath = "Id";
            CbmNameGroup.DisplayMemberPath = "Name";
            CbmNameGroup.ItemsSource = OdbConnectHelper.entObj.NameGroup.ToList();

        }

        private void BtnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Student stdObj = new Student()
                {
                    Name = TxbNameStudent.Text,
                    Special = CmbSpecial.SelectedItem as Special,
                    FormTime = CbmFormTime.SelectedItem as FormTime,
                    YearAdd = CbmYear.SelectedItem as YearAdd,
                    NameGroup = CbmNameGroup.SelectedItem as NameGroup
                };
                
                OdbConnectHelper.entObj.Student.Add(stdObj);
                OdbConnectHelper.entObj.SaveChanges();
                MessageBox.Show(
		        "Студент" +stdObj.Name + " успешно добавлен!",
            		"Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );
                FrameApp.frmObj.GoBack();
            }
                catch (Exception ex) {
                MessageBox.Show(
		        "Критическая работа с приложением" +ex.Message.ToString(),
            		"Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );
            }

        }


    }
}
