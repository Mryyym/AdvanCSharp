using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    public class Range<T> where T : IComparable<T>
    {


        #region Properties
        public T Minimum { get; private set; }
        public T Maximum { get; private set; }
        #endregion

        #region Constructor
        public Range(T minimum, T maximum)
        {
            if (minimum.CompareTo(maximum) > 0)
            {
                throw new ArgumentException("Minimum value must be less than or equal to Maximum value.");
            }

            Minimum = minimum;
            Maximum = maximum;
        }
        #endregion

        #region Methods
        public bool IsInRange(T value)
        {
            return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;
        }

        public dynamic Length()
        {
            
                if (typeof(T) == typeof(int) || typeof(T) == typeof(double) || typeof(T) == typeof(float))
                {
                    dynamic min = Minimum;
                    dynamic max = Maximum;
                    return max - min;
                }
                throw new Exception("Error happened while calculation");

        }
        #endregion
    }
}
