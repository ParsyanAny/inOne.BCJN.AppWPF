namespace HowISeeAbstraction.BCJN
{
    class Journal : PaperCollection
    {
        public override void ForStyle()
        {
            FontSize = "25";
            FontStyle = "Standart";
        }
        public override int PageCount() => WordCount / 350; // It's just an example
    }
}
