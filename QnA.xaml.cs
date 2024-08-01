using System;
using System.Collections.Generic;
using System.Linq;
using MedicineInfo;
using MedicineInfo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
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


namespace MedicineInfo
{
    /// <summary>
    /// </summary>

    public partial class QnA : Page
    {
        public QnA()
        {
            InitializeComponent(); //구성요소 UI 그리기

            Question_ faq1 = new Question_();

            faq1.question1 = "약물 오ㆍ남용이 무엇인가요?";

            faq1.question2 = "마약류란 무엇인가요?";

            faq1.question3 = "오ㆍ남용이 우려되는 의약품에는 어떤 것이 있을까요??";

            faq1.question4 = "대표적인 약물 오ㆍ남용의 예는 무엇인가요? ";

            DataContext = faq1;
            QnAList.CanContentScroll = false;
            QnAList.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden;

        }

        private void Backk_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                        new Uri("/cnt_main.xaml", UriKind.Relative)
                        );
        }

        private void Choice1_MouseDown(object sender, MouseButtonEventArgs e)
        {

            MessageBox.Show(" 약물 오용이란 의도적이 아니지만 적절한 용도로 사용하지 못하고 잘못 사용하여 피해를 보게 되는 것을 말합니다.\r\n \r\n약물 남용이란 의도적으로 약물을 다른 목적을 위해 사용하는 것을 말하며, 알콜을 사용하는 것에서부터 마약, 유사약물을 강박적으로 사용하는 것에 이르기까지 모든 행동이 포함됩니다.\r\n \r\n이런 경우 약물에 내성이 생겨 점차 약물의 약을 늘려 가게 되고 나중에는 이를 중단하지 못하고 지속적으로 사용하는 의존상태에 빠지게 됩니다.");
        }

        private void Choice2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("한번 사용하기 시작하며 하면 자꾸 사용하고 싶은 충동을 일으키고 (의존성), 사용할 때마다 양을 늘리지 않으면 효과가 없으며(내성), 사용을 중지하면 온 몸에 견디기 힘든 이상증상을 일으키며(금단증상),\r\n 개인에게 한정되지 않고 사회에도 해를 끼치게 되는 물질로 마약, 향정신성의약품, 대마 등을 총칭하는 말입니다.");
        }

        private void Choice3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("의사의 처방에 의하여 지시사항 대로 사용하지 않거나 불법적으로 사용할 우려가 있는 의약품으로 대표적으로 비만치료제, 발기부전치료제 ADHD치료제 등이 있습니다.");
        }

        private void Choice4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("대표적인 사례로는 공부 잘하는 약이 있으며, 이 약은 최근 일부 수험생들 사이에서 잠을 쫓고 집중력을 높여 준다고 하여 오ㆍ남용되고 있는 약입니다.\r\n \r\n 이 약은 메칠페니데이트가 주성분으로 주의력이 결핍되어 지나치게 산만하게 행동하는 증상(ADHD) 및 우울성신경증, 수면발작 등의 치료에 사용되는 향정신성의약품입니다. \r\n \r\n그렇기 때문에 정신적 의존성, 심혈관계 부작용, 공격적인 행동 등의 부작용이 있으므로 꼭 의사의 처방에 따라 안전하게 사용해야 합니다.");
        }

        //ss.ScrollToBottom();
        //faqlist.Add();
    }

}