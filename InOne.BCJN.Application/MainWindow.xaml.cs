using System.Windows;
using System.Windows.Documents;

namespace InOne.BCJN.AppWPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyText.Document.Blocks.Add(new Paragraph(new Run(Journal.Read())));
        }


        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();

        }
        private void MenuItemSave_Click(object sender, RoutedEventArgs e)
        {
            NoteBook.Save(TextSave.Text);
        }
    }
}
