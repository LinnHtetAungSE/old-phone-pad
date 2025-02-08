using Microsoft.VisualStudio.TestTools.UnitTesting;
using OldPhonePadCodeChallange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhonePadCodeChallange.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TestOldPhonePad_ValidInput_ReturnsCorrectOutput()
        {
            string input = "33#";
            string expectedOutput = "E";

            string result = Program.OldPhonePad(input);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod()]
        public void TestOldPhonePad_EmptyInput_ReturnsEmptyString()
        {
            string input = "";
            string expectedOutput = "";

            string result = Program.OldPhonePad(input);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod()]
        public void TestOldPhonePad_InputWithSingleBackspace_ReturnsCorrectOutput()
        {
            string input = "227*#";
            string expectedOutput = "B";

            string result = Program.OldPhonePad(input);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod()]
        public void TestOldPhonePad_InputWithMultipleBackspaces_ReturnsCorrectOutput()
        {
            string input = "227**2#";
            string expectedOutput = "A";

            string result = Program.OldPhonePad(input);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod()]
        public void TestOldPhonePad_InputWithSpaces_ReturnsCorrectOutput()
        {
            string input = "4433555 555666#";
            string expectedOutput = "HELLO";

            string result = Program.OldPhonePad(input);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod()]
        public void TestOldPhonePad_InputWithSpacesAndBackspaces_ReturnsCorrectOutput()
        {
            string input = "8 88777444666*664#";
            string expectedOutput = "TURING";

            string result = Program.OldPhonePad(input);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod()]
        public void TestOldPhonePad_InputExceedingKeyLength_ReturnsCorrectOutput()
        {
            string input1 = "6666#";
            string expectedOutput1 = "M";

            string result1 = Program.OldPhonePad(input1);
            Assert.AreEqual(expectedOutput1, result1);

            string input2 = "77777#";
            string expectedOutput2 = "P";

            string result2 = Program.OldPhonePad(input2);
            Assert.AreEqual(expectedOutput2, result2);
        }
    }
}
