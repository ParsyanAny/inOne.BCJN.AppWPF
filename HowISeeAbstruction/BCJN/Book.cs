namespace HowISeeAbstraction.BCJN
{
    class Book : PaperCollection
    {
        public override void ForStyle()
        {
            FontSize = "32";
            FontStyle = "Italian";
        }

        public override int PageCount() => WordCount / 500; // It's just an example
    }
}
