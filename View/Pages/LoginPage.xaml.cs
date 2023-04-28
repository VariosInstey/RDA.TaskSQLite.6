using RDA.TaskSQLite._6.Core;
using RDA.TaskSQLite._6.Model;
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

namespace RDA.TaskSQLite._6.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var Login = TbLogin.Text;
                var Password = PbPassword.Password;
                using (ModelContext db = new ModelContext())
                {
                    User? userFound = db.Users.FirstOrDefault( predicate: x => x.Login == TbLogin.Text && x.Password == PbPassword.Password); 

                    if (userFound != null)
                    {
                        MessageBox.Show("Успешная авторизация-Пользователь!",
                           "Системное сообщение",
                           MessageBoxButton.OK,
                           MessageBoxImage.Information);
                        switch (userFound.Role.RoleID)
                        {
                            case 1:
                                MessageBox.Show("Успешная авторизация-Администратор!","Системное сообщение",
                                    MessageBoxButton.OK, MessageBoxImage.Information);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка данных",
                            "Системное сообщение",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                    "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

            }
        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame.Navigate(new RegPage());
        }
    }
}
