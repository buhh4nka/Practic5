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

namespace Practic5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        Pair _firstPair = new Pair();
        Pair _secondPair = new Pair();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП-31. Назаров Д. Вариант 2. \nСоздать класс Pair (пара чисел). Создать необходимые методы и свойства. Определить методы метод сложения полей и операцию сложения пар(а, b) + (с, d)= (а + c, b + d).\nСоздать перегруженные методы для увеличения полей на 1, сложения трех пар чисел.", "О программе");
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void startSum_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addToFirstPair_Click(object sender, RoutedEventArgs e)
        {
            bool isNotErrorInFirst = Int32.TryParse(firstPairFirstNumber.Text, out int firstNumber);
            bool isNotErrorInSecond = Int32.TryParse(firstPairSecondNumber.Text, out int secondNumber);
            if (isNotErrorInFirst && isNotErrorInSecond)
            {
                _firstPair.First = firstNumber;
                _firstPair.Second = secondNumber;
                _firstPair.Add();
                firstPairFirstNumber.Text = _firstPair.First.ToString();
                firstPairSecondNumber.Text = _firstPair.Second.ToString();

            }

        }

        private void addToSecondPair_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
