using Cubes.Domain.Entities;

namespace Cubes.Api.DTOs
{
    public class CalculateVolumeIntersectionRequest
    {
        public Cube CubeA { get; set; }
        public Cube CubeB { get; set; }
    }
}