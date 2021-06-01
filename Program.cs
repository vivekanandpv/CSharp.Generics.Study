using System;

namespace CSharp.Generics.Study
{
    class Program
    {
        static void Main(string[] args)
        {
            //  This doesn't work because, string is a class, not a struct
            //  Container<string> stringContainer = new Study.Container<string>();  

            Container<int> intContainer = new Study.Container<int>();   //  int = Int32 -> struct


            int intElement = intContainer.Element;
        }
    }
}
