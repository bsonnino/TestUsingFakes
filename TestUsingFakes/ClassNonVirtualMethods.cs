using System;

namespace TestUsingFakes
{
    public class ClassNonVirtualMethods
    {
        public void NonVirtualMethod()
        {
             Console.WriteLine("Executing Non Virtual Method");
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("Executing Virtual Method");
        }
    }
}