using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SorokinAD.Sprint0.Task2.V0.Lib;



namespace Tyuiu.SorokinAD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Артём";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Артём", res);
        }
    }
}
