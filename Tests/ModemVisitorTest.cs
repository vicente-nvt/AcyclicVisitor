using AcyclicVisitor.Domain;
using Xunit;

namespace AcyclicVisitor.Tests
{
    public class ModemVisitorTest
    {
        private readonly UnixModemConfigurator _visitor;
        private readonly HayesModem _hayes;
        private readonly ZoomModem _zoom;
        private readonly ErnieModem _ernie;

        public ModemVisitorTest()
        {
            _visitor = new UnixModemConfigurator();
            _hayes = new HayesModem();
            _zoom = new ZoomModem();
            _ernie = new ErnieModem();
        }

        [Fact]
        public void ShouldConfigureHayesModemConfigurationStringProperly()
        {
            _hayes.Accept(_visitor);
            Assert.Equal("&s1=4&D=3", _hayes.ConfigurationString);
        }

        [Fact]
        public void ShouldConfigureZoomConfigurationValueProperly()
        {
            _zoom.Accept(_visitor);
            Assert.Equal(42, _zoom.ConfigurationValue);
        }

        [Fact]
        public void ShouldConfigureErnieInternalPatternProperly()
        {
            _ernie.Accept(_visitor);
            Assert.Equal("C is too slow", _ernie.InternalPattern);
        }
    }
}