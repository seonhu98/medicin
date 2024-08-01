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
using MedicineInfo.DB;
using Newtonsoft.Json.Linq;

namespace MedicineInfo
{
    /// <summary>
    /// Info_.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Info_ : Page
    {
        List<DB.Question> Ques = new List<DB.Question>();

        private NetworkStream stream;
        public Info_()
        {
            InitializeComponent();
            stream = Login.stream;
        }

        async private void keyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string messageText = "F" + " " + keyword.Text;

                tcp.send(stream, messageText);
                keyword.Text = "검색중....";
            }
            byte[] recv = new byte[4096];

            int bytes = await stream.ReadAsync(recv, 0, recv.Length);
            string responseData = Encoding.UTF8.GetString(recv, 0, bytes);

            JObject obj = JObject.Parse(responseData);
            Quest_(obj["Info"]["Info"]);

            ans1_lv.ItemsSource = Ques;
            ans1_lv.Items.Refresh();
        }

        public void Quest_(JToken obj)
        {
            if (obj != null)
            {
                foreach (var ans_ in obj)
                {
                    Question ques = new Question(); //객체를 계속 만들어줘야함
                    ques.name = ans_["Name"].ToString();
                    ques.pro_name = ans_["Product"].ToString();
                    ques.effect = ans_["Effect"].ToString().Replace('\n', ' ') + '\n';
                    //addstring = ques.Qus_key + ques.Qus_ans;
                    Ques.Add(ques);
                }
            }
        }

        private void menu_bt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                        new Uri("/cnt_main.xaml", UriKind.Relative)
                        );
        }
    }
}