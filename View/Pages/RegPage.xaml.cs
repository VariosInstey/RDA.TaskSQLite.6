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
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        private User _user = new User();
        public RegPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                var login = TbLogin.Text;
                var password = PbPassword.Password;

                try
                {
                    if (string.IsNullOrEmpty(TbLogin.Text) ||
            string.IsNullOrEmpty(PbPassword.Password))



                    {
                        MessageBox.Show($"Не все строки заполнены!");
                    }
                    else
                    {
                        db.Users.Add(new User()
                        {
                            Login = login,
                            Password = password,
                            RoleID = 2
                        });
                        db.SaveChanges();
                        MessageBox.Show($"Пользователь создан - {_user.Login}!");

                        //MessageBox.Show($"Пользователь создан - {_user.Login}!");
                        //db.Users.Add(_user);
                        //db.SaveChanges();
                        //Util.UtilFrame.Navigate(new LoginPage());
                        //TbLogin.Text = string.Empty;
                        //PbPassword.Password = string.Empty;
                    }
                    

                }
                catch (Exception)
                {

                    throw;
                }
            }
            //
            //using (ModelContext db = new ModelContext())
            //{
            //    if (string.IsNullOrEmpty(TbLogin.Text) ||
            //string.IsNullOrEmpty(PbPassword.Password))



            //    {
            //        MessageBox.Show($"Не все строки заполнены!");
            //    }
            //    else
            //    {
            //        try
            //        {
            //            _user.Login = TbLogin.Text;
            //            _user.Password = PbPassword.Password;
            //            _user.RoleID = 2;
            //            MessageBox.Show($"Пользователь создан - {_user.Login}!");
            //            db.Users.Add(_user);
            //            db.SaveChanges();
            //            Util.UtilFrame.Navigate(new LoginPage());
            //            TbLogin.Text = string.Empty;
            //            PbPassword.Password = string.Empty;
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message.ToString());
            //        }
            //    }
            //}  
        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame.Navigate(new LoginPage());
        }
    }
}
