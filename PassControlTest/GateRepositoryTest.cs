using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PassControlLibrary;
using System.Collections.Generic;

namespace PassControlTest
{
    [TestClass]
    public class GateRepositoryTest
    {
        [TestMethod]
        public void TestuojameArGrazinaVisaGateList()
        {
            //Assign
            GateRepository gateRepository = new GateRepository();
            List<Gate> GateList = gateRepository.GetGateList();
            //Act
            int gateListCount = GateList.Count;
            //Assert
            Assert.AreEqual(gateListCount, 4);
        }

        [TestMethod]
        public void TestuojameArRandaGateCodePagalGateId()
        {
            //Assing
            GateRepository gateRepository = new GateRepository();
            //Act
            string findGateCode = gateRepository.GetGateCodeByID(33);
            //Assert
            Assert.AreEqual(findGateCode, "South Pass");
        }

        /*[TestMethod]
        public void ()
        {
            //Assing

            //Act

            //Assert
        }*/

    }
}
