namespace AcyclicVisitor.Domain
{
    public interface HayesVisitor: ModemVisitor
    {
        void Visit(HayesModem hayesModem);
    }
}