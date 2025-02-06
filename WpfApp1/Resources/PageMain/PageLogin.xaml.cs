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
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageRegistration());
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = OdbConnectHelper.entObj.User.FirstOrDefault(
                    x => x.Login == TxbLogin.Text && x.Password ==
                    PsbPassword.Password
                    );
                if (userObj == null)
                {
                    MessageBox.Show("Такой пользователь не найден.",
                            "Уведомление",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                    FrameApp.frmObj.Navigate(new PageRegistration());
                }
                else
                {
                    switch (userObj.IdRole)
                    {
                        case 1:
                            FrameApp.frmObj.Navigate(new PageStudent());
                            break;
                        case 2:
                            FrameApp.frmObj.Navigate(new PageTeacher());
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Критический сбой в работе приложения: " +
                            ex.Message.ToString(),
            				"Уведомление",
                            MessageBoxButton.OK,
                            MessageBoxImage.Warning);
            }

        }
    }
}
