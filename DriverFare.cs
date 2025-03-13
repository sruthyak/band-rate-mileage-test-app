using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandRateMileageTestApp
{
    internal class DriverFare
    {
        public List<FareBand> FareBands;
        float? TotalFare;

        public DriverFare(List<FareBand> fareBands) {
            FareBands = fareBands;
            TotalFare = 0f;
        }
        public float? CalculateDriverFare(float distance)
        {
            float remainingDistance=distance;
            TotalFare = 0f;
            for (var i = 0; i < FareBands.Count&& remainingDistance>0; i++) {
                float tempDistance = 0;
                if (FareBands[i].Distance == null)
                {
                    tempDistance = remainingDistance;
                }
                else
                {                  
                    tempDistance = Math.Min((float)FareBands[i].Distance,remainingDistance);                    
                }
                remainingDistance -=  tempDistance;
                TotalFare += tempDistance * FareBands[i].RatePerMile;
            }

            return TotalFare;
        }
    }
}
