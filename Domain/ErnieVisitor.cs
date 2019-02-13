namespace AcyclicVisitor.Domain
{
    public interface ErnieVisitor: ModemVisitor
    {
        void Visit(ErnieModem ernieModem);
    }
}