using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using SampleApplication.DataContracts;

namespace SampleApplication.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class PersonService : IPersonService
    {
        private readonly List<PersonContract> persons = new List<PersonContract>();

        #region Implementation of IPersonService

        public void AddPerson(PersonContract personContract)
        {
            persons.Add(personContract);
        }

        public bool HasPerson(PersonContract personContract)
        {
            return persons.Contains(personContract);
        }

        public PersonContract GetPerson(int id)
        {
            return persons.Where(person => person.ID == id).FirstOrDefault();
        }

        #endregion
    }
}
