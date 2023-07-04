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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] numbers;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            numbers = Enumerable.Range(1, 10).Select(i => random.Next(1, 100)).ToArray();
            OutputLabel.Content = $"Generated array: {string.Join(", ", numbers)}";
        }

        private void FindMinButton_Click(object sender, RoutedEventArgs e)
        {
            if (numbers == null)
            {
                MessageBox.Show("Пожалуйста, сгенерируйте массив!");
                return;
            }

            int min = int.MaxValue;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                    break;
                if (num < min)
                    min = num;
            }

            OutputLabel.Content = $"Элементы массива: {min}";
        }
    }
}
