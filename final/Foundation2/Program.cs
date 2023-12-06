using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
//ENCAPSULATION WITH ONLINE ORDERING

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("____________________________________________");
        Console.WriteLine("ONLINE ORDERING");


        //Customer #1, two products----------------------------------------
        Console.WriteLine("____________________________________________");
        Console.WriteLine();
        Customer customer1 = new Customer();
        customer1.SetCustomerName("Alan Parker");

        Address address1 = new Address("700 West","Centerville","Arizona","United States");
        string add1 = address1.GetCompleteAddress();
        float priceShipping1 = address1.LiveInUsa();

        Order order1 = new Order(customer1); //create order

        Product product1 = new Product("Diamond Necklace","45678D",190,2);//product 1
        order1.AddProduct(product1);
        Product product2 = new Product("Toolbox Essentials","78G54F7",100,1);//product 2
        order1.AddProduct(product2);

        //display shipping label
        string label1 = order1.GetShippingLabel();
        Console.WriteLine(label1);
        Console.WriteLine(add1);

        string firstlabel = order1.GetPackingLabel();
        Console.WriteLine(firstlabel); 

        //total
        float totalPrice1 = order1.TotalOrder();
        totalPrice1 += priceShipping1;
        Console.WriteLine($"    Shipping Cost: ${priceShipping1}");
        Console.WriteLine($"    TOTAL: ${totalPrice1}\n");
        Console.WriteLine("____________________________________________");



        //Customer #2, three products ----------------------------------------
        Customer customer2 = new Customer();
        customer2.SetCustomerName("Mary Jane");

        Address address2 = new Address("1489 Boul Lamontagne","Sainte-Marie","Quebec","Canada");
        string add = address2.GetCompleteAddress();
        float priceShipping = address2.LiveInUsa();

        Order order2 = new Order(customer2); //create order

        Product product3 = new Product("Full Size Wall Mirror","578523G",200,1);//product 1
        order2.AddProduct(product3);
        Product product4 = new Product("Blue Waterbottle","637T89U",40,3);//product 2
        order2.AddProduct(product4);
        Product product5 = new Product("Mason Jar","837H96R",25,10);//product 3
        order2.AddProduct(product5);

        //display shipping label
        Console.WriteLine();
        string label2 = order2.GetShippingLabel();
        Console.WriteLine(label2);
        Console.WriteLine(add);

        string label = order2.GetPackingLabel();
        Console.WriteLine(label); 

        //total
        float totalPrice = order2.TotalOrder();
        totalPrice += priceShipping;
        Console.WriteLine($"    Shipping: ${priceShipping}");
        Console.WriteLine($"    TOTAL: ${totalPrice}\n");
        Console.WriteLine("____________________________________________");
        Console.WriteLine();



        //Customer #3, three products----------------------------------------
        Customer customer3 = new Customer();
        customer3.SetCustomerName("Tommy Jacobs");

        Address address3 = new Address("7293 Calle las Palapas","Cancun","Quintana Roo","Mexico");
        string add3 = address3.GetCompleteAddress();
        float priceShipping3 = address3.LiveInUsa();

        Order order3 = new Order(customer3); //create order

        Product product6 = new Product("Pink Diamond Engagement Ring","1092Y8G",499,1);//product 1
        order3.AddProduct(product6);
        Product product7 = new Product("Lavender Scented Candle","378H98U",25,1);//product 1
        order3.AddProduct(product7);
        Product product8 = new Product("Cologne pour Lui","782S49L",120,1);//product 1
        order3.AddProduct(product8);

        //display shipping label
        string label3 = order3.GetShippingLabel();
        Console.WriteLine(label3);
        Console.WriteLine(add3);

        string thirdlabel = order3.GetPackingLabel();
        Console.WriteLine(thirdlabel); 

        //total
        float totalPrice3 = order3.TotalOrder();
        totalPrice3 += priceShipping3;
        Console.WriteLine($"    Shipping Cost: ${priceShipping3}");
        Console.WriteLine($"    TOTAL: ${totalPrice3}\n");
        Console.WriteLine("____________________________________________");
        Console.WriteLine();



        //Customer #4, two products----------------------------------------
        Customer customer4 = new Customer();
        customer4.SetCustomerName("Diana Merten");

        Address address4 = new Address("8931 North","Sacramento","California","United States");
        string add4 = address4.GetCompleteAddress();
        float priceShipping4 = address4.LiveInUsa();

        Order order4 = new Order(customer4); //create order

        Product product9 = new Product("Green Bathing Suit","1092Y8G",25,2);//product 1
        order4.AddProduct(product9);
        Product product10 = new Product("Floral Macbook Air Case","748G67W",32,1);//product 1
        order4.AddProduct(product10);

        //display shipping label
        string label4 = order4.GetShippingLabel();
        Console.WriteLine(label4);
        Console.WriteLine(add4);

        string fourthlabel = order4.GetPackingLabel();
        Console.WriteLine(fourthlabel); 

        //total
        float totalPrice4 = order4.TotalOrder();
        totalPrice4 += priceShipping4;
        Console.WriteLine($"    Shipping Cost: ${priceShipping4}");
        Console.WriteLine($"    TOTAL: ${totalPrice4}\n");
        Console.WriteLine("____________________________________________");
        Console.WriteLine();
        Console.WriteLine();

    }
}