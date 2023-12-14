using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace BookShopWPF
{
    /// <summary>
    /// Логика взаимодействия для CreatePage.xaml
    /// </summary>
    public partial class CreateWindow : Window
    {
        public CreateWindow()
        {
            InitializeComponent();
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            string message = "";

            if (string.IsNullOrWhiteSpace(Email.Text)) message += "Неверное форматирование почты\n";
            if (string.IsNullOrWhiteSpace(Password.Text)) message += "Неверное форматирование пароля\n";

            if (ShopDbContext.Instance.Users.Where(x => x.Name == Email.Text.Trim()).FirstOrDefault() != null)
                message += "Пользователь уже существует";

            if (!string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show(message);
                return;
            }

            ShopDbContext.Instance.Users.Add(new User()
            {
                Name = Email.Text,
                Password = Password.Text,
                Access = Access.SelectedIndex
            });
            ShopDbContext.Instance.SaveChanges();

            AutorizationWindow auth = new AutorizationWindow();
            auth.Show();
            Close();

            MessageBox.Show("Добавлено");
        }

        public void Exit_Click(object sender, RoutedEventArgs e)
        {
            AutorizationWindow auth = new AutorizationWindow();
            auth.Show();
            Close();
        }
    }
}
