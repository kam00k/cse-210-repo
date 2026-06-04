//Jack Wilson
//CSE 210
//Final Project, Program 2

public class Product
{
    private string _productName;
    private string _productID;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, string id, double unitPrice, int quant)
    {
        _productName = name;
        _productID = id;
        _pricePerUnit = unitPrice;
        _quantity = quant;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetID()
    {
        return _productID;
    }

    public double CalcSingleTotalPrice()
    {
        return _pricePerUnit * _quantity;
    }
}