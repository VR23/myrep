﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
using System.Diagnostics;


namespace MathProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculation(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
            myAL.Sort();
            lbMain.Items.Add("Отсортированный массив");
            foreach (int elem in myAL)
            {
                lbMain.Items.Add(elem);
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog myDialog = new Microsoft.Win32.SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lbMain.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            lbMain.Items.Clear();
            tbN.Text = null;
        }

        private void go_Click(object sender, RoutedEventArgs e)
        {
            Random rnd1 = new Random();
            int m = 0;            
            //int k = Convert.ToInt32(tbN.Text);
            if (Convert.ToInt32(comboBox1.Text) == 1)
            {
                int[] arr = new int[10];
                for (int i = 0; i <= 9; i++)
                {
                    arr[i] = -100 + rnd1.Next(200);
                }
                for (int i = 0; i <= 9; i++)
                {
                    lbMain.Items.Add(arr[i]);
                }
                for (int i = 1; i <= 8; i++)
                {
                    if ((arr[i] > arr[i - 1]) & (arr[i] > arr[i + 1]))
                    {
                        m++;
                    }
                }
                lbMain.Items.Add("Число элементов больших своих соседей=");
                lbMain.Items.Add(m);

            }
            if (Convert.ToInt32(comboBox1.Text) == 2)
            {
                int[] arr = new int[10];
                for (int i = 0; i <= 9; i++)
                {
                    arr[i] = -100 + rnd1.Next(200);
                }
                for (int i = 0; i <= 9; i++)
                {
                    lbMain.Items.Add(arr[i]);
                }
                for (int i = 0; i <= 9; i++)
                {
                    if (arr[i] > 25)
                    {
                        m = i;
                        break;
                    }
                }
                lbMain.Items.Add("Первый элемент больший 25=");
                lbMain.Items.Add(m + 1);

            }
            if (Convert.ToInt32(comboBox1.Text) == 3)
            {
                int[] arr = new int[10];
                int c=0;
                for (int i = 0; i <= 9; i++)
                {
                    arr[i] = -100 + rnd1.Next(200);
                }
                for (int i = 0; i <= 9; i++)
                {
                    lbMain.Items.Add(arr[i]);
                }
                for (int i = 0; i <= 9; i++)
                {
                    if (arr[i] > arr[2])
                    {
                        c = c + arr[i];
                    }
                }
                lbMain.Items.Add("Сумма элементов больших второго элемента=");
                lbMain.Items.Add(c);

            }
            if (Convert.ToInt32(comboBox1.Text) == 4)
            {
                int[] arr = new int[10];
                double srzn = 0;
                int c = 0;
                for (int i = 0; i <= 9; i++)
                {
                    arr[i] = -100 + rnd1.Next(200);
                }
                for (int i = 0; i <= 9; i++)
                {
                    lbMain.Items.Add(arr[i]);
                }
                for (int i = 0; i <= 9; i++)
                {
                    srzn = srzn + arr[i];
                    c = arr[0];

                }
                srzn = srzn / 10;
                if (c > srzn)
                {
                    lbMain.Items.Add("Первый элемент больше среднего значения");
                }
                else
                {
                    lbMain.Items.Add("Первый элемент меньше среднего значения");
                }

            }
            if (Convert.ToInt32(comboBox1.Text) == 5)
            { //gde nugno e
                int[] arr = new int[10];
                int smen = 0;
                for (int i = 0; i <= 9; i++)
                {
                    arr[i] = -100 + rnd1.Next(200);
                }
                for (int i = 0; i <= 9; i++)
                {
                    lbMain.Items.Add(arr[i]);
                }
                int temp = 0;
                if (arr[0] > 0) temp = 0;
                else temp = 1;


                for (int i = 0; i < 9; i++)
                {
                    if (arr[i] > 0)
                    {
                        if (temp == 1)
                        {
                            //temp = 1;
                        }
                        else
                        {
                            smen++;
                            temp = 1;
                        }
                    }
                    else
                    {
                        if (temp == 0)
                        {
                            //smen++;
                        }
                        else
                        {
                            smen++;
                            temp = 0;
                        }
                    }

                }

                smen--;
                lbMain.Items.Add("Количество смен знака=");   
                lbMain.Items.Add(smen);               
                
            }
            if (Convert.ToInt32(comboBox1.Text) == 6)
            {
                int[] arr = new int[10];
                int c = 0;
                for (int i = 0; i <= 9; i++)
                {
                    arr[i] = -100 + rnd1.Next(200);
                }
                for (int i = 0; i <= 9; i++)
                {
                    lbMain.Items.Add(arr[i]);
                }
                for (int i = 0; i <= 9; i++)
                {
                    if (arr[i] > arr[3])
                    {
                        c++;
                    }
                }
                lbMain.Items.Add("Количество элементов больших четвертого элемента=");
                lbMain.Items.Add(c);
            }
            if (Convert.ToInt32(comboBox1.Text) == 7)
            {
                int[] arr = new int[10];
                int c = 0;
                for (int i = 0; i <= 9; i++)
                {
                    arr[i] = -100 + rnd1.Next(200);
                }
                for (int i = 0; i <= 9; i++)
                {
                    lbMain.Items.Add(arr[i]);
                }
                for (int i = 0; i <= 9; i++)
                {
                    if (arr[i] < 21)
                    {
                        c=c+arr[i];
                    }
                }
                lbMain.Items.Add("Сумма элементов меньших 21=");
                lbMain.Items.Add(c);
            }
            if (Convert.ToInt32(comboBox1.Text) == 8)
            {
                int[] arr = new int[10];
                int c = 0;
                for (int i = 0; i <= 9; i++)
                {
                    arr[i] = -100 + rnd1.Next(200);
                }
                for (int i = 0; i <= 9; i++)
                {
                    lbMain.Items.Add(arr[i]);
                }
                for (int i = 0; i <= 9; i++)
                {
                    if (arr[i]%5==0)
                    {
                        arr[i]++; 
                    }
                }
                lbMain.Items.Add("Новый массив=");
                for (int i = 0; i <= 9; i++)
                {
                    lbMain.Items.Add(arr[i]);
                }
            }
            if (Convert.ToInt32(comboBox1.Text) == 9)
            {
                int[] arr = new int[10];
                int c = 0;
                for (int i = 0; i <= 9; i++)
                {
                    arr[i] = -100 + rnd1.Next(200);
                }
                for (int i = 0; i <= 9; i++)
                {
                    lbMain.Items.Add(arr[i]);
                }
                for (int i = 0; i <= 9; i++)
                {
                    if (arr[i] % 3 != 0)
                    {
                        c = c + arr[i];
                    }
                }
                lbMain.Items.Add("Сумма элементов не кратных 3=");
                lbMain.Items.Add(c);
            }
            if (Convert.ToInt32(comboBox1.Text) == 10)
            {
                int[] arr = new int[10];
                int c = 0;
                for (int i = 0; i <= 9; i++)
                {
                    arr[i] = -100 + rnd1.Next(200);
                }
                for (int i = 0; i <= 9; i++)
                {
                    lbMain.Items.Add(arr[i]);
                }
                for (int i = 1; i <= 8; i++)
                {
                    if (arr[i] < arr[1] && arr[i] > arr[9])
                    {
                        c++;
                    }
                }
                lbMain.Items.Add("Количество элементов,меньших первого и больших последнего одновременно=");
                lbMain.Items.Add(c);
            }
            if (Convert.ToInt32(comboBox1.Text) == 11)
            {
                int[] arr = new int[10];
                int c = 0;
                for (int i = 0; i <= 9; i++)
                {
                    arr[i] = -100 + rnd1.Next(200);
                }
                for (int i = 0; i <= 9; i++)
                {
                    lbMain.Items.Add(arr[i]);
                }
                for (int i = 0; i <= 9; i++)
                {
                    if (arr[i] > 0 || arr[i] == 0)
                    {
                        c++;
                    }
                }
                lbMain.Items.Add("Количество неотрицательных элементов массива=");
                lbMain.Items.Add(c);
            }
            if (Convert.ToInt32(comboBox1.Text) == 12)
            {
                double[] arr = new double[10];
                int c = 0;

                for (int i = 0; i <= 9; i++)
                {
                    arr[i] = rnd1.NextDouble()*10;
                }
                for (int i = 0; i <= 9; i++)
                {
                    lbMain.Items.Add(arr[i]);
                }
                for (int i = 0; i <= 9; i++)
                {
                    if ((Math.Abs(arr[i]) - Math.Abs(arr[1])<0.5)&& (Math.Abs(arr[i]) - Math.Abs(arr[1])>-0.5))
                    {
                        lbMain.Items.Add("элемент, меньше всего отличающий­ся от второго-");
                        lbMain.Items.Add(arr[i]);
                    }
                }
               
            }
            if (Convert.ToInt32(comboBox1.Text) == 13)
            {
                int[] arr = new int[10];
                int c = 0;

                for (int i = 0; i <= 9; i++)
                {
                    arr[i] = -10 + rnd1.Next(20);
                }
                for (int i = 0; i <= 9; i++)
                {
                    lbMain.Items.Add(arr[i]);
                }
                for (int i = 0; i <= 9; i++)
                {
                    if (arr[i]!=0)
                    {
                        c++;
                    }
                }
                lbMain.Items.Add("Количество ненулевых элементов массива=");
                lbMain.Items.Add(c);

            }

            if (Convert.ToInt32(comboBox1.Text) == 16)
            {
                
                Process.Start("C:\\Users\\Глебушка\\Desktop\\тп\\WindowsFormsApplication1\\WindowsFormsApplication1\\bin\\Debug\\WindowsFormsApplication1.exe");
            }
        }              
    }
}
