using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Models;

namespace Client
{
    public class MainWindowViewModel : BindableBase
    {
        private ObservableCollection<Product> _Products;
        private ObservableCollection<Customer> _Customers;
        private ObservableCollection<OrderItemModel> _Items = new ObservableCollection<OrderItemModel>();
        private Order _CurrentOrder = new Order();

        public MainWindowViewModel()
        {
            _CurrentOrder.OrderDate = DateTime.Now;
            SubmitOrderCommand = new DelegateCommand(OnSubmitOrder);
            AddOrderItemCommand = new DelegateCommand<Product>(OnAddItem);
            if (!DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                LoadProductsAndCustomers();
            }
        }

        public ObservableCollection<Product> Products
        {
            get { return _Products; }
            set { SetProperty(ref _Products, value); }
        }

        public ObservableCollection<Customer> Customers
        {
            get { return _Customers; }
            set { SetProperty(ref _Customers, value); }
        }

        public ObservableCollection<OrderItemModel> Items
        {
            get { return _Items; }
            set { SetProperty(ref _Items, value); }
        }

        public Order CurrentOrder
        {
            get { return _CurrentOrder; }
            set { SetProperty(ref _CurrentOrder, value); }
        }

        public DelegateCommand SubmitOrderCommand { get; private set; }
        public DelegateCommand<Product> AddOrderItemCommand { get; private set; }

        private void OnAddItem(Product product)
        {
            var existingOrderItem = _CurrentOrder.OrderItems.FirstOrDefault(oi => oi.ProductId == product.Id);
            var existingOrderItemModel = _Items.FirstOrDefault(i => i.ProductId == product.Id);
            if (existingOrderItem != null && existingOrderItemModel != null)
            {
                existingOrderItem.Quantity++;
                existingOrderItemModel.Quantity++;
                existingOrderItem.TotalPrice = existingOrderItem.UnitPrice * existingOrderItem.Quantity;
                existingOrderItemModel.TotalPrice = existingOrderItem.TotalPrice;
            }
            else
            {
                var orderItem = new OrderItem { ProductId = product.Id, Quantity = 1, UnitPrice = 9.99m, TotalPrice = 9.99m };
                _CurrentOrder.OrderItems.Add(orderItem);
                Items.Add(new OrderItemModel { ProductId = product.Id, ProductName = product.Name, Quantity = orderItem.Quantity, TotalPrice = orderItem.TotalPrice });
            }

        }

        private void LoadProductsAndCustomers()
        {
            
        }

        private void OnSubmitOrder()
        {
            
        }
    }
}
