using System;
using System.Collections.Generic;

namespace SortingApplication
{
    public class GetEnumValues
    {
        public IEnumerable<SortingAlgorithm> Values()
        {
            var values =  (IEnumerable<SortingAlgorithm>) Enum.GetValues(typeof(SortingAlgorithm));
            return values;
        }
    }
}

