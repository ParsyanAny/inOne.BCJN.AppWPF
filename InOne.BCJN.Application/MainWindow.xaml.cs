using InOne.BCJN.Application.BCJN;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml;

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
            CopyBookStyle();
        }
        #region Events
        #region WriteMenuEvents
        private void WriteCopyBook_Click(object sender, RoutedEventArgs e)
        {
            ClearRichTextBox();
            Saveable(true);
            CopyBookStyle();
        }

        private void WriteNoteBook_Click(object sender, RoutedEventArgs e)
        {
            ClearRichTextBox();
            Saveable(true);
            NoteBookStyle();
        }
        #endregion
        #region ExitAndSave Events
        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();

        }
        private void MenuItemSave_Click(object sender, RoutedEventArgs e)
        {
            IWritable cb = new NoteBook();
            var content = new TextRange(MyText.Document.ContentStart, MyText.Document.ContentEnd).Text;
            if (TextSave.Text != null)
                cb.Saveas(TextSave.Text, content);
        }
        #endregion
        #region Open...BCJN
        private void OpenBook_Click(object sender, RoutedEventArgs e)
        {
            ClearRichTextBox();
            Book book = new Book();
            OpenFile(book);
            BookStyle();
            //string pageC = book.PageCount().ToString();
            //pageCount.Content = $"Word count {book.WordCount} Page count {pageC}";
        }
        private void OpenCopyBook_Click(object sender, RoutedEventArgs e)
        {
            ClearRichTextBox();
            CopyBook cb = new CopyBook();
            OpenFile(cb);
            CopyBookStyle();
            //string pageC = cb.PageCount().ToString();
            //pageCount.Content = $"Word count {cb.WordCount} Page count {pageC}";
        }
        private void OpenJournal_Click(object sender, RoutedEventArgs e)
        {
            ClearRichTextBox();
            Journal journal = new Journal();
            OpenFile(journal);
            JournalStyle();
           // string pageC = journal.PageCount().ToString();
           // pageCount.Content = $"Word count {journal.WordCount} Page count {pageC}";
        }
        private void OpenNoteBook_Click(object sender, RoutedEventArgs e)
        {
            ClearRichTextBox();
            NoteBook nb = new NoteBook();
            OpenFile(nb);
            NoteBookStyle();
            //string pageC = nb.PageCount().ToString();
            //pageCount.Content = $"Word count {nb.WordCount} Page count {pageC}";
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
        #region Styles
        private void BookStyle()
        {
            CommonStyle();
            ImageFor.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/1.png"));
            MyText.AppendText("/t");
            MyMainWindow.Title = "Book";
        } // fix pic
        private void CopyBookStyle()
        {
            CommonStyle();
            ImageFor.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/3.jpg"));
            MyMainWindow.Title = "Copybook";
        }
        private void JournalStyle()
        {
            CommonStyle();
            ImageFor.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/5.jpg"));
            MyMainWindow.Title = "Journal";
        }
        private void NoteBookStyle()
        {
            CommonStyle();
            ImageFor.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/6.jpg"));
            MyMainWindow.Title = "Notebook";
            
        }
        public void CommonStyle()
        {
            MyMenu.Background = Brushes.Black;
            MyMenu.Foreground = Brushes.AntiqueWhite;
            SaveablePart.Background = Brushes.Black;
            saveLabel.Background = Brushes.Black;
            saveLabel.Foreground = Brushes.AntiqueWhite;
            saveButton.Background = Brushes.Black;
            saveButton.Foreground = Brushes.AntiqueWhite;
            TextSave.Background = Brushes.AntiqueWhite;
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
