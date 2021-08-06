namespace Cubes.Domain.Entities
{
    public class Border
    {
        public double Start => Center - Length / 2;
        public double End => Center + Length / 2;
        public double Center { get; set; }
        public double Length { get; set; }
    }
}