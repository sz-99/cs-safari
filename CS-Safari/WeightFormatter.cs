using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Safari
{
    public class WeightFormatter : IFormattable
    {
        private Animal Animal;
        private float Weight;

        public WeightFormatter(Animal animal)
        {
            this.Animal = animal;
            this.Weight = animal.Weight;
        }

        public string ToString(string? format ,IFormatProvider? formatProvider)
        {
            if (format == null) format = "K";
            if(formatProvider == null) formatProvider = CultureInfo.CurrentCulture;

            switch (format.ToUpperInvariant())
            {
                case "K":
                    return $"This {Animal.GetType().Name}'s weight is {Animal.Weight.ToString("F2", formatProvider)} kg ";

            }

            return "";
        }

    }
}
