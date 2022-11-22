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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int check;
        public int Check { get; set; }
        public void CheckRemove()
        {
            check++;
            b1.Click += Button_Click;
        }

        public MainWindow()
        {
            InitializeComponent();
            b1.Click += Button_Click;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            b1.Content = Convert.ToString(check);

            CheckRemove();
        }
    }
}
