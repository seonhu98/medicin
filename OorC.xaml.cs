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
using MedicineInfo.TCP;
namespace MedicineInfo
{
    /// <summary>
    /// OorC.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class OorC : Page
    {
        static public string ip = "10.10.21.116";
        //서버 포트번호
        static public int port = 10002;
        static public NetworkStream stream;
        static public string type;
        static public string client;
        static public bool type1 = true; 
        public OorC()
        {
            InitializeComponent();
            stream = tcp.connect(ip, port);
        }

        private void btn_client_Click(object sender, RoutedEventArgs e)
        {
            type1 = false;
            NavigationService.Navigate(
                new Uri("/Login.xaml", UriKind.Relative)
                );
        }

        private void btn_staff_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/Login.xaml", UriKind.Relative)
                );
        }
    }
}
