using System.ServiceModel;
using SampleApplication.DataContracts;

namespace SampleApplication.Services
{
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        void AddPerson(PersonContract personContract);

        [OperationContract]
        bool HasPerson(PersonContract personContract);

        [OperationContract]
        PersonContract GetPerson(int id);
    }
}