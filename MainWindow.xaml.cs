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

namespace Var22
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

        private void btnVyp_Click(object sender, RoutedEventArgs e)
        {
            Class a = new Class();
            a.Kolvo =txtProv.Text;
            if (a.isTempIce() != "0")
            {
                MessageBox.Show("Мы нашли в лесу " + txtProv.Text + " гри" + a.isTempIce());
            }
            else
            {
                MessageBox.Show("Мы нашли в лесу ничего не нашли");
            }
        }
    }
}
