using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Consult.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Consult : Page
    {   
        bool check = true;
        private NetworkStream stream;
        private ObservableCollection<string> messageList;

        public Consult()
        {
            InitializeComponent();
            stream = Login.stream;

            this.messageList = new ObservableCollection<string>();
            // UI 초기화
            client.ItemsSource = messageList;

            StartReceiving();
        }

        private void StartReceiving()
        {
            Task.Run(() =>
            {
                if (Login.type == "0\n")
                {
                    try
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead;

                        while (check)
                        {
                            bytesRead = stream.Read(buffer, 0, buffer.Length);
                            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                            Dispatcher.Invoke(() =>
                            {
                                messageList.Add($"[{DateTime.Now.ToString("HH:mm:ss")}] 상담사: {message}");
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"오류 발생: {ex.Message}", "오류", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    try
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead;

                        while (check)
                        {
                            bytesRead = stream.Read(buffer, 0, buffer.Length);
                            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                            Dispatcher.Invoke(() =>
                            {
                                messageList.Add($"[{DateTime.Now.ToString("HH:mm:ss")}] 고객 : {message}");
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"오류 발생: {ex.Message}", "오류", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            });
        }
        /*        public async void chating()
                {
                    int len;
                    byte[] bytes = new byte[1024];
                    await Task.Delay(1000);
                    Thread.Sleep(1000);
                    while (true)
                    {
                        //await Dispatcher.Invoke(async() =>
                        //{

                        await Task.Delay(100);
                        len = ((int)stream.Length);
                        bytes[len] = 0;
                        string talk = Encoding.UTF8.GetString(bytes);

                        Array.Clear(bytes, 0, bytes.Length);
                        viewer(talk);

                    }
                }*/
        private void SendMessage(string message)
        {
            if (Login.type == "0\n")
            {
                try
                {
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                    messageList.Add($"[{DateTime.Now.ToString("HH:mm:ss")}] 나: {message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"메시지 전송 중 오류 발생: {ex.Message}", "오류", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                try
                {
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                    messageList.Add($"[{DateTime.Now.ToString("HH:mm:ss")}] 상담사 : {message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"메시지 전송 중 오류 발생: {ex.Message}", "오류", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        public void WriteSock(string msg)
        {
            /*byte[] data = Encoding.UTF8.GetBytes(msg);*/
            tcp.send(stream, msg);
        }

        public string ReadSock()
        {
            byte[] buffer = new byte[1024];
            string remessage = tcp.recv(stream);
            /*string remessage = Encoding.UTF8.GetString(buffer);*/
            return remessage;
        }

        private void btn_Send_Click(object sender, RoutedEventArgs e)
        {
            string messageText = message.Text;
            SendMessage(messageText);
            message.Text = "";
        }

        private void MessageInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string messageText = message.Text;
                SendMessage(messageText);
                message.Text = "";
            }
        }

        private void MessageInput_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            message.Text = null;
        }

        private void menu_bt_Click(object sender, RoutedEventArgs e)
        {
            SendMessage("끝");
            check = false;
            if (Login.type == "0")
                NavigationService.Navigate(new Uri("/cnt_main.xaml", UriKind.Relative));
            else
                NavigationService.Navigate(new Uri("/cs_main.xaml", UriKind.Relative));
        }
    }
}
