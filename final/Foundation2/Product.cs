using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Product
{   
    //declare variables
    private string _productName;
    private string _productId;
    private float _productPrice;
    private float _productQuantity;

    public Product(string productName, string productId, float productPrice, float productQuantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public Product()
    {
        _productName = "";
        _productId = "";
        _productPrice = 0;
        _productQuantity = 0;
    }

    //getters
    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public float GetProductPrice()
    {
        return _productPrice;
    }

    public float GetProductQuantity()
    {
        return _productQuantity; 
    }

}