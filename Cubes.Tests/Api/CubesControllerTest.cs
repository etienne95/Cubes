
using Cubes.Api.Controllers;
using Xunit;
using Cubes.Api.DTOs;
using Cubes.Domain.Interfaces;
using FluentAssertions;

namespace Cubes.Tests.Api
{
    public class CubesControllerTest : TestBase
    {
        [Fact]
        public void Given_cubes_should_retturn_the_volume_intersection()
        {
            // Arrange
            var sut = _mockProvider.Create<CubesController>();
            var request = new CalculateVolumeIntersectionRequest();
            const double expectedResult = 2.0;

            _mockProvider.Mock<IVolumeIntersectionCalculator>()
                .Setup(mock => mock.CalculateCubesIntersectionVolume(request.CubeA, request.CubeB))
                .Returns(expectedResult);

            // Act
            var result = sut.CalculateVolumeIntersection(request);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}