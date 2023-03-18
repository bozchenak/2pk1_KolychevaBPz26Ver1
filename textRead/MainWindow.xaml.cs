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

namespace textRead
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
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            MessageBox.Show(textBox.Text);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox1.SelectionStart = 5;
            textBox1.SelectionLength = 10;
            textBox1.Focus();
            // данное выражение эквивалентно
            //textBox1.Select(5, 10);
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            MessageBox.Show(menuItem.Header.ToString());
        }
        public CreateFileWindow()
        {
            InitializeComponent();
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        public string FileName
        {
            get { return fileNameBox.Text; }
        }
        private void newFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CreateFileWindow createFileWindow = new CreateFileWindow();
            if (createFileWindow.ShowDialog() == true)
                filename = createFileWindow.FileName;
        }
    }
}
