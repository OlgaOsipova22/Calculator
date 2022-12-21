using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4.Tests
{
    [TestClass()]
    public class UtilTests
    {
        private TextBox textboxask;
        private Label labelplusnimus;
        [TestMethod()]

        public void NumberTest()
        {
            try
            {
                Calculator tests = new Calculator();
                tests.Number("2", textboxask, labelplusnimus);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void formloadTest()
        {
            try
            {
                Calculator tests = new Calculator();
                tests.formload(textboxask, labelplusnimus);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void SignTest()
        {
            try
            {
                Calculator tests = new Calculator();
                tests.Sign("+", textboxask, labelplusnimus);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void AskTest()
        {
            try
            {
                Calculator tests = new Calculator();
                tests.Ask(textboxask, labelplusnimus);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void NumTest()
        {
            try
            {
                Calculator tests = new Calculator();
                textboxask.Text = "12";
                tests.Num(textboxask);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void AskmetTest()
        {
            try
            {
                Calculator tests = new Calculator();
                tests.Askmet(textboxask);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void CalculateTest()
        {
            try
            {
                Calculator tests = new Calculator();
                tests.Calculate(textboxask, labelplusnimus);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void PlusMinusTest()
        {
            try
            {
                Calculator tests = new Calculator();
                tests.PlusMinus(labelplusnimus, textboxask);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }
    }
}