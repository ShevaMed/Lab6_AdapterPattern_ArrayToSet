using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConverterArraySetAdapterLib.Converters
{
    public class ArraySetConverter<T>
    {
        public HashSet<T> ConvertArrayToSet(T[] array)
        {
            return new HashSet<T>(array);
        }

        public T[] ConvertSetToArray(HashSet<T> set)
        {
            return set.ToArray();
        }
    }
}
