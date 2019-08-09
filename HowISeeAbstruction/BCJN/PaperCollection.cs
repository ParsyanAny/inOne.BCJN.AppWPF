using System;

namespace HowISeeAbstruction.BCJN
{
    public abstract class PaperCollection : IReadable
    {
        public string Name { get; set;}
        public string Text { get; set; }
        public string FontSize { get; set;}
        public string FontStyle { get; set;}
        public DateTime CreateTime { get; set;}
        public int WordCount { get; set; }

        public class Sizes
        {
            public int Heigth { get; set; }
            public int Width { get; set; }
        }

        public abstract int PageCount();
        public abstract void ForStyle();

        public void Read()
        {
            throw new NotImplementedException(); // You can see how I Implemented it in WPF in next (general) project
        }
    }
}
