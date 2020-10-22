using System;

namespace CloneablePoint
{
    public class PointerDescription
    {
        public string PointName { get; set; }
        public Guid PointGuid { get; set; }

        public PointerDescription()
        {
            PointName = "Default Point";
            PointGuid = Guid.NewGuid();
        }
    }
}
