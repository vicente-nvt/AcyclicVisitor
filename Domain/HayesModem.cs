namespace AcyclicVisitor.Domain
{
    public class HayesModem
    {
        public string ConfigurationString;

        public void Accept(ModemVisitor visitor)
        {
            if (visitor is HayesVisitor hayesVisitor)
                hayesVisitor.Visit(this);
        }
    }
}