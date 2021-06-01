using System;

namespace CSharp.Generics.Study
{
    class Program
    {
        static void Main(string[] args)
        {
            //  To instantiate, we must provide the type parameter
            //  a special class Container for string will be emitted by the compiler
            Container<string> stringContainer = new Study.Container<string>();  

            //  In .NET (C#) we have proper generics implementation
            //  so, unlike Java, we can have primitives as type parameters
            Container<int> intContainer = new Study.Container<int>();


            int intElement = intContainer.Element;
            //  intContainer.Element = "good";  //  only int allowed
        }
    }
}
