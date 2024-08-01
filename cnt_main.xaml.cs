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
    /// cs_main.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class cnt_main : Page
    {
        private NetworkStream stream;
        public cnt_main()
        {
            InitializeComponent();
            stream = Login.stream;
        }

        private void btn_Consult_Click(object sender, RoutedEventArgs e)//채팅
        {
            tcp.send(stream, "D");
            NavigationService.Navigate(
                        new Uri("/Consult.xaml", UriKind.Relative)
                        );
        }

        private void btn_Survey_Click(object sender, RoutedEventArgs e)///설문조사
        {
            NavigationService.Navigate(
                       new Uri("/Survey.xaml", UriKind.Relative)
                       );
        }


        private void btn_QnA_Click(object sender, RoutedEventArgs e)///QNA
        {
            NavigationService.Navigate(
                       new Uri("/QnA.xaml", UriKind.Relative)
                       );
        }

        private void info_search_Click(object sender, RoutedEventArgs e)///정보조회
        {   //정보조회 페이지
            NavigationService.Navigate(
                       new Uri("/Info_.xaml", UriKind.Relative)
                       );
        }

        private void btn_drug_Click(object sender, RoutedEventArgs e)////이미지
        {
            NavigationService.Navigate(
                       new Uri("/Drug_Abuse.xaml", UriKind.Relative)
                       );
        }
    }
}
