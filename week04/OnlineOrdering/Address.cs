// Address
// The address contains a string for the street address, the city, state/province, and country.
// The address should have a method that can return whether it is in the USA or not.
// The address should have a method to return a string all of its fields together in one string
// (with newline characters where appropriate)


class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;


    public Address(string streetAddress, string city, string _stateOrProvince, string country)
    {
        this._streetAddress = streetAddress;
        this._city = city;
        this._stateOrProvince = _stateOrProvince;
        this._country = country;
    }

    public string ReadFullAddress()
    {
        return string.Concat(_streetAddress, "\n", _city, "\n", _stateOrProvince, "\n", _country);
    }

    public bool IsInUSA()
    {
        List<string> options = new() {
            "usa",
            "america",
            "united states",
            "united states of america"
        };

        return options.Contains(this._country.ToLower());
    }
}