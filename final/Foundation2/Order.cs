//Jack Wilson
//CSE 210
//Final Project, Program 2

public class Order
{
    private Customer _customer;
    private List<Product> _productList;

    public Order(string custName, string streetAddress, string city, string state, string country)
    {
        _customer = new Customer(custName, streetAddress, city, state, country);
        _productList = new List<Product>();
    }

    public void AddProduct(string productName, string id, double unitPrice, int quant)
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
        if (_customer.IsAmerican() == true){
            totalPrice += 5.00;
        }
        else
        {
            totalPrice += 35.00;
        }

        return totalPrice;
    }

    public string PrintPackingLabel()
    {
        string packingLabelString = "\n----------------Packing Label------------------";

        foreach (var item in _productList)
        {
            packingLabelString += ($"\n({item.GetID()}) - {item.GetProductName()}");
        }

        packingLabelString += "\n----------------------------------------------";

        return packingLabelString;
    }

    public string PrintShippingLabel()
    {
        string shippingLabelString = "\n----------------Shipping Label------------------\n";

        shippingLabelString += ($"To:{_customer.GetName()}\n{_customer.GetAddressString()}");
        
        shippingLabelString += "\n------------------------------------------------";

        return shippingLabelString;

    }
}