using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using Models;

namespace Service
{
    public class Service1 : IService1
    {
        public List<Product> GetProducts()
        {
            return DAL.DAL.Instance.Products;
        }

        public List<Customer> GetCustomers()
        {
            return DAL.DAL.Instance.Customers;
        }

        public List<Order> GetOrders()
        {
            return DAL.DAL.Instance.Orders;
        }

        public List<OrderItem> GetOrderItems()
        {
            return DAL.DAL.Instance.OrderItems;
        }

        public void SubmitOrder(Order order)
        {
            DAL.DAL.Instance.Orders.Add(order);
            order.OrderItems.ForEach(oi => DAL.DAL.Instance.OrderItems.Add(oi));
        }
    }
}
