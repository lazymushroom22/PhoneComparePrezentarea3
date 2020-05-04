using System;

namespace PhoneCompare.Models
{
    public class Phone
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime LaunchDate { get; set; }
        public string DisplayResolution { get; set; }
        public string OperatingSystem { get; set; }
        public string Chipset { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string Sensors { get; set; }
        public string Battery { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
    }
}
