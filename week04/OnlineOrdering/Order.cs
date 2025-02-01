using System;
using System.Collections.Generic;

public class Order
{
  private List<Product> _products;
  private Customer _customer;

  // Constructor to initialize the order with products and customer
  public Order(List<Product> products, Customer customer)
  {
    _products = products;
    _customer = customer;
  }

  // Method to calculate the total cost of the order including shipping
  public object CalculateTotal()
  {
    float total = 0;
    foreach (var product in _products)
    {
      total += product.GetTotalCost();
    }
    // Add shipping cost
    total += _customer.IsInUSA() ? 5 : 35;
    return total;
  }

  // Method to get the packing label
  public string GetPackingLabel()
  {
    string label = "Packing Label:\n";
    foreach (var product in _products)
    {
      label += $"Product: {product.GetName()} | ID: {product.GetProductId()} | Quantity: {product.GetQuantity()}\n";
    }
    return label;
  }

  // Method to get the shipping label
  public string GetShippingLabel()
  {
    return $"Shipping Label:\nCustomer Name: {_customer.GetName()}\nDelivery Address: {_customer.GetAddress().GetFullAddress()}";
  }
}