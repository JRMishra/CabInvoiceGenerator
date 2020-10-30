using NUnit.Framework;
using CabInvoiceGenerator;

namespace TestCabInvoiceGenerator
{
    public class Tests
    {
        InvoiceGenerator invoiceGenerator = null;

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;
            Assert.AreEqual(expected, fare);
        }
    }
}