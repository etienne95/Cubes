using Cubes.Domain.Entities;
using System.Collections.Generic;

namespace Cubes.Api.DTOs
{
    public class CalculateVolumeIntersectionRequest
    {
        public IEnumerable<Cube> Cubes { get; set; }
    }
}