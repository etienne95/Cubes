using System.Net;
using Microsoft.AspNetCore.Mvc;
using Cubes.Domain.Interfaces;
using Cubes.Api.DTOs;

namespace Cubes.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CubesController : ControllerBase
    {
        private readonly IVolumeIntersectionCalculator _volumeCalculator;

        public CubesController(IVolumeIntersectionCalculator volumeCalculator)
        {
            _volumeCalculator = volumeCalculator;
        }

        [HttpPost("intersection-volume")]
        [ProducesResponseType(typeof(double), (int)HttpStatusCode.OK)]
        public double CalculateVolumeIntersection([FromBody] CalculateVolumeIntersectionRequest request)
        {
            return _volumeCalculator.CalculateCubesIntersectionVolume(request.CubeA, request.CubeB);
        }
    }
}
