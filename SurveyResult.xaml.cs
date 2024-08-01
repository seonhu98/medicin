using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using MedicineInfo.DB;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MedicineInfo
{
    /// <summary>
    /// SurveyResult.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SurveyResult : Page
    {
        public SeriesCollection SeriesCollection1 { get; set; }
        static public List<DB.Answer> Ques = new List<DB.Answer>();
        private NetworkStream stream;
        public bool check = true;
        public SurveyResult()
        {
            InitializeComponent();
            stream = Login.stream;

            SeriesCollection1 = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "1번",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(4) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "2번",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(2) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "3번",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(2) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "4번",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(1) },
                    DataLabels = true
                }
            };
            DataContext = this;
        }

        async private void q1_Click(object sender, RoutedEventArgs e)
        {
            first.Text = "평소 복용하는 약 이름을 아십니까?";
            SeriesCollection1[0].Values.RemoveAt(0);
            SeriesCollection1[1].Values.RemoveAt(0);
            SeriesCollection1[2].Values.RemoveAt(0);
            SeriesCollection1[3].Values.RemoveAt(0);
            if (check)
            {
                byte[] recv = new byte[4096];

                int bytes = await stream.ReadAsync(recv, 0, recv.Length);
                string responseData = Encoding.UTF8.GetString(recv, 0, bytes);

                JObject obj = JObject.Parse(responseData);

                Quest_(obj["SURVEY"]["survey"]);
                check = false;
            }
            else
            {
                SeriesCollection1[0].Values.Add(new ObservableValue(Ques[0].answer1));
                SeriesCollection1[1].Values.Add(new ObservableValue(Ques[0].answer2));
                SeriesCollection1[2].Values.Add(new ObservableValue(Ques[0].answer3));
                SeriesCollection1[3].Values.Add(new ObservableValue(Ques[0].answer4));
            }
        }

        public void Quest_(JToken obj)
        {

            if (obj != null)
            {
                foreach (var ans_ in obj)
                {
                    string first1 = ans_["survey1-1"].ToString();
                    string second1 = ans_["survey1-2"].ToString();
                    string third1 = ans_["survey1-3"].ToString();
                    string fourth1 = ans_["survey1-4"].ToString();

                    Debug.WriteLine($"{first1}, {second1}, {third1}, {fourth1}");
                    Answer anw = new Answer(); //객체를 계속 만들어줘야함4
                    anw.answer1 = int.Parse(first1);
                    anw.answer2 = int.Parse(second1);
                    anw.answer3 = int.Parse(third1);
                    anw.answer4 = int.Parse(fourth1);
                    SeriesCollection1[0].Values.Add(new ObservableValue(anw.answer1));
                    SeriesCollection1[1].Values.Add(new ObservableValue(anw.answer2));
                    SeriesCollection1[2].Values.Add(new ObservableValue(anw.answer3));
                    SeriesCollection1[3].Values.Add(new ObservableValue(anw.answer4));
                    Debug.WriteLine($"{anw.answer1}, {anw.answer2}, {anw.answer3}, {anw.answer4}");
                    //addstring = ques.Qus_key + ques.Qus_ans;
                    Ques.Add(anw);

                    string first2 = ans_["survey2-1"].ToString();
                    string second2 = ans_["survey2-2"].ToString();
                    string third2 = ans_["survey2-3"].ToString();
                    string fourth2 = ans_["survey2-4"].ToString();

                    Debug.WriteLine($"{first2}, {second2}, {third2}, {fourth2}");
                    Answer anw2 = new Answer(); //객체를 계속 만들어줘야함4
                    anw2.answer1 = int.Parse(first2);
                    anw2.answer2 = int.Parse(second2);
                    anw2.answer3 = int.Parse(third2);
                    anw2.answer4 = int.Parse(fourth2);
                    Ques.Add(anw2);

                    string first3 = ans_["survey3-1"].ToString();
                    string second3 = ans_["survey3-2"].ToString();
                    string third3 = ans_["survey3-3"].ToString();
                    string fourth3 = ans_["survey3-4"].ToString();

                    Debug.WriteLine($"{first3}, {second3}, {third3}, {fourth3}");
                    Answer anw3 = new Answer(); //객체를 계속 만들어줘야함4
                    anw3.answer1 = int.Parse(first3);
                    anw3.answer2 = int.Parse(second3);
                    anw3.answer3 = int.Parse(third3);
                    anw3.answer4 = int.Parse(fourth3);
                    Ques.Add(anw3);

                    string first4 = ans_["survey4-1"].ToString();
                    string second4 = ans_["survey4-2"].ToString();
                    string third4 = ans_["survey4-3"].ToString();
                    string fourth4 = ans_["survey4-4"].ToString();

                    Debug.WriteLine($"{first4}, {second4}, {third4}, {fourth4}");
                    Answer anw4 = new Answer(); //객체를 계속 만들어줘야함4
                    anw4.answer1 = int.Parse(first4);
                    anw4.answer2 = int.Parse(second4);
                    anw4.answer3 = int.Parse(third4);
                    anw4.answer4 = int.Parse(fourth4);
                    Ques.Add(anw4);
                    /*Debug.WriteLine(Ques[0].answer1);*/

                    string first5 = ans_["survey5-1"].ToString();
                    string second5 = ans_["survey5-2"].ToString();
                    string third5 = ans_["survey5-3"].ToString();
                    string fourth5 = ans_["survey5-4"].ToString();

                    Debug.WriteLine($"{first5}, {second5}, {third5}, {fourth5}");
                    Answer anw5 = new Answer(); //객체를 계속 만들어줘야함4
                    anw5.answer1 = int.Parse(first5);
                    anw5.answer2 = int.Parse(second5);
                    anw5.answer3 = int.Parse(third5);
                    anw5.answer4 = int.Parse(fourth5);
                    Ques.Add(anw5);

                }
            }
        }

        private void q2_Click(object sender, RoutedEventArgs e)
        {
            first.Text = "평소 본인이 복용하고 있는 약의 제조사 아십니까?";
            SeriesCollection1[0].Values.RemoveAt(0);
            SeriesCollection1[1].Values.RemoveAt(0);
            SeriesCollection1[2].Values.RemoveAt(0);
            SeriesCollection1[3].Values.RemoveAt(0);
            SeriesCollection1[0].Values.Add(new ObservableValue(Ques[1].answer1));
            SeriesCollection1[1].Values.Add(new ObservableValue(Ques[1].answer2));
            SeriesCollection1[2].Values.Add(new ObservableValue(Ques[1].answer3));
            SeriesCollection1[3].Values.Add(new ObservableValue(Ques[1].answer4));
        }

        private void q3_Click(object sender, RoutedEventArgs e)
        {
            first.Text = "평소 본인이 복용하는 약의 효능을 아십니까?";
            SeriesCollection1[0].Values.RemoveAt(0);
            SeriesCollection1[1].Values.RemoveAt(0);
            SeriesCollection1[2].Values.RemoveAt(0);
            SeriesCollection1[3].Values.RemoveAt(0);
            SeriesCollection1[0].Values.Add(new ObservableValue(Ques[2].answer1));
            SeriesCollection1[1].Values.Add(new ObservableValue(Ques[2].answer2));
            SeriesCollection1[2].Values.Add(new ObservableValue(Ques[2].answer3));
            SeriesCollection1[3].Values.Add(new ObservableValue(Ques[2].answer4));
        }

        private void q4_Click(object sender, RoutedEventArgs e)
        {
            first.Text = "평소 복용하는 약의 이상반응 및 주의사항을 알고 있습니까?";
            SeriesCollection1[0].Values.RemoveAt(0);
            SeriesCollection1[1].Values.RemoveAt(0);
            SeriesCollection1[2].Values.RemoveAt(0);
            SeriesCollection1[3].Values.RemoveAt(0);
            SeriesCollection1[0].Values.Add(new ObservableValue(Ques[3].answer1));
            SeriesCollection1[1].Values.Add(new ObservableValue(Ques[3].answer2));
            SeriesCollection1[2].Values.Add(new ObservableValue(Ques[3].answer3));
            SeriesCollection1[3].Values.Add(new ObservableValue(Ques[3].answer4));
        }

        private void q5_Click(object sender, RoutedEventArgs e)
        {
            first.Text = "한 주에 약을 복용하는 횟수가 어떻게 되나요?";
            SeriesCollection1[0].Values.RemoveAt(0);
            SeriesCollection1[1].Values.RemoveAt(0);
            SeriesCollection1[2].Values.RemoveAt(0);
            SeriesCollection1[3].Values.RemoveAt(0);
            SeriesCollection1[0].Values.Add(new ObservableValue(Ques[4].answer1));
            SeriesCollection1[1].Values.Add(new ObservableValue(Ques[4].answer2));
            SeriesCollection1[2].Values.Add(new ObservableValue(Ques[4].answer3));
            SeriesCollection1[3].Values.Add(new ObservableValue(Ques[4].answer4));
        }
    }
}