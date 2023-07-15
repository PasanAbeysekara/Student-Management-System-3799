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
    /// Interaction logic for UserGuideWindow3.xaml
    /// </summary>
    public partial class UserGuideWindow3 : Window
    {
        public UserGuideWindow3()
        {
            InitializeComponent();
        }
        private void Next_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var userGuideWindow4 = new UserGuideWindow4();
            userGuideWindow4.Show();
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var userGuideWindow2 = new UserGuideWindow2();
            userGuideWindow2.Show();
        }


        private void CloseButton_Clicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
