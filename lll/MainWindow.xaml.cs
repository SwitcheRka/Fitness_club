using MahApps.Metro.Controls;
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

namespace lll
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FlipView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var flipview = ((FlipView)sender);
            switch (flipview.SelectedIndex)
            {
                case 0:
                    flipview.BannerText = "Welcome";
                    break;
                case 1:
                    flipview.BannerText = "Make your body greater!";
                    break;
                case 2:
                    flipview.BannerText = "Not for us, but for yourself<3";
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using(ApplicationContext db = new ApplicationContext())
            {
                Users user = new Users();
                user.username = Name.Text;
                user.password = Password.Password;
                db.Add(user);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Data save");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void autorizationButton_Click(object sender, RoutedEventArgs e)
        {
            using(ApplicationContext db = new ApplicationContext())
            {
                var currentUser = db.users.FirstOrDefault(p => p.username == Name.Text && p.password == Password.Password);
                if (currentUser != null)
                {
                    if (currentUser.type_user == "Admin" || currentUser.type_user == "admin" || currentUser.type_user == "Administrator" || currentUser.type_user == "administrator"
                        || currentUser.type_user == "Админ" || currentUser.type_user == "Администратор" || currentUser.type_user == "админ" || currentUser.type_user == "администратор")
                    {
                        DataGrid task = new DataGrid();
                        task.Show();
                        this.Close();
                    }
                    else
                    {
                        first first = new first();
                        first.Show();
                        this.Close();
                    }
                }
                //else
                //{
                //    MessageBox.Show("wrong login or password");
                //}
            }
        }
    }

}
