using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConverterArraySetAdapterLib.Converters;
using ConverterArraySetAdapterLib.Interfaces;

namespace ConverterArraySetAdapterLib.Adapters
{
    public class ConverterAdapter<T> : ArraySetConverter<T>, IUser<T>
    {
        public HashSet<T> ArrayToSet(T[] array)
        {
            return ConvertArrayToSet(array);
        }

        public T[] SetToArray(HashSet<T> set)
        {
            return ConvertSetToArray(set);
        }
    }
}
