using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Task_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LogsList _logsList;
        public MainWindow()
        {
            InitializeComponent();
            _logsList = new LogsList();
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        private void ListView1_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Log current = listView1.SelectedItem as Log;
            if (current != null)
            {
                string result = $"{current.Type}: {current.Source} : {current.Date}\n {current.Error} ";

                TextBoxRes.Text = result;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listView1.ClearValue(ItemsControl.ItemsSourceProperty);
            TextBoxRes.Text = "";
        }
    }
}
