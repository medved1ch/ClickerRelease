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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        long point = 0; 
        int inter = 1;
        static int point_on_Click = 1;
        int timer_afk = 1;
        int tik = 1;
        //int n = 1;
        double sol_1 = 10+ 10 * (10 + point_on_Click * 0.2);//up1
        double sol_2 = 20 + 10 * (30 + point_on_Click * 0.2);//up2
        double sol_3 = 25 + 10 * (30 + point_on_Click * 0.2);//up2
        double sol_4 = 30 + 10 * (30 + point_on_Click * 0.2);//up2
        double sol_5 = 35 + 10 * (30 + point_on_Click * 0.2);//up2
        double sol_6 = 40 + 10 * (30 + point_on_Click * 0.2);//up2
        double sol_7 = 45 + 10 * (30 + point_on_Click * 0.2);//up2
        double sol_8 = 50 + 10 * (30 + point_on_Click * 0.2);//up2
        double sol_9 = 10 + 5 + (point_on_Click * 0.3);//up2
        double sol_10 = 30 + 5 + (point_on_Click * 0.3);//up2
        double afk_1 = 50; //+ point_on_Click * 0.3);


        public MainWindow() //timer
        {

            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(inter);
            timer.Tick += Timer_Tick;
            timer.Start();
            Update();
        }
        public void Update() //infi point
        {
            pnt.Content = "Points " + point;
            Points_per_Click.Content = $"Points_per_Click  {point_on_Click}";
            Lb1_bt1.Content = (sol_1).ToString();
            Lb1_bt1_Copy.Content = (sol_2).ToString();
            Lb1_bt1_Copy.Content = (sol_3).ToString();
            Lb1_bt1_Copy1.Content = (sol_4).ToString();
            Lb1_bt1_Copy2.Content = (sol_5).ToString();
            Lb1_bt1_Copy3.Content = (sol_6).ToString();
            Lb1_bt1_Copy4.Content = (sol_7).ToString();
            Lb2_bt2.Content = (sol_8).ToString();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)//click
        {
            point += point_on_Click;
            Update();
        }

        private void Button_Click(object sender, RoutedEventArgs e)//up1
        {
            if (point>=(sol_1))
            {
                point -= Convert.ToInt64(Math.Round(sol_1));
                point_on_Click += 3;
                Update();
               

            } else
            {
                MessageBox.Show("Malo");
            }
        }

       
        private void Timer_Tick(object sender, EventArgs e)
        {
            point += timer_afk;
            Update();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//up2
        {
            if (point >= (sol_2))
            {
                point -= Convert.ToInt64(Math.Round(sol_1));
                point_on_Click += 5;
                Update();
               

            }
            else
            {
                MessageBox.Show("Malo");
            }
        }



        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_3))
            {
                point -= Convert.ToInt64(Math.Round(sol_1));
                point_on_Click += 25;
                Update();


            }
            else
            {
                MessageBox.Show("Malo");
            }
        }

        private void bt1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_4))
            {
                point -= Convert.ToInt64(Math.Round(sol_1));
                point_on_Click += 50;
                Update();


            }
            else
            {
                MessageBox.Show("Malo");
            }
        }

        private void bt1_Copy2_Click(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_5))
            {
                point -= Convert.ToInt64(Math.Round(sol_1));
                point_on_Click += 66;
                Update();


            }
            else
            {
                MessageBox.Show("Malo");
            }
        }

        private void bt1_Copy3_Click(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_6))
            {
                point -= Convert.ToInt64(Math.Round(sol_1));
                point_on_Click += 80;
                Update();


            }
            else
            {
                MessageBox.Show("Malo");
            }
        }

        private void bt1_Copy4_Click(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_7))
            {
                point -= Convert.ToInt64(Math.Round(sol_1));
                point_on_Click += 100;
                Update();


            }
            else
            {
                MessageBox.Show("Malo");
            }
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_8))
            {
                point -= Convert.ToInt64(Math.Round(sol_1));
                point_on_Click += 200;
                Update();


            }
            else
            {
                MessageBox.Show("Malo");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            point += point_on_Click;
            Update();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_9))
            {
                point -= Convert.ToInt64(Math.Round(sol_1));
                point_on_Click += 5;
                Update();


            }
            else
            {
                MessageBox.Show("Malo");
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_10))
            {
                point -= Convert.ToInt64(Math.Round(sol_1));
                point_on_Click += 10;
                Update();


            }
            else
            {
                MessageBox.Show("Malo");
            }
        }
    }
}
