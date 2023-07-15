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

namespace SMS.MVVM.Views.UserGuides
{
    /// <summary>
    /// Interaction logic for UserGuideWindow2.xaml
    /// </summary>
    public partial class UserGuideWindow2 : Window
    {
        public UserGuideWindow2()
        {
            InitializeComponent();
        }
        private void Next_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var userGuideWindow3 = new UserGuideWindow3();
            userGuideWindow3.Show();
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var userGuideWindow = new UserGuideWindow();
            userGuideWindow.Show();
        }


        private void CloseButton_Clicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
