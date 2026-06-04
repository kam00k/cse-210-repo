//Jack Wilson
//CSE 210
//Final Project, Program 3

public class Address
{
    //Address attributes
    private string _streetAddress;

    private string _city;

    private string _state;

    private string _zipCode;

    //Constructor, assigns attributes by parameters.
    public Address(string address, string city, string state, string zip)
    {
        _streetAddress = address;
        _city = city;
        _state = state;
        _zipCode = zip;
    }

    //creates a string from the attributes and returns it
    public string GetAddressString()
    {
        return ($"{_streetAddress},\n{_city}, {_state} {_zipCode}");
    }
}