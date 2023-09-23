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
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace работа_с_пользователем
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {

        private ObservableCollection<User> users = new ObservableCollection<User>();
        public Window3()
        {
            InitializeComponent();

            users.Add(new User() { Name = "Banta Singh" });
            
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            users.Add(
        }

        private void btnChangeUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
                (lbUsers.SelectedItem as User).Name = "Smith";
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
                users.Remove(lbUsers.SelectedItem as User);
        }
    }
}
}
