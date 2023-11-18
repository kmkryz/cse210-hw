using System;
using System.Collections.Generic;

class Order
{
    private Customer customer;
    private List<Product> products;

    public Order(Customer customer, List<Product> products)
    {
        this.customer = customer;
        this.products = products;
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in products)
        {
            totalPrice += product.CalculatePrice();
        }

        double shippingCost = customer.IsUSACustomer() ? 5 : 35;
        return totalPrice + shippingCost;
    }

    public string GeneratePackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += $"{product.GetName()}, ID: {product.GetProductId()}\n";
        }
        return packingLabel;
    }

    public string GenerateShippingLabel()
    {
        return $"{customer.GetName()}\n{customer.GetAddress()}";
    }
}
