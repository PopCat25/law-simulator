using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Law_Simulator
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

        private void chooseCase_button(object sender, RoutedEventArgs e)
        {
            ShowTextWindow window = new ShowTextWindow();
            window.Show();
            Close();
        }


        private void Editor_button(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функция пока в разработке");
        }

        private void Exit_button(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}