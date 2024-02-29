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
using System.Windows.Shapes;

namespace Law_Simulator
{
    /// <summary>
    /// Логика взаимодействия для ShowTextWindow.xaml
    /// </summary>
    public partial class ShowTextWindow : Window
    {
        public ShowTextWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Ваше мнение ошибочно. В соответсвии со ст.392 ТК РФ иск о возмещении" +
                "морального вреда может быть заявлен в течении 3 месяцев со дня восстановления на работе."
                );
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Да, это вполне возможно сделать. Но для исков о возмещении " +
                "морального вреда необязательно соблюдение претензионного порядка"
                );
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            docFillWindow window = new docFillWindow();
            window.Show();
            Close();
        }
    }
}
