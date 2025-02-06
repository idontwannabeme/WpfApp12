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

namespace WpfApp1.Teacher
{
    /// <summary>
    /// Логика взаимодействия для PageAddEvluation.xaml
    /// </summary>
    public partial class PageAddEvluation : Page
    {
        public PageAddEvluation()
        {
            InitializeComponent();

            CmbGroup.SelectedValuePath = "Id";
            CmbGroup.DisplayMemberPath = "Name";
            CmbGroup.ItemsSource = OdbConnectHelper.entObj.NameGroup.ToList();

            CmbDiscipline.SelectedValuePath = "Id";
            CmbDiscipline.DisplayMemberPath = "Name";
            CmbDiscipline.ItemsSource = OdbConnectHelper.entObj.Discipline.ToList();

            CmbNameStudent.SelectedValuePath = "Id";
            CmbNameStudent.DisplayMemberPath = "Name";
            CmbNameStudent.ItemsSource = OdbConnectHelper.entObj.Student.ToList();
        }

        private void BtnAddEvaluation_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

   

        private void CmbGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedGroup = Convert.ToInt32(CmbGroup.SelectedValue);

            CmbNameStudent.ItemsSource = OdbConnectHelper.entObj.Student.Where(x => x.IdNameGroup == SelectedGroup).ToList();
        }
    }
}
