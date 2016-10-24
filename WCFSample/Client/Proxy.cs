using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using Client.ServiceReference1;
using Models;

namespace Client
{
    class Proxy : ClientBase<IService1>, IService1
    {
        public Proxy() { }
        public Proxy(string endpointName) : base(endpointName) { }
        public Proxy(Binding binding, string address) : base(binding, new EndpointAddress(address)) { }

        public ObservableCollection<Product> GetProducts()
        {
            return Channel.GetProducts();
        }

        public Task<ObservableCollection<Product>> GetProductsAsync()
        {
            return Channel.GetProductsAsync();
        }

        public ObservableCollection<Customer> GetCustomers()
        {
            return Channel.GetCustomers();
        }

        public Task<ObservableCollection<Customer>> GetCustomersAsync()
        {
            return Channel.GetCustomersAsync();
        }

        public ObservableCollection<Order> GetOrders()
        {
            return Channel.GetOrders();
        }

        public Task<ObservableCollection<Order>> GetOrdersAsync()
        {
            return Channel.GetOrdersAsync();
        }

        public ObservableCollection<OrderItem> GetOrderItems()
        {
            return Channel.GetOrderItems();
        }

        public Task<ObservableCollection<OrderItem>> GetOrderItemsAsync()
        {
            return Channel.GetOrderItemsAsync();
        }

        public void SubmitOrder(Order order)
        {
            Channel.SubmitOrder(order);
        }

        public Task SubmitOrderAsync(Order order)
        {
            return Channel.SubmitOrderAsync(order);
        }
    }
}
