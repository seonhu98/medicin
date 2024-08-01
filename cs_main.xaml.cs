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
    public partial class cs_main : Page
    {
        private NetworkStream stream;
        public cs_main()
        {
            InitializeComponent();
            stream = Login.stream;
        }


        private void btn_Consult_Click(object sender, RoutedEventArgs e)
        {
            tcp.send(stream, "D");
            NavigationService.Navigate(
                        new Uri("/Consult.xaml", UriKind.Relative)
                        );
        }


        private void btn_SurveyResult_Click(object sender, RoutedEventArgs e)
        {
            tcp.send(stream, "C");
            NavigationService.Navigate(
                       new Uri("/SurveyResult.xaml", UriKind.Relative)
                       );
        }

    }
}

