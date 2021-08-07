using System;
using System.Collections.Generic;
using Cubes.Domain.Entities;
using Cubes.Domain.Interfaces;
using System.Linq;

namespace Cubes.Application.Services
{
    public class VolumeIntersectionCalculator : IVolumeIntersectionCalculator
    {
        public double CalculateCubesIntersectionVolume(IEnumerable<Cube> cubes)
            => CalculateBordersIntersection(cubes.Select(c => c.Height)) *
                CalculateBordersIntersection(cubes.Select(c => c.Width)) *
                CalculateBordersIntersection(cubes.Select(c => c.Profundity));

        private double CalculateBordersIntersection(IEnumerable<Border> borders)
        {
            double result = 0.0;
            _ = borders.Aggregate((borderA, borderB) =>
            {
                result = Math.Max(result, CalculateBordersDifference(borderA, borderB));
                return borderB;
            });
            return result;
        }

        private double CalculateBordersDifference(Border borderA, Border borderB)
            => Math.Min(borderA.End, borderB.End) - Math.Max(borderA.Start, borderB.Start);
    }
}