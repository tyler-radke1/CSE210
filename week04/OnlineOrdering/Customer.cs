// Customer
// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)

class Customer
{
    public string Name;
    public Address Address;

    public Customer(string name, Address address)
    {
        this.Name = name;
        this.Address = address;
    }

    public bool CustomerIsInUSA()
    {
        return this.Address.IsInUSA();
    }
}