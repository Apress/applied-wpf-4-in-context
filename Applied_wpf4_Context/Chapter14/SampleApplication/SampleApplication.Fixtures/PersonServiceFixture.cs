using System.ServiceModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleApplication.Fixtures.PersonServiceReference;

namespace SampleApplication.Fixtures
{
    [TestClass]
    public class PersonServiceFixture
    {
        [TestMethod]
        public void AssertThatTheServiceCanRun()
        {
            PersonServiceClient client = new PersonServiceClient();
            client.Open();
            Assert.IsNotNull(client);
            Assert.IsTrue(client.State == CommunicationState.Opened);
            client.Close();
            Assert.IsTrue(client.State == CommunicationState.Closed);
        }

        [TestMethod]
        public void AssertThatCanAddANewPerson()
        {
            using (PersonServiceClient client = new PersonServiceClient())
            {
                client.Open();
                Person person = new Person {FirstName = "Raffaele", LastName = "Garofalo"};
                client.AddPerson(person);
                bool result = client.HasPerson(person);
                Assert.IsTrue(result);
            }
        }
    }
}