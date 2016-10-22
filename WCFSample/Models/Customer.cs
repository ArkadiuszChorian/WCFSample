using System;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FullName { get; set; }
    }
}
