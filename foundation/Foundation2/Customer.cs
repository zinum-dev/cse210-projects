using System.Text;

class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public string GetInformation()
    {
        StringBuilder info = new StringBuilder();
        info.AppendLine($"{_name}:");
        info.AppendLine(_address.Display());
        return info.ToString();
    }

    public bool LiveInUSA()
    {
        return _address.OnUSA();
    }
}