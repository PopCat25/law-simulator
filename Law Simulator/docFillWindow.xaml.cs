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
    /// Логика взаимодействия для docFillWindow.xaml
    /// </summary>
    public partial class docFillWindow : Window
    {
        public docFillWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] validateData =   ["Гражданское", "ООО \"Прорыв\"", "Тобольский городской суд",
                                       "Исковое заявление", "Компенсация морального вреда", "Моральный вред"];

            string[] chekedData = [this.proceedType.Text, this.answener.Text, this.jurisdiction.Text, 
                                   this.appealType.Text, this.subject.Text, this.causeBase.Text];

            bool flag = true;
            for(int i = 0; i < validateData.Length; i++)
            {
                if(validateData[i] != chekedData[i])
                {
                    MessageBox.Show($"В поле с ответом {chekedData[i]} - ошибка");
                    flag = false;
                }
            }

            if(flag)
            {
                LastPage window = new LastPage();
                window.Show();
                this.Close();
            }
        }
    }
}
