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

namespace Zadanie1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool us = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeLanguage_Click(object sender, RoutedEventArgs e)
        {
            if (us)
            {
                New.Content = "News";
                Home.Content = "Home";
                About.Content = "About us";
                Contact.Content = "Contact";
                ChangeLanguage.Content = "Change the language";
                us = false;
            }
            else
            {
                New.Content = "Новости";
                Home.Content = "Главная";
                About.Content = "О нас";
                Contact.Content = "Контакты";
                ChangeLanguage.Content = "Изменить язык";
                us = true;
            }
        }
    }
}
