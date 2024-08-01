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
    /// Survey.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Survey : Page
    {
        private NetworkStream stream;
        public Survey()
        {
            InitializeComponent();
            stream = Login.stream;

        }
        string Question_1;
        string Question_2;
        string Question_3;
        string Question_4;
        string Question_5;

        private void btn_surveySave_Click(object sender, RoutedEventArgs e)
        {
            string msg = "G" + " " + Login.client + " " + Question_1 + " " + Question_2 + " " + Question_3 + " " + Question_4 + " " + Question_5;
            tcp.send(stream, msg);
            string k = tcp.recv(stream);
            if (k == "완료\n")
            {
                MessageBox.Show("설문에 응해주셔서 감사합니다");
                NavigationService.Navigate(
                       new Uri("/cnt_main.xaml", UriKind.Relative)
                       );
            }
        }

        private void btn_Logout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                        new Uri("/cnt_main.xaml", UriKind.Relative)
                        );
        }

        private void q1_1_Checked(object sender, RoutedEventArgs e)
        {
            Question_1 = "1";
        }

        private void q1_2_Checked(object sender, RoutedEventArgs e)
        {
            Question_1 = "2";
        }

        private void q1_3_Checked(object sender, RoutedEventArgs e)
        {
            Question_1 = "3";
        }

        private void q1_4_Checked(object sender, RoutedEventArgs e)
        {
            Question_1 = "4";
        }

        private void q2_1_Checked(object sender, RoutedEventArgs e)
        {
            Question_2 = "1";
        }

        private void q2_2_Checked(object sender, RoutedEventArgs e)
        {
            Question_2 = "2";
        }

        private void q2_3_Checked(object sender, RoutedEventArgs e)
        {
            Question_2 = "3";
        }

        private void q2_4_Checked(object sender, RoutedEventArgs e)
        {
            Question_2 = "4";
        }

        private void q3_1_Checked(object sender, RoutedEventArgs e)
        {
            Question_3 = "1";
        }

        private void q3_2_Checked(object sender, RoutedEventArgs e)
        {
            Question_3 = "2";
        }

        private void q3_3_Checked(object sender, RoutedEventArgs e)
        {
            Question_3 = "3";
        }

        private void q3_4_Checked(object sender, RoutedEventArgs e)
        {
            Question_3 = "4";
        }

        private void q4_1_Checked(object sender, RoutedEventArgs e)
        {
            Question_4 = "1";
        }

        private void q4_2_Checked(object sender, RoutedEventArgs e)
        {
            Question_4 = "2";
        }

        private void q4_3_Checked(object sender, RoutedEventArgs e)
        {
            Question_4 = "3";
        }

        private void q4_4_Checked(object sender, RoutedEventArgs e)
        {
            Question_4 = "4";
        }

        private void q5_1_Checked(object sender, RoutedEventArgs e)
        {
            Question_5 = "1";
        }

        private void q5_2_Checked(object sender, RoutedEventArgs e)
        {
            Question_5 = "2";
        }

        private void q5_3_Checked(object sender, RoutedEventArgs e)
        {
            Question_5 = "3";
        }

        private void q5_4_Checked(object sender, RoutedEventArgs e)
        {
            Question_5 = "4";
        }
    }
}
