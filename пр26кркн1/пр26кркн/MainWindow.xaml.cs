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

namespace пр26кркн
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        point point1;//Описали объект точка как глобальный объект
        circle circle1;//Описали объект окружность как глобальный объект
        ellipse ellipse1;//Описали объект эллипс как глобальный объект
        private void Window_Initialized(object sender, EventArgs e)
        {
            //Создаем объект
            point1 = new point(50, 50);
            circle1 = new circle(150, 150, 50, Brushes.Aquamarine, Brushes.Black);
            ellipse1 = new ellipse(200, 200, 50, Brushes.Cyan, Brushes.DarkGray);
        }
        //Задаем новые координаты точки
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            point1.MoveXY(Convert.ToInt32(coordX.Text), Convert.ToInt32(coordY.Text));
        }
        //Задаем новые координаты окружности
        private void okr_Click(object sender, RoutedEventArgs e)
        {
            circle1.MoveXY(Convert.ToInt32(coordX.Text), Convert.ToInt32(coordY.Text));
        }
        //Задаем новые координаты эллипса
        private void ell_Click(object sender, RoutedEventArgs e)
        {
            ellipse1.MoveXY(Convert.ToInt32(coordX.Text), Convert.ToInt32(coordY.Text));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ellipse1.MoveXY(ellipse1.X, ellipse1.Y - 5);
        }

        private void left_Click(object sender, RoutedEventArgs e)
        {
            ellipse1.MoveXY(ellipse1.X - 5, ellipse1.Y);
        }

        private void down_Click(object sender, RoutedEventArgs e)
        {
            ellipse1.MoveXY(ellipse1.X, ellipse1.Y + 5);
        }

        private void right_Click(object sender, RoutedEventArgs e)
        {
            ellipse1.MoveXY(ellipse1.X + 5, ellipse1.Y);
        }
    }
}

