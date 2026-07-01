namespace ContactCardProject
{
    public struct ContactCard
    {
        public string Name;
        public string Phone;
        public string Email;

        public ContactCard(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }

        public void Display()
        {
            Console.WriteLine($"Name  : {Name}");
            Console.WriteLine($"Phone : {Phone}");
            Console.WriteLine($"Email : {Email}");
        }
    }
}