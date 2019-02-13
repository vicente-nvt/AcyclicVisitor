namespace AcyclicVisitor.Domain
{
    public class UnixModemConfigurator: HayesVisitor, ZoomVisitor, ErnieVisitor
    {
        public void Visit(HayesModem hayesModem)
        {
            hayesModem.ConfigurationString = "&s1=4&D=3";
        }

        public void Visit(ZoomModem zoomModem)
        {
            zoomModem.ConfigurationValue = 42;
        }

        public void Visit(ErnieModem ernieModem)
        {
            ernieModem.InternalPattern = "C is too slow";
        }
    }
}