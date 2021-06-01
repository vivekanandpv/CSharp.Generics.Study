using System;

namespace CSharp.Generics.Study
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringContainer = new Container<string>("A string container");

            var sample = new SampleNonGeneric();

            //  invoking the generic method of generic class
            stringContainer.PrintMessageGeneric<DateTime>(DateTime.Now);   //  T of this method can be inferred from the type of the argument being passed

            //  invoking the non-generic method of a generic class
            stringContainer.PrintMessageNonGeneric(stringContainer.Element);

            //  invoking the generic method of a non-generic class
            sample.PrintMessageGeneric(3.1415); //  <double> is inferred
        }
    }
}
