namespace PhoneBookManager.Phones;

public class PhoneBook : Phone
{
    List<Telephones> PhoneList = new List<Telephones>();
    
    public override void InsertPhone(string name, string phone)
    {
        bool found = false;
        foreach (Telephones entry in PhoneList)
        {
            if (entry.Name == name)
            {
                found = true;
                if (entry.Telephone != phone)
                {
                    PhoneList.Add(new Telephones(name,phone));
                    Console.WriteLine("Add new phone for "+ name);
                }
                else
                {
                    Console.WriteLine(name + " already exists with the same phone number.");
                }
                break;
            }
        }

        if (!found)
        {
            PhoneList.Add(new Telephones(name,phone));
            Console.WriteLine("add new telephone "+ name);
        }
    }

    public override void RemovePhone(string name)
    {
        foreach (Telephones i in PhoneList)
        {
            if (i.Name == name)
            {
                PhoneList.Remove(i);
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Remove contact "+ name);
                return;
            }
        }
        Console.WriteLine("------------------------------------------");
        Console.WriteLine(name + " contact not found!");
    }

    public override void UpdatePhone(string name, string newPhone)
    {
        foreach (Telephones i in PhoneList)
        {
            if (i.Name == name)
            {
                i.Telephone = newPhone;
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Update contact "+ name + " as Newphone: " + newPhone);
                return;
            }
        }
        Console.WriteLine("------------------------------------------");
        Console.WriteLine(name + " contact not found!");
    }

    public override void SearchPhone(string name)
    {
        List<string> foundPhones = new List<string>();

        foreach (Telephones entry in PhoneList)
        {
            if (entry.Name == name)
            {
                foundPhones.Add(entry.Telephone);
            }
        }

        if (foundPhones.Count == 0)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(name + " not found.");
        }
        else
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Found phone number(s) for " + name + ":");
            foreach (string phone in foundPhones)
            {
                Console.WriteLine(phone);
            }
        }
        
    }

    public override void Sort()
    {
        PhoneList.Sort((a,b) => string.Compare(a.Name,b.Name));
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Phone Book has Sorted!!!");
    }

    public void ListPhone()
    {
        Console.WriteLine("------------------------------------------");
        foreach (Telephones i in PhoneList)
        {
            Console.WriteLine("name: "+ i.Name + "- telephone: "+ i.Telephone);
        }
    }
}