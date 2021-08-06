using Cubes.Domain.Entities;

namespace Cubes.Domain.Interfaces
{
    public interface IVolumeIntersectionCalculator
    {
        double CalculateCubesIntersectionVolume(Cube cubeA, Cube cubeB);
        double CalculateBordersIntersection(Border borderA, Border borderB);
        double CalculateBordersDifference(Border borderA, Border borderB);
    }
}