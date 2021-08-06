using Autofac.Extras.Moq;

namespace Cubes.Tests
{
    public class TestBase
    {
        protected AutoMock _mockProvider;

        public TestBase()
        {
            Initialize();
        }

        void Initialize()
        {
            _mockProvider = AutoMock.GetLoose();
        }
    }
}