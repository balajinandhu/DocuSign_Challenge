using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuSign_Challenge;

namespace CommandTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TakeOffPajamasFirst()
        {
            String cmds = "HOT 7, 1";
            String response = Program.getResponses(cmds);
            Assert.AreEqual("fail", response);
        }
        
        [TestMethod]
        public void OnePieceEach()
        {
            String cmds1 = "HOT 8, 6, 1, 1";
            String response = Program.getResponses(cmds1);
            Assert.AreEqual("Removing PJs, shorts, sandals, fail", response);
        }

        [TestMethod]
        public void SocksWhenHot()
        {
            String cmds = "HOT 8, 3";
            String response = Program.getResponses(cmds);
            Assert.AreEqual("Removing PJs, fail", response);
        }

        [TestMethod]
        public void JacketWhenHot()
        {
            String cmds = "HOT 8, 5";
            String response = Program.getResponses(cmds);
            Assert.AreEqual("Removing PJs, fail", response);
        }

        [TestMethod]
        public void SocksAfterShoes()
        {
            String cmds = "COLD 8, 6, 1, 2, 3";
            String response = Program.getResponses(cmds);
            Assert.AreEqual("Removing PJs, pants, fail", response);
        }

        [TestMethod]
        public void PantsAfterShoes()
        {
            String cmds = "COLD 8, 1, 6, 2, 3";
            String response = Program.getResponses(cmds);
            Assert.AreEqual("Removing PJs, fail", response);
        }
        [TestMethod]
        public void ShirtAfterJacket()
        {
            String cmds = "COLD 8, 3, 5, 4";
            String response = Program.getResponses(cmds);
            Assert.AreEqual("Removing PJs, socks, fail", response);
        }

        [TestMethod]
        public void ShirtAfterHeadwear()
        {
            String cmds = "HOT 8, 6, 2, 4";
            String response = Program.getResponses(cmds);
            Assert.AreEqual("Removing PJs, shorts, fail", response);
        }
        [TestMethod]
        public void NotEnoughClothes()
        {
            String cmds = "COLD 8, 6, 3, 4, 2, 5, 7";
            String response = Program.getResponses(cmds);
            Assert.AreEqual("Removing PJs, pants, socks, shirt, hat, jacket, fail", response);
        }
        [TestMethod]
        public void NotValidCommand1()
        {
            String cmds = "COLD 8, 16, 3, 4, 2, 5, 7";
            String response = Program.getResponses(cmds);
            Assert.AreEqual("Removing PJs, fail", response);
        }

        [TestMethod]
        public void NotValidCommand2()
        {
            String cmds = "COLD 8, -1, 3, 4, 2, 5, 7";
            String response = Program.getResponses(cmds);
            Assert.AreEqual("Removing PJs, fail", response);
        }

    }
}
