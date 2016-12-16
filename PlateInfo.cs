using System;

namespace NgPlateVerifier
{
    public class PlateInfo
    {
        public string  PlateNumber { get; set; }
        public string Owner { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public string Chasis { get; set; }
        public string Status { get; set; }
        public DateTime LicenseIssueDate { get; set; }
        public DateTime LicenseExpiryDate { get; set; }
    }
}