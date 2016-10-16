using System.Runtime.Serialization;

namespace SampleApplication.DataContracts
{
    [DataContract(IsReference = false, Name = "Person", Namespace = "SampleNamespace")]
    public class PersonContract
    {
        public int ID { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }    
    
        public string ShowFullName()
        {
            return string.Format("{0} {1}", this.LastName, this.FirstName);
        }
    }
}