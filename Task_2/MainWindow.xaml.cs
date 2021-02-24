using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using Task_2.Model;
using static System.String;

namespace Task_2
{
    public partial class MainWindow : Window
    {
        PhoneRepository phones;
        private static readonly Regex _regex = new Regex("[^0-9.-]+");
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }
        public MainWindow()
        {
            InitializeComponent();
            phones = new PhoneRepository();
            phonesList.ItemsSource = phones;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {

            if (IsNullOrWhiteSpace(TextBoxCompany.Text)
                || IsNullOrWhiteSpace(TextBoxTitle.Text)
                || IsNullOrWhiteSpace(TextBoxPrice.Text)
                || IsNullOrWhiteSpace(TextBoxDescription.Text))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            Phone phone = new Phone()
            {
                Title = TextBoxTitle.Text,
                Company = TextBoxCompany.Text,
                Price = TextBoxPrice.Text,
                Description = TextBoxDescription.Text
            };

            this.phones.Add(phone);

            ClearTextBox();
        }

        private void ButtonRemove_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedPhone = phonesList.SelectedItem as Phone;
            phones.Remove(selectedPhone);
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            TextBoxCompany.Text = Empty;
            TextBoxTitle.Text = Empty;
            TextBoxPrice.Text = Empty;
            TextBoxDescription.Text = Empty;
        }

        private void TextBoxPrice_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private void ButtonExit_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
