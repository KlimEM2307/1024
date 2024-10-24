using System;
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

namespace _1024
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var gradientBrush = new LinearGradientBrush(Colors.ForestGreen, Colors.SkyBlue, new Point(0, 0), new Point(1, 1));
            textBox1.Background = gradientBrush;
            textBox2.Background = gradientBrush;
            textBox1.FontFamily = new FontFamily("Times New Roman");
            textBox1.FontSize = 14;
            textBox1.Foreground = Brushes.Purple;
            textBox2.FontFamily = new FontFamily("Times New Roman");
            textBox2.FontSize = 14;
            textBox2.Foreground = Brushes.Purple;
            styleComboBox.Items.Add("Font 1");
            styleComboBox.Items.Add("Font 2");
            styleComboBox.Items.Add("Font 3");
            styleComboBox.SelectedIndex = 0;
            styleComboBox.SelectionChanged += StyleComboBox_SelectionChanged;
            openButton.Click += OpenButton_Click;
            clearButton.Click += ClearButton_Click;
            closeButton.Click += CloseButton_Click;

            UpdateCloseButtonState();
        }

        private void StyleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedStyle = styleComboBox.SelectedItem.ToString();

            switch (selectedStyle)
            {
                case "Font 1":
                    textBox1.FontFamily = new FontFamily("Times New Roman");
                    textBox1.FontSize = 14;
                    textBox1.Foreground = Brushes.Purple;
                    textBox2.FontFamily = new FontFamily("Times New Roman");
      
          textBox2.FontSize = 14;
                    textBox2.Foreground = Brushes.Purple;
                    break;
                case "Font 2":
                    textBox1.FontFamily = new FontFamily("Arial");
                    textBox1.FontSize = 12;
                    textBox1.Foreground = Brushes.LightPink;
                    textBox2.FontFamily = new FontFamily("Arial");
                    textBox2.FontSize = 12;
                    textBox2.Foreground = Brushes.LightPink;
                    break;
                case "Font 3":
                    textBox1.FontFamily = new FontFamily("Calibri");
                    textBox1.FontSize = 24;
                    textBox1.Foreground = Brushes.Yellow;
                    textBox2.FontFamily = new FontFamily("Calibri");
                    textBox2.FontSize = 24;
                    textBox2.Foreground = Brushes.Yellow;
                    break;
            }
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка 'Открыть' нажата.");
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            UpdateCloseButtonState();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void UpdateCloseButtonState()
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                closeButton.IsEnabled = true;
            }
            else
            {
                closeButton.IsEnabled = false;
            }
        }
    }
}