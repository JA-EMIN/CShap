using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracelFeeSimulation
{
    class City
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        private readonly double relavtive_position;

        internal City(string name, double relavtive_position)
        {
            this.name = name;
            this.relavtive_position = relavtive_position;
        }
        internal double CalculateDistance(City city)
        {
            return Math.Abs(this.relavtive_position - city.relavtive_position); 
        }

    }
}
