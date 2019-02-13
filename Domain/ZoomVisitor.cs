namespace AcyclicVisitor.Domain
{
    public interface ZoomVisitor: ModemVisitor
    {
        void Visit(ZoomModem zoomModem);
    }
}