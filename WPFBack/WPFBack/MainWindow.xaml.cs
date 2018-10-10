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

namespace WPFBack
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Action_Click(object sender, RoutedEventArgs e)
        {
            int length = 0;
            string str1;
            string str2="";
            length = Tex_before.Text.Length;
            char[] result = new char[length];
            str1 = Tex_before.Text;
            for (int i = length-1; i >=0; i--)
            {
                //int j = length-1;
                str2 += str1.Substring(i, 1);
                //j--;
            }
            Tex_after.Text = str2;
        }

        private void but_exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
