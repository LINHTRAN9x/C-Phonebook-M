
namespace PhoneBookManager.Phones;

class Program
{
    static void Main(string[] args)
    {
        PhoneBook phoneBook = new PhoneBook();

        phoneBook.InsertPhone("Alice", "123456");
        phoneBook.InsertPhone("Perter","0336980961");
        phoneBook.InsertPhone("Bob", "789012");
        phoneBook.InsertPhone("Alice1", "654321");
        phoneBook.InsertPhone("Alice1", "654321");
        phoneBook.InsertPhone("Alice1", "200000022");
        
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Phone Book Menu:");
            Console.WriteLine("1. Insert Phone");
            Console.WriteLine("2. Remove Phone");
            Console.WriteLine("3. Update Phone");
            Console.WriteLine("4. Search Phone");
            Console.WriteLine("5. Sort Phone Book");
            Console.WriteLine("6. List All Phones");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter phone number: ");
                    string phone = Console.ReadLine();
                    phoneBook.InsertPhone(name, phone);
                    break;
                case "2":
                    Console.Write("Enter name to remove: ");
                    string nameToRemove = Console.ReadLine();
                    phoneBook.RemovePhone(nameToRemove);
                    break;
                case "3":
                    Console.Write("Enter name to update: ");
                    string nameToUpdate = Console.ReadLine();
                    Console.Write("Enter new phone number: ");
                    string newPhone = Console.ReadLine();
                    phoneBook.UpdatePhone(nameToUpdate, newPhone);
                    break;
                case "4":
                    Console.Write("Enter name to search: ");
                    string nameToSearch = Console.ReadLine();
                    phoneBook.SearchPhone(nameToSearch);
                    break;
                case "5":
                    phoneBook.Sort();
                    Console.WriteLine("Phone book sorted.");
                    break;
                case "6":
                    phoneBook.ListPhone();
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                    break;
            }

            Console.WriteLine();

        }
    }
}
