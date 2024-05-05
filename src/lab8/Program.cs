public interface IEquatable<T>
{
    bool Equals(T other);
}


abstract class Device
{
    public string Name { get; set; }
    public string Model { get; set; }
    public string Manufacturer { get; set; }

    public Device()
    {
        Name = string.Empty;
        Model = string.Empty;
        Manufacturer = string.Empty;
    }

    public Device(string name, string model, string manufacturer)
    {
        Name = name;
        Model = model;
        Manufacturer = manufacturer;
    }

    public Device(string name, string model) : this(name, model, "Manufacturer undefined")
    {
    }

    public Device(string name) : this(name, "Model undefined")
    {
    }

    public virtual string ToString()
    {
        return $"Device type is undefined\nName: {Name}\nModel: {Model}\nManufacturer: {Manufacturer}";
    }
}


class Computer : Device, IEquatable<Computer>
{
    public Computer() : base() { }
    public Computer(string name, string model, string manufacturer) : base(name, model, manufacturer)
    {
    }

    public Computer(string name, string model) : base(name, model)
    {
    }

    public Computer(string name) : base(name)
    {
    }

    public override string ToString()
    {
        return $"Device type is Computer\nName: {Name}\nModel: {Model}\nManufacturer: {Manufacturer}";
    }

    public bool Equals(Computer other)
    {
        return ToString() == other.ToString();
    }
}


class Laptop : Device, IEquatable<Laptop>
{
    public Laptop() : base() { }
    public Laptop(string name, string model, string manufacturer) : base(name, model, manufacturer)
    {
    }

    public Laptop(string name, string model) : base(name, model)
    {
    }

    public Laptop(string name) : base(name)
    {
    }

    public override string ToString()
    {
        return $"Device type is Laptop\nName: {Name}\nModel: {Model}\nManufacturer: {Manufacturer}";
    }

    public bool Equals(Laptop other)
    {
        return ToString() == other.ToString();
    }
}


class Tablet : Device, IEquatable<Tablet>
{
    public Tablet() : base() { }
    public Tablet(string name, string model, string manufacturer) : base(name, model, manufacturer)
    {
    }

    public Tablet(string name, string model) : base(name, model)
    {
    }

    public Tablet(string name) : base(name)
    {
    }

    public override string ToString()
    {
        return $"Device type is Tablet\nName: {Name}\nModel: {Model}\nManufacturer: {Manufacturer}";
    }

    public bool Equals(Tablet other)
    {
        return ToString() == other.ToString();
    }
}
