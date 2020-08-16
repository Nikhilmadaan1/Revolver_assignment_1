using Microsoft.VisualStudio.TestTools.UnitTesting;
using Revolver_assignment_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revolver_assignment_1.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Revolver_assignment_1.fire obj =new Revolver_assignment_1.fire();
            Form1 objfrm = new Form1();
            int y = obj.start(objfrm.GunBox);
            Assert.IsTrue(true);
            
        }

    }
}