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
    /// Menu.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Menu : Page
    {
        private NetworkStream stream;
        public Menu()
        {
            InitializeComponent();
            stream = Login.stream;
        }

        private void btn_Regist_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                        new Uri("/Regist.xaml", UriKind.Relative)
                        );
        }

        private void btn_Consult_Click(object sender, RoutedEventArgs e)
        {
            tcp.send(stream, "D");
            NavigationService.Navigate(
                        new Uri("/Consult.xaml", UriKind.Relative)
                        );
        }

        private void btn_Survey_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                       new Uri("/Survey.xaml", UriKind.Relative)
                       );
        }

        private void btn_SurveyResult_Click(object sender, RoutedEventArgs e)
        {   tcp.send(stream, "C");
            NavigationService.Navigate(
                       new Uri("/SurveyResult.xaml", UriKind.Relative)
                       );
        }

        private void btn_QnA_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                       new Uri("/QnA.xaml", UriKind.Relative)
                       );
        }

        private void info_search_Click(object sender, RoutedEventArgs e)
        {   //정보조회 페이지
            NavigationService.Navigate(
                       new Uri("/Info_.xaml", UriKind.Relative)
                       );
        }

        private void btn_drug_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                       new Uri("/Drug_Abuse.xaml", UriKind.Relative)
                       );
        }
    }
}
