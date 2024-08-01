using MedicineInfo.TCP;
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
    /// Regist.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Regist : Page
    {
        private NetworkStream stream;
        public Regist()
        {
            InitializeComponent();
            stream = Login.stream;
        }

        private void Regist_Enter_Click(object sender, RoutedEventArgs e)
        {
            string id = id_box.Text;
            string pw = pw_box.Password.ToString();
            string name = name_box.Text;
            string msg = "A" + " " + id + " " + pw + " " + name;
            tcp.send(stream, msg);
            if (tcp.recv(stream) == "중복된 아이디")
            {
                MessageBox.Show("회원가입 실패(아이디 중복)");
            }
            else
            {
                NavigationService.Navigate(
                        new Uri("/Login.xaml", UriKind.Relative)
                        );
            }
        }

        private void Regist_Cancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                        new Uri("/Login.xaml", UriKind.Relative)
                        );
        }
    }
}
