using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterArraySetAdapterLib.Interfaces
{
    public interface IUser<T>
    {
        HashSet<T> ArrayToSet(T[] array);

        T[] SetToArray(HashSet<T> set);
    }
}
