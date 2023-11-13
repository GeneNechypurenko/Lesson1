using System.Windows;

namespace Lesson1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private decimal total;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            total += decimal.Parse(valueTextBox.Text);
            outputLabel.Content = "total: " + total.ToString("C");
        }
    }
}
