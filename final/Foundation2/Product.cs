public class Product
{
    private string _productName;
    private int _productID;
    private double _pricePerUnit;
    private int _quantity;


    public Product(string name, int id, double unitPrice, int quant)
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

    public int GetID()
    {
        return _productID;
    }

    public double CalcSingleTotalPrice()
    {
        return _pricePerUnit * _quantity;
    }
}