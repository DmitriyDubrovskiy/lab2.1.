class Program
{
    static void Main()
    {
        // Створення екземпляру класу Address
        Address myAddress = new Address();

        // Запис інформації про адресу в поля екземпляра
        myAddress.Index = "12345";
        myAddress.Country = "Ukraine";
        myAddress.City = "Kyiv";
        myAddress.Street = "Main Street";
        myAddress.House = "42";
        myAddress.Apartment = "15";

        // Виведення інформації про адресу на екран
        Console.WriteLine("Поштова адреса:");
        Console.WriteLine($"Індекс: {myAddress.Index}");
        Console.WriteLine($"Країна: {myAddress.Country}");
        Console.WriteLine($"Місто: {myAddress.City}");
        Console.WriteLine($"Вулиця: {myAddress.Street}");
        Console.WriteLine($"Будинок: {myAddress.House}");
        Console.WriteLine($"Квартира: {myAddress.Apartment}");
    }
}