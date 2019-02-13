namespace AcyclicVisitor.Domain
{
    public class ErnieModem
    {
        public string InternalPattern { get; set; }

        public void Accept(ModemVisitor visitor)
        {
            if (visitor is ErnieVisitor ernieVisitor)
                ernieVisitor.Visit(this);
        }
    }
}