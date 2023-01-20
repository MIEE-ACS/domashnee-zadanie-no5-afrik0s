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

namespace DZ5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    class Vagon
    {
        int number; // Номер рейса
        int sit; // Время вылета Дни недели 
        int lie; // Время вылета Дни недели         

        public Vagon( int n, int s, int l)
        {
            number = n;
            sit = s;
            lie = l;
        }
        public void setSit(int s)
        {
            sit = s;
        }
        public int getSit()
        {
            return sit;
        }
        public void setLie(int l)
        {
            lie = l;
        }
        public int getLie()
        {
            return lie;
        }
        public void setNumber(int n)
        {
            number = n;
        }
        public int getNumber()
        {
            return number;
        }
        public string info()
        {
            return String.Format("\n\tНомер вагона: {0}\tКоличество общих мест: {1}\tКоличество общих мест: {2}\n", number, sit, lie);
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Vagon[] vagon = new Vagon[6];
            vagon[0] = new Vagon(1, 17, 10);
            vagon[1] = new Vagon(2, 0, 30);
            vagon[2] = new Vagon(3, 12, 20);
            vagon[3] = new Vagon(4, 60, 0);
            vagon[4] = new Vagon(5, 24, 7);
            vagon[5] = new Vagon(6, 40, 10);
            for (int i = 0; i < 6; i++)
                tb1.Text = tb1.Text + String.Format(vagon[i].info());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Vagon[] vagon = new Vagon[6];
            vagon[0] = new Vagon(1, 17, 10);
            vagon[1] = new Vagon(2, 0, 30);
            vagon[2] = new Vagon(3, 12, 20);
            vagon[3] = new Vagon(4, 60, 0);
            vagon[4] = new Vagon(5, 24, 7);
            vagon[5] = new Vagon(6, 40, 10);
            int sum = 0, max = 0;
            for (int i = 0; i < 6; i++)
                if (sum < vagon[i].getSit() + vagon[i].getLie())
                {
                    max = i;
                    sum = vagon[i].getSit() + vagon[i].getLie();
                }
            tb2.Text = tb2.Text + String.Format(vagon[max].info());
        }
    }
}
