using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Customer
{
    private string _customerName;
    private string _customerAddress;
    private Address _address { get; set; }

    //const
    public Customer(string customerName, string customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    public Customer()
    {
    }

    public Customer(Address address)
    {
        _address = address;
    }


    //getters
    public string GetCustomerName()
    {
        return _customerName;
    }

    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }


     public string GetCustomerAddress()
    {
        return _customerAddress;
    }

     public Address GetAddress()
    {
        return _address;
    }
}