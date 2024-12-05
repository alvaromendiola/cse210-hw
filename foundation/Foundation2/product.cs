using System;

public class Product
{
    private string Name { get; set; }
    private string ProductID { get; set; }
    private double Price { get; set; }
    private int Quantity { get; set; }

    public Product(string name, string productID, double price, int quantity)
    {
        Name = name;
        ProductID = productID;
        Price = price;
        Quantity = quantity;
    }

    public double GetTotalCost()
    {
        return Price * Quantity;
    }

    public override string ToString()
    {
        return $"{Name} (ID: {ProductID})";
    }
}
