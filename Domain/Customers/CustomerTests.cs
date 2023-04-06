using NUnit.Framework;

namespace CleanArchitecture.Domain.Customers
{
    [TestFixture]
    public class CustomerTests
    {
        private Customer _customer;
        private const int Id = 1;
        private const string Name = "Test";

        [SetUp]
        public void SetUp()
        {
            _customer = new Customer();
        }

        [Test]
        public void TestSetAndGetId()
        {
            _customer.Id = Id;

            Assert.That(_customer.Id, 
                Is.EqualTo(Id));
        }

        [Test]
        public void TestSetAndGetName()
        {
            _customer.Name = Name;

            Assert.That(_customer.Name, 
                Is.EqualTo(Name));
        }
    }
}
