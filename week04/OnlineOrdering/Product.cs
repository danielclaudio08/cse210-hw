public class Product
{
  private string _name;
  private string _productId;
  private float _price;
  private int _quantity;

  // Constructor to initialize the product with name, productId, price, and quantity
  public Product(string name, string productId, float price, int quantity)
  {
    _name = name;
    _productId = productId;
    _price = price;
    _quantity = quantity;
  }

  // Method to get the total cost of the product (price * quantity)
  public float GetTotalCost()
  {
    return _price * _quantity;
  }

  // Method to get the product name
  public string GetName()
  {
    return _name;
  }

  // Method to get the product ID
  public string GetProductId()
  {
    return _productId;
  }

  // Method to get the product quantity
  public int GetQuantity()
  {
    return _quantity;
  }
}