using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracelFeeSimulation
{
    class Parcel
    {
        public const int base_fee = 100;
        private double weight;
        internal Parcel(double weight)
        {
            this.weight = weight;
        }

        public double CalculateFee(double distance)
        {
            return distance * weight * base_fee;
        }
    }
}
