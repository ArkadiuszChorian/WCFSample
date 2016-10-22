using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class Order
    {
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public Guid CustomerId { get; set; }
        [DataMember]
        public DateTime OrderDate { get; set; }
        [DataMember]
        public List<OrderItem> OrderItems { get; set; }
    }
}
