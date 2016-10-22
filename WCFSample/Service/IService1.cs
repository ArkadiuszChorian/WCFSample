using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Models;

namespace Service
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Product> GetProducts();
        [OperationContract()]
        List<Customer> GetCustomers();
        [OperationContract]
        void SubmitOrder(Order order);
    }
}
