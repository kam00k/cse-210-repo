public class Customer
{
    private string _name;

    private Address _address;

    public Customer(string name, string address, string city, string state, string country)
    {
        _name = name;
        _address = new Address(address, city, state, country);
    }
}