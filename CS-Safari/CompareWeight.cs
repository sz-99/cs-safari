using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Safari
{
    public class CompareWeight : IComparer<Animal>
    {
       
        public int Compare(Animal animal1, Animal animal2)
            {
            if (animal1.Weight > animal2.Weight)  return 1; 
            else if (animal1.Weight < animal2.Weight)  return -1; 
            return 0;
            }
     
    }
}
