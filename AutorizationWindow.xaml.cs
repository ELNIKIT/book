using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace BookShopWPF
{
    public partial class AutorizationWindow : Window
    {
        public AutorizationWindow()
        {
            InitializeComponent();
        }

        private void signin_Click(object sender, RoutedEventArgs e)
        {

            string login_ = login.Text;
            string password_ = password.Text;
            login.Text = "";
            password.Text = "";


            if (string.IsNullOrWhiteSpace(login_) || string.IsNullOrWhiteSpace(password_))
            {
                MessageBox.Show("Пустой логин или пароль");
                return;
            }

            var user = ShopDbContext.Instance.Users.Where(x => x.Name == login_).FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show("Пользователя не существует");
                return;
            }

            if (user.Password != password_)
            {
                MessageBox.Show("Неправильные данные");
                return;
            }

            ShopDbContext.Instance.SetActiveUser(user.ClientID);

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void signup_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow createWindow = new CreateWindow();
            createWindow.ShowDialog();

            Close();
        }
    }
}
