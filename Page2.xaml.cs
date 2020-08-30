using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EventParadigmQuiz
{
    /// <summary>
    /// Lógica de interacción para Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            string ProductName = txtproductname.Text;
            string category = lblcategory.Content.ToString();

            txtresult.Text = ProductName + "\n" + category;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.IsChecked.Value)
            {
                lblcategory.Content = rb.Content.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        MainWindow p = (MainWindow)Window.GetWindow(this);
            p.MainFrame.NavigationService.Navigate(new Page1());
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Category(object sender, TextCompositionEventArgs e)
        {

        }
    }
}
