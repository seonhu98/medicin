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
using System.Windows.Threading;
using MedicineInfo.TCP;

namespace MedicineInfo
{
    /// <summary>
    /// Login.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Login : Page
    {  
        static public NetworkStream stream;
        static public string type;
        static public string client;

        public Login()
        {
            InitializeComponent();
            //서버 연결
            stream = OorC.stream;
            if (OorC.type1)
            {
                sign_up.Visibility = Visibility.Hidden;
            }
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {   //아이디 비밀번호 전송
            client = id_box.Text;
            string pw = pw_box.Password.ToString();
            string msg = "B" + " " + client + " " + pw;
            tcp.send(stream, msg);
            type = tcp.recv(stream);
            //아이디 비밀번호 전송
            if (type == "0\n")
            {
                MessageBox.Show("고객접속");
                NavigationService.Navigate(
                        new Uri("/cnt_main.xaml", UriKind.Relative)
                        );
            }
            else
            {
                MessageBox.Show("CS 접속");
                NavigationService.Navigate(
                        new Uri("/cs_main.xaml", UriKind.Relative)
                        );
            }
        }

        private void cancle_Click(object sender, RoutedEventArgs e)
        {   //취소 전송
            stream.Close();
            Application.Current.Shutdown();
        }

        private void sign_up_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                        new Uri("/Regist.xaml", UriKind.Relative)
                        );
        }
    }
}
