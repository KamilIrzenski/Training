using System;
using System.Collections.Generic;
using System.Globalization;
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
using Training;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Data data = new Data(29, 2, 2020);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
         //   textBoxData.Text = data.ToStringDDMMRR();
        }

        private void BtnDzienPlus_Click(object sender, RoutedEventArgs e)
        {
            data.AddDay();
           // textBoxData.Text = data.ToStringDDMMRR();

        }

        private void BtnDzienMinus_Click(object sender, RoutedEventArgs e)
        {
            data.SubtractDay();
            //textBoxData.Text = data.ToStringDDMMRR();
        }

        private void BtnMiesiacPlus_Click(object sender, RoutedEventArgs e)
        {
            data.AddMonth();
            //textBoxData.Text = data.ToStringDDMMRR();
        }

        private void BtnMiesiacMinus_Click(object sender, RoutedEventArgs e)
        {
            data.SubtractMonth();
            //textBoxData.Text = data.ToStringDDMMRR();
        }

        private void BtnRokPlus_Click(object sender, RoutedEventArgs e)
        {
            data.AddYear();
           // textBoxData.Text = data.ToStringDDMMRR();
        }

        private void BtnRokMinus_Click(object sender, RoutedEventArgs e)
        {
            data.SubtractYear();
           // textBoxData.Text = data.ToStringDDMMRR();
        }


        private void BtnWyswietlNaTextBox_Click(object sender, RoutedEventArgs e)
        {
            //data.UstawDate(Convert.ToInt32(dzienTextBox.Text),
            //    miesiacParametr: Convert.ToInt32(miesiacTextBox.Text), rokParametr: Convert.ToInt32(rokTextBox.Text));
            //textBoxData.Text = data.ToStringDDMMRR();
        }
    }
}
