using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ParallelLesson
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

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            var options = new ParallelOptions
            {

            };
            //Parallel.Invoke(() => {
            //    Thread.Sleep(5000);
            //    MessageBox.Show(Thread.CurrentThread.ManagedThreadId.ToString());
            //});
            var list = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0
            };
            //Parallel.For(0, list.Count, index =>
            //{
            //    MessageBox.Show(list[index].ToString());
            //});
            Parallel.ForEach(list, item =>
            {
                var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
                MessageBox.Show(item.ToString());
            });
        }
    }
}
