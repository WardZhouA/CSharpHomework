using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //主程序循环
            for (int i = 0; i == 0;)
            {
                Console.WriteLine("Hello,world");
                
                //HomeWork.RankStu();
                //HomeWork.PrintTower();
                //TeacherMotified.PrintTower();
                HomeWork.RankThreeNumber();
                //HomeWork.PrintCompositeNumber();
                //HomeWork.PrintEvenNumber();
                //HomeWork.CountMaxAndMin();

                Console.ReadLine();
            }
        }
    }
    class HomeWork
    {
        static public void PrintTower()
        {
            char chr1;
            chr1 = (char)65;
            string temp = chr1.ToString();
            string space1 = "   ";
            string space2 = "  ";
            string space3 = " ";


            Console.WriteLine(space1 + chr1);
            chr1++;
            Console.WriteLine(space2 + chr1 + chr1 + chr1);
            chr1++;
            Console.WriteLine(space3 + chr1 + chr1 + chr1 + chr1 + chr1);
            chr1++;
            Console.WriteLine("" + chr1 + chr1 + chr1 + chr1 + chr1 + chr1 + chr1 + chr1);
            chr1++;


        }
        static public void RankStu()
        {
            double grade;
            grade = Convert.ToDouble(Console.ReadLine());
            if (grade < 0)
            {
                Console.WriteLine("数值超出预期");
            }
            else if (grade < 60)
            {
                Console.WriteLine("不及格");
            }
            else if (grade <= 70)
            {
                Console.WriteLine("及格");
            }
            else if (grade <= 80)
            {
                Console.WriteLine("差");
            }
            else if (grade <= 90)
            {
                Console.WriteLine("中");
            }
            else if (grade <= 95)
            {
                Console.WriteLine("良");
            }
            else if (grade <= 100)
            {
                Console.WriteLine("优");
            }
            else
            {
                Console.WriteLine("数值超出预期");
            }
        }
        static public void RankThreeNumber()
        {
            Console.Write("Please Enter the Amount:");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            double[] imput = new double[x];
            double[] output = new double[x];
            double temp;

            //输入
            for (int a = 0; a < x; a++)
            {
                Console.Write("Please Enter the number:");
                imput[a] = Convert.ToDouble(Console.ReadLine());
            }

            for (int j = 0; j < imput.Length - 1; j++)
            {

                for (int i = 0; i < imput.Length - 1 - j; i++)
                {
                    //拿到最小值
                    if (imput[i] > imput[i + 1])
                    {
                        temp = imput[i];
                        imput[i] = imput[i + 1];
                        imput[i + 1] = temp;
                    }
                }
            }
            output = imput;
            //输出
            for (int a = 0; a < x; a++)
            {
                Console.WriteLine(output[a]);
            }
            double max = imput[x - 1];
            double min = imput[0];
            Console.WriteLine("Max={0}", max);
            Console.WriteLine("Min={0}", min);

        }
        static public void PrintCompositeNumber()
        {
            int left, right;
            re:
            {
                Console.WriteLine("请分别输入范围端点，回车分开:");
                left = Convert.ToInt32(Console.ReadLine());
                right = Convert.ToInt32(Console.ReadLine());
            }
            if (right < left)
            {
                Console.WriteLine("输入有误，请重新输入");
                goto re;
            }
            for (int i = left; i <= right; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }

        }
        static public void PrintEvenNumber()
        {
            int left, right;
            int count = 0;
            int amount;
            Console.WriteLine("请输入想要得到的个数:");
            amount = Convert.ToInt32(Console.ReadLine());
            re:
            {
                Console.WriteLine("请分别输入范围端点，回车分开:");
                left = Convert.ToInt32(Console.ReadLine());
                right = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            if (right < left)
            {
                goto re;
            }
            for (int i = left; i <= right; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    count++;
                }
                if (count > amount)
                {
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("所给条件没有结果");
            }
            else if (count < amount)
            {
                Console.WriteLine("只有这么多哟(＾Ｕ＾)ノ~ＹＯ");
            }
        }
        static public void CountMaxAndMin()
        {
            Console.Write("请输入学生总数：");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            double[] imput = new double[x];
            double[] output = new double[x];
            double temp;

            //输入
            for (int a = 0; a < x; a++)
            {
                Console.Write("请输入学生成绩:");
                imput[a] = Convert.ToDouble(Console.ReadLine());
            }

            for (int j = 0; j < imput.Length - 1; j++)
            {

                for (int i = 0; i < imput.Length - 1 - j; i++)
                {
                    //拿到最小值
                    if (imput[i] > imput[i + 1])
                    {
                        temp = imput[i];
                        imput[i] = imput[i + 1];
                        imput[i + 1] = temp;
                    }
                }
            }
            //遍历统计
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;
            foreach (double a in imput)
            {
                if (a <= 60)
                {
                    D++;
                }
                else
                {
                    switch ((int)a / 10)
                    {
                        case 6: break;
                        case 7: C++; break;
                        case 8: B++; break;
                        case 9: A++; break;
                    }
                }
            }
            //最值
            double max = imput[x - 1];
            double min = imput[0];

            //输出
            Console.WriteLine("优秀={0}", A);
            Console.WriteLine("良好={0}", B);
            Console.WriteLine("及格={0}", C);
            Console.WriteLine("不及格={0}", D);
            Console.WriteLine("Max={0}", max);
            Console.WriteLine("Min={0}", min);

        }
    }
    class TeacherMotified
    {
        static public void PrintTower()
        {
            char ch = 'A';
            char space = ' ';
            int count = 3;
            for (int i = 0; i < 4; i++)
            {
                for (int h = 0; h < count; h++)
                {
                    Console.Write(space);
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write(ch);
                }

                Console.Write('\n');
                count--;
                ch++;
            }
        }
    }
}
