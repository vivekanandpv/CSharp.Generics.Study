using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Generics.Study
{
    //  https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters
    //  where T : class
    //  where T : struct
    //  where T : new()
    //  ...
    public class Container<T> where T : struct
    {
        public T Element { get; set; }
    }
}
