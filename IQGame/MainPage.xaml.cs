using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace IQGame
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private int Answer;
        private int Select;
        public int PageNumber = 1;
        public MainPage()
        {
            this.InitializeComponent();

            QuastionText.Text = "程序员卡鲁被发现死在家中，他的遗体趴在了键盘上。他死前留下一个暗号：2WSXDR5。警察找到了三个嫌疑人，托德（被害人喜欢叫他V）,穆拉（被害人喜欢叫他B），艾希（被害人喜欢叫他O） 请问谁是凶手？";
            ASelect.Content = "A.托德";
            BSelect.Content = "B.穆拉";
            CSelect.Content = "C.艾希";
            Answer = 1;

        }




        private void ASelect_Click(object sender, RoutedEventArgs e)
        {
            Select = 1;
        }

        private void BSelect_Click(object sender, RoutedEventArgs e)
        {
            Select = 2;
        }

        private void CSelect_Click(object sender, RoutedEventArgs e)
        {
            Select = 3;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (Select == Answer)
            {
                FlyOut.Text = "正确！";

            }
            else if (Select == 0)
            {
                FlyOut.Text = "请选择答案！";
            }
            else
            {
                FlyOut.Text = "错误！";
            }
            Select = 0;

        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (PageNumber == 1)
            {
                QuastionText.Text = "已知ABC三人中，一人是骑士，一人是小偷，一人是间谍。骑士只说真话，小偷只说假话，间谍说的话可真可假。A说：我不是间谍。B说：我是间谍。而真正的间谍C，被法官这样问道：B是间谍吗？请问：为了避免暴露身份，C应该说真话还是假话呢？";
                ASelect.Content = "A.真话";
                BSelect.Content = "B.假话";
                CSelect.Content = "C.都可";
                Answer = 1;
                PageNumber++;
            }
            else if (PageNumber == 2)
            {
                QuastionText.Text = "一位商人花了70元购进一见衣服，加价12元售出。后发现购买者支付的那张100元是假钞，商人想将这100元花出去，可是一不小心又丢了。现在请你帮那个倒霉的商人算算，他在这件衣服上共损失了多少钱？";
                ASelect.Content = "A.70";
                BSelect.Content = "B.82";
                CSelect.Content = "C.88";
                Answer = 3;
                PageNumber++;
            }


        }

        private void LastButton_Click(object sender, RoutedEventArgs e)
        {
            if (PageNumber == 2)
            {
                QuastionText.Text = "程序员卡鲁被发现死在家中，他的遗体趴在了键盘上。他死前留下一个暗号：2WSXDR5。警察找到了三个嫌疑人，托德（被害人喜欢叫他V）,穆拉（被害人喜欢叫他B），艾希（被害人喜欢叫他O） 请问谁是凶手？";
                ASelect.Content = "A.托德";
                BSelect.Content = "B.穆拉";
                CSelect.Content = "C.艾希";
                Answer = 1;
                PageNumber--;
            }
            else if (PageNumber == 3)
            {
                QuastionText.Text = "已知ABC三人中，一人是骑士，一人是小偷，一人是间谍。骑士只说真话，小偷只说假话，间谍说的话可真可假。A说：我不是间谍。B说：我是间谍。而真正的间谍C，被法官这样问道：B是间谍吗？请问：为了避免暴露身份，C应该说真话还是假话呢？";
                ASelect.Content = "A.真话";
                BSelect.Content = "B.假话";
                CSelect.Content = "C.都可";
                Answer = 1;
                PageNumber--;
            }

        }
    }
}
