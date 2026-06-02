public class Customer
{
    private string _name;

    private Address _address;

    public Customer(string name, string address, string city, string state, string country)
    {
        _name = name;
        _address = new Address(address, city, state, country);
    }

    public string GetAddressString()
    {
        return _address.GetAddressString();
    }

    public string GetName()
    {
        return _name;
    }

    public bool IsAmerican()
    {
        
        if (_address.GetCountry() == "USA" ||  _address.GetCountry() == "US" || _address.GetCountry() == "United States")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}