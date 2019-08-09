using InOne.BCJN.Application.BCJN;
using System;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace InOne.BCJN.AppWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NoteBookStyle();
        }
        #region Events
            #region WriteMenuEvents
        private void WriteCopyBook_Click(object sender, RoutedEventArgs e)
        {
            ClearRichTextBox();
            Saveable(true);
            MyText.IsReadOnly = false;
            CopyBookStyle();
        }

        private void WriteNoteBook_Click(object sender, RoutedEventArgs e)
        {
            ClearRichTextBox();
            Saveable(true);
            MyText.IsReadOnly = false;
            NoteBookStyle();
        }
             #endregion
        #region ExitAndSave Events
        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void SaveasButtonEvent(object sender, RoutedEventArgs e)
        {
            IWritable cb = new NoteBook();
            var content = new TextRange(MyText.Document.ContentStart, MyText.Document.ContentEnd).Text;
            cb.Saveas(content);
        }
        #endregion
        #region Open...BCJN
        private void OpenBook_Click(object sender, RoutedEventArgs e)
        { 
            ClearRichTextBox();
            Book book = new Book();
            OpenFile(book);
            BookStyle();
        }
        private void OpenCopyBook_Click(object sender, RoutedEventArgs e)
        {
            ClearRichTextBox();
            CopyBook cb = new CopyBook();
            OpenFile(cb);
            CopyBookStyle();
        }
        private void OpenJournal_Click(object sender, RoutedEventArgs e)
        {
            ClearRichTextBox();
            Journal journal = new Journal();
            OpenFile(journal);
            JournalStyle();
        }
        private void OpenNoteBook_Click(object sender, RoutedEventArgs e)
        {
            ClearRichTextBox();
            NoteBook nb = new NoteBook();
            OpenFile(nb);
            NoteBookStyle();
        }
        #endregion
        #endregion
        #region ForConvenience
        private void ClearRichTextBox()
        {
            MyText.Document.Blocks.Clear();
        }
        private void OpenFile(Paper p)
        {
            MyText.Document.Blocks.Add(new Paragraph(new Run(p.Read())));
            if (p is IWritable)
            {
                MyText.IsReadOnly = false;
                Saveable(true);
                if (p is CopyBook) CopyBookStyle();
                else NoteBookStyle();
            }
            else
            {
                MyText.IsReadOnly = true;
                Saveable(false);
                pageCount.Visibility = Visibility.Visible;
            }
        }
        private void Saveable(bool saveable)
        {
            if (!saveable)
                SaveablePart.Visibility = Visibility.Collapsed;
            else
                SaveablePart.Visibility = Visibility.Visible;
        }
        #endregion
        #region Styles   // add some difirentation
        private void BookStyle()
        {
            CommonStyle();
            MyText.FontFamily = new FontFamily("Luminari");
            MyText.FontSize = 16;
            ImageFor.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Book.jpg"));
            MyText.AppendText("/t");
            MyMainWindow.Title = "Book";
        } 
        private void CopyBookStyle()
        {
            CommonStyle();
            MyText.FontSize = 15;
            MyText.FontFamily = new FontFamily("Trattatello");
            ImageFor.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/CopyBook.jpg"));
            MyMainWindow.Title = "Copybook";
        }
        private void JournalStyle()
        {
            CommonStyle();
            MyText.Foreground = Brushes.White;
            MyText.FontSize = 13;
            MyText.FontStyle = FontStyles.Normal;
            MyText.FontFamily = new FontFamily("Times New Roman");
            
            ImageFor.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Journal.jpg"));
            MyMainWindow.Title = "Journal";
        }
        private void NoteBookStyle()
        {
            CommonStyle();
            MyText.FontSize = 17;
            MyText.FontFamily = new FontFamily("Trattatello");
            ImageFor.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/NoteBook.jpg"));
            MyMainWindow.Title = "Notebook";
        }
        public void CommonStyle()
        {
            MyText.Foreground = Brushes.Black;
            MyText.FontStyle = FontStyles.Oblique;
            MyText.FontFamily = new FontFamily("Century Gothic");
            MyMenu.Background = Brushes.Black;
            MyMenu.Foreground = Brushes.AntiqueWhite;
            SaveablePart.Background = Brushes.Black;
            saveButton.Background = Brushes.Black;
            saveButton.Foreground = Brushes.AntiqueWhite;
            #region MenuItemsColor
            openBook.Background = Brushes.Black;
            openJournal.Background = Brushes.Black;
            openNoteBook.Background = Brushes.Black;
            openCopyBook.Background = Brushes.Black;
            writeCopyBook.Background = Brushes.Black;
            writeNoteBook.Background = Brushes.Black;
            #endregion
            pageCount.Foreground = Brushes.AntiqueWhite;
        }
        #endregion
    }
}
