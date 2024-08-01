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
using System.IO;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.Collections;
using Image = System.Drawing.Image;

namespace MedicineInfo
{
    /// <summary>
    /// Drug_Abuse.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Drug_Abuse : Page
    {
        int page = 1;
        bool check1 = true;
        public int[] check_ = new int[5];
        private NetworkStream stream;
        public Drug_Abuse()
        {
            InitializeComponent();
            stream = Login.stream;
        }

        private async void recv_img_Click(object sender, RoutedEventArgs e)
        {
            check_[page - 1] = page;
            if (page == 1)
            {
                before_page.Visibility = Visibility.Visible;
            }
            recv_img.Content = "다음 페이지";
            if (page < 6)
            {
                await ProcessImage();
                page++;
            }
            else if (page > 5)
            {
                page = 5;
                MessageBox.Show("마지막 페이지 입니다");
            }
        }

        private async Task ProcessImage()
        {
            string page_ = page.ToString();
            string send = "E" + " " + page_;
            tcp.send(stream, send);
            for (int i = 0; i < 5; i++)
            {
                if (i + 2 == page + 1)
                {

                }
            }
            try
            {
                // 파일 크기 수신
                byte[] fileSizeBytes = new byte[sizeof(int)];
                await stream.ReadAsync(fileSizeBytes, 0, fileSizeBytes.Length);
                int fileSize = BitConverter.ToInt32(fileSizeBytes.Reverse().ToArray(), 0);
                Debug.WriteLine(fileSize.ToString());

                // 파일 데이터 수신
                byte[] fileData = new byte[4096];

                using (MemoryStream ms = new MemoryStream())
                {
                    int bytesRead;
                    int totalbytesReadv = 0;
                    while (totalbytesReadv < fileSize && (bytesRead = Login.stream.Read(fileData, 0, fileData.Length)) > 0)
                    {
                        ms.Write(fileData, 0, bytesRead);
                        totalbytesReadv += bytesRead;
                    }

                    ms.Seek(0, SeekOrigin.Begin);
                    BitmapImage image1 = new BitmapImage();
                    image1.BeginInit();
                    image1.StreamSource = ms;
                    image1.CacheOption = BitmapCacheOption.OnLoad;
                    image1.EndInit();

                    // Display the image based on the page number
                    switch (page)
                    {
                        case 1:
                            good.Source = image1;
                            break;
                        case 2:
                            good.Visibility = Visibility.Hidden;
                            good2.Visibility = Visibility.Visible;
                            good2.Source = image1;
                            break;
                        case 3:
                            good2.Visibility = Visibility.Hidden;
                            good3.Visibility = Visibility.Visible;
                            good3.Source = image1;
                            break;
                        case 4:
                            good3.Visibility = Visibility.Hidden;
                            good4.Visibility = Visibility.Visible;
                            good4.Source = image1;
                            break;
                        case 5:
                            good4.Visibility = Visibility.Hidden;
                            good5.Visibility = Visibility.Visible;
                            good5.Source = image1;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"에러: {ex.Message}");
            }
        }
        private void menu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                        new Uri("/cnt_main.xaml", UriKind.Relative)
                        );
        }

        private void before_page_Click(object sender, RoutedEventArgs e)
        {
            --page;
            if (page < 1)
            {
                page = 1;
                MessageBox.Show("첫 페이지 입니다");
            }
            else if (page > 1 && page < 5)
            {
                switch (page)
                {
                    case 1:
                        good2.Visibility = Visibility.Hidden;
                        good.Visibility = Visibility.Visible;
                        break;
                    case 2:
                        good3.Visibility = Visibility.Hidden;
                        good2.Visibility = Visibility.Visible;
                        break;
                    case 3:
                        good4.Visibility = Visibility.Hidden;
                        good3.Visibility = Visibility.Visible;
                        break;
                    case 4:
                        good5.Visibility = Visibility.Hidden;
                        good4.Visibility = Visibility.Visible;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}