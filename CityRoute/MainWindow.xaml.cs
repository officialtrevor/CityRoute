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
using System.Threading;


namespace CityRoute
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFraim
        }

        private void CheckBox_Changed(object sender, RoutedEventArgs e)
        {

        }
        private void PasBox_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            if (PasBox.Password == "123" && LogBox.Text == "123")
            {
                
            }
            else
            {
                MessageBox.Show("Неверный пароль или логин");
            }
        }

    }
}
