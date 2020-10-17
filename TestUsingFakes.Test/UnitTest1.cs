using System;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUsingFakes.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestVirtualMethod()
        {
            using (ShimsContext.Create())
            {
                var fakeClass = new Fakes.ShimClassNonVirtualMethods();
                var sut = new ClassToTest();
                sut.CallNonVirtualMethod(fakeClass);
            }
        }

        [TestMethod]
        public void TestNonVirtualMethod()
        {
            using (ShimsContext.Create())
            {
                var fakeClass = new Fakes.ShimClassNonVirtualMethods();
                var sut = new ClassToTest();
                sut.CallNonVirtualMethod(fakeClass);
            }
        }
    }
}
