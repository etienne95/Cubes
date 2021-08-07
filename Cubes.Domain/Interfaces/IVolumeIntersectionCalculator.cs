using System.Collections.Generic;
using Cubes.Domain.Entities;

namespace Cubes.Domain.Interfaces
{
    public interface IVolumeIntersectionCalculator
    {
        double CalculateCubesIntersectionVolume(IEnumerable<Cube> cubes);
    }
}