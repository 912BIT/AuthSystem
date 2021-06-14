using System.Windows;

namespace AuthSystem
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAuth_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxLogin.Text == "User" && TextBoxPassword.Password == "12345")
            {
                MessageBox.Show("Вы успешно авторизировались", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                var secondWindow = new SecondWindow();
                this.Hide();
                secondWindow.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин / пароль", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
