﻿public class Product
{
    // Fields
    public int productID;
    public string productName;
    public double cost;
    public int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;

    // Constructor
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }
}
