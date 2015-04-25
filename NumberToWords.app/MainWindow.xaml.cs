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

namespace NumberToWords.app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ComboBox_init();

        }

        private void Button_Click(object sender, EventArgs e)
        {
            int number = GetNumber();
            string culture = GetCultureString();

            textbox2.Text = Humanizer.NumberToWordsExtension.ToWords(number, new System.Globalization.CultureInfo(culture));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void ComboBox_init()
        {
            combobox.Items.Add("English");
            combobox.Items.Add("Italian");
            combobox.Items.Add("French");
            combobox.Items.Add("German");
            combobox.Items.Add("Polish");
            combobox.Items.Add("Spanish");
        }

        private int GetNumber()
        {
            int number;

            if (Int32.TryParse(textbox1.Text, out number)) 
            {
                return number;
            }
            else
            {
                throw new Exception("Invalid string to convert");
            }
        }

        private string GetCultureString()
        {
            string culture = combobox.SelectedItem.ToString();
            switch (culture)
            {
                case "Italian":
                    return "it";
                case "French":
                    return "fr";
                case "German":
                    return "de";
                case "Polish":
                    return "pl";
                case "Spanish":
                    return "es";
                default:
                    return "en";
            }
        }
    }
}
