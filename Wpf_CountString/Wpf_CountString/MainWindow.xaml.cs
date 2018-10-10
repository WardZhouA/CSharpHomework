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

namespace Wpf_CountString
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
            string str;
            str = Tex_main.Text;
            int let = 0;
            int num = 0;
            int oth = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]>='0'&&str[i]<='9')
                {
                    num++;
                }
                else if (str[i] >= 'a' && str[i] <= 'z'|| str[i] >= 'A' && str[i] <= 'Z')
                {
                    let++;
                }
                else
                {
                    oth++;
                }
            }
            Tex_let.Text = Convert.ToString(let);
            Tex_num.Text = Convert.ToString(num);
            Tex_oth.Text = Convert.ToString(oth);
        }
    }
}
