namespace PhoneBookManager.Phones;

public class Telephones
{
    private string name;
    private string telephone;

    public Telephones(string name, string telephone)
    {
        this.name = name;
        this.telephone = telephone;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Telephone
    {
        get => telephone;
        set => telephone = value ?? throw new ArgumentNullException(nameof(value));
    }
}