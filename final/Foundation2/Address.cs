using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private float _shippingCost;
    
    //cpnstructors
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public Address(float shippingCost)
    {
        _shippingCost = shippingCost;
    }

    //getters
    public string GetStreet()
    {
        return _street;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }

    public string GetCountry()
    {
        return _country;
    }

    //methods
    public float LiveInUsa() //method to determine if the address is in the US or not
    {
        if (_country == "United States")
        {
            _shippingCost = 5;
        }

        else
        {
            _shippingCost = 35;
        }

        return _shippingCost;
    }

    public string GetCompleteAddress()
    {
        StringBuilder completeAddress = new StringBuilder();
        completeAddress.AppendLine($"{_street} {_city}");
        completeAddress.AppendLine($"{_state}, {_country}");

        return completeAddress.ToString();
    }
}