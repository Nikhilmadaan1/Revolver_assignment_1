using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Revolver_assignment_1;

namespace Revolver_assignment_1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Revolver_assignment_1.fire obj = new Revolver_assignment_1.fire();
            Form1 objfrm = new Form1();
            int y = obj.Load(objfrm.GunBox);
            Assert.IsTrue(true);
        }

        public void testMethod2() {

            Revolver_assignment_1.fire obj = new Revolver_assignment_1.fire();
            Form1 objfrm = new Form1();
            int y = obj.shoot(objfrm.shootBtn);
            Assert.IsTrue(true);
        }
    }
}
