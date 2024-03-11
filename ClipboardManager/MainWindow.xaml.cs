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
using Wpf.Ui.Controls;

namespace ClipboardManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rtb.Document.Blocks.Clear();
            rtb.Document.Blocks.Add(new Paragraph(new Run(Clipboard.GetText())));
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void erase_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(" ");
            rtb.Document.Blocks.Clear();
            System.Windows.MessageBox.Show("Text byl vymazán.", "Vymazání textu", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Information);
        }

        private void copy_Click(object sender, RoutedEventArgs e)
        {
            string richText = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd).Text;
            Clipboard.SetText(richText);
            System.Windows.MessageBox.Show("Text byl zkopírován.", "Kopírování textu", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Information);
        }
    }
}