using System;
using Cubes.Domain.Entities;
using Cubes.Domain.Interfaces;

namespace Cubes.Application.Services
{
    public class VolumeIntersectionCalculator : IVolumeIntersectionCalculator
    {
        public double CalculateCubesIntersectionVolume(Cube cubeA, Cube cubeB) 
            => CalculateBordersIntersection(cubeA.Height, cubeB.Height) *
                CalculateBordersIntersection(cubeA.Width, cubeB.Width) *
                CalculateBordersIntersection(cubeA.Profundity, cubeB.Profundity);

        public double CalculateBordersIntersection(Border borderA, Border borderB)
            => Math.Max(0, CalculateBordersDifference(borderA, borderB));

        public double CalculateBordersDifference(Border borderA, Border borderB)
            => Math.Min(borderA.End, borderB.End) - Math.Max(borderA.Start, borderB.Start);
    }
}