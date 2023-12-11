using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private Address _address;
    private float _shippingCost; 

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
        _shippingCost = 0;
    }

    public Order()
    {

    }

    public float GetShippingCost()
    {
        return _shippingCost;
    }

    public Order(Address address)
    {
        _shippingCost= address.LiveInUsa();
        _address = address;
    }

    public void AddProduct(Product product)
    {
          _products.Add(product);
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();

        foreach (Product product in _products)
        {
            label.AppendLine($"    Item: {product.GetProductName()}\n    Product id: {product.GetProductId()}\n    Price: ${product.GetProductPrice()}\n    Quantity: {product.GetProductQuantity()}\n");
        }

        return label.ToString(); //convert string
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetCustomerName()}";
    }

    public float TotalOrder() //method to get total price
    {
        float totalPrice = 0;
        foreach (Product product in _products)
        {
            float productTotal = product.GetProductPrice() * product.GetProductQuantity();
            totalPrice += productTotal;
        }

        return totalPrice;
    }
}