using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandRateMileageTestApp
{
    internal class FareBand
    {
        public float? Distance;
        public float RatePerMile;
        public FareBand(float? distance, float ratePerMile)
        {
            Distance = distance;
            RatePerMile = ratePerMile;
        }
    }
}
