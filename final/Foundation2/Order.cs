using System;


class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        this._customer = customer;
        this._products = products;
    }



    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.CalculatePrice();
        }

        double shippingCost = _customer.IsUSACustomer() ? 5 : 35;
        double totalPrice = total + shippingCost;

        totalPrice = Math.Round(totalPrice, 2);

        return totalPrice;
    }



    public string GeneratePackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()}, ID: {product.GetProductId()}\n";
        }
        return packingLabel;
    }



    public string GenerateShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}
