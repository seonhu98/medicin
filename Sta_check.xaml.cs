using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

namespace MedicineInfo
{
    /// <summary>
    /// Sta_check.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Sta_check : Page
    {
        private NetworkStream stream;
        public Sta_check()
        {
            InitializeComponent();
            stream = Login.stream;
        }

        private void btn_Logout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                        new Uri("/Menu.xaml", UriKind.Relative)
                        );
        }
    }
}
