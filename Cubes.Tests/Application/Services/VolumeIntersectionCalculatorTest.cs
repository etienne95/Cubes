using Cubes.Application.Services;
using Cubes.Domain.Entities;
using FluentAssertions;
using Xunit;

namespace Cubes.Tests.Application.Services
{
    public class VolumeIntersectionCalculatorTest : TestBase
    {
        [Theory]
        [InlineData(3, 3, 3, 3, 3, 3, 3, 3, 27)]
        [InlineData(3, 3, 3, 2, 2, 3, 3, 3, 6)]
        [InlineData(5, 5, 5, 5, 1, 2, 2, 1, 0)]
        public void Given_cube_dimensions_and_center_point_should_return_correct_intersection_volume(
            double cubeAX, double cubeAY, double cubeAZ, double cubeABorder, double cubeBX, double cubeBY, double cubeBZ, double cubeBBorder, double expected)
        {
            // Arrange
            var sut = _mockProvider.Create<VolumeIntersectionCalculator>();
            var cubeA = new Cube
            {
                Height = new Border { Center = cubeAY, Length = cubeABorder },
                Profundity = new Border { Center = cubeAZ, Length = cubeABorder },
                Width = new Border { Center = cubeAX, Length = cubeABorder }
            };
            var cubeB = new Cube
            {
                Height = new Border { Center = cubeBY, Length = cubeBBorder },
                Profundity = new Border { Center = cubeBZ, Length = cubeBBorder },
                Width = new Border { Center = cubeBX, Length = cubeBBorder }
            };

            // Act
            var result = sut.CalculateCubesIntersectionVolume(new[] { cubeA, cubeB });

            // Assert
            result.Should().Be(expected);
        }
    }
}