namespace AcyclicVisitor.Domain
{
    public class ZoomModem
    {
        public void Accept(ModemVisitor visitor)
        {
            if (visitor is ZoomVisitor zoomVisitor)
                zoomVisitor.Visit(this);
        }

        public int ConfigurationValue { get; set; }
    }
}