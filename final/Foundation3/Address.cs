public class Address
{
    private string _streetAddress;

    private string _city;

    private string _state;

    private string _zipCode;

    public Address(string address, string city, string state, string zip)
    {
        _streetAddress = address;
        _city = city;
        _state = state;
        _zipCode = zip;
    }

    public string GetAddressString()
    {
        return ($"{_streetAddress},\n{_city}, {_state} {_zipCode}");
    }
    
    
}