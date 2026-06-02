using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;

public class Order
{
    private Customer _customer;
    private List<Product> _productList;

    public Order(string custName, string streetAddress, string city, string state, string country)
    {
        _customer = new Customer(custName, streetAddress, city, state, country);
        _productList = new List<Product>();
    }

    public void AddProduct(string productName, int id, double unitPrice, int quant)
    {
        _productList.Add(new Product(productName, id, unitPrice, quant));
    }

    public double CalcTotalPrice()
    {
        double totalPrice = 0;

        foreach (var product in _productList)
        {
            totalPrice += product.CalcSingleTotalPrice();
        }
    }

}