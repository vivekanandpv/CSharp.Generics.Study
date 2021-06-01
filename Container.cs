using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Generics.Study
{
    //  
    public class Container<T>
    {
        public T Element { get; }

        public Container(T element)
        {
            Element = element;
        }

        public T Get()
        {
            return Element;
        }

        public void PrintMessageGeneric<TMessage>(TMessage message)
        {
            Console.WriteLine($"Generic PrintMessage in Container: {message}");
        }

        public void PrintMessageNonGeneric(string message)
        {
            Console.WriteLine($"Non-generic PrintMessage in Container: {message}");
        }
    }

    public class SampleNonGeneric
    {
        public void PrintMessageGeneric<TMessage>(TMessage message)
        {
            Console.WriteLine($"Generic PrintMessage in SampleNonGeneric: {message}");
        }
    }
}
