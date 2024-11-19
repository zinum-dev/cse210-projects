using System.Text;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool OnUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public string Display()
    {
        StringBuilder info = new StringBuilder();
        info.AppendLine($"{_street}");
        info.Append($"{_city}, {_state} - {_country}");
        return info.ToString();
    }
}
