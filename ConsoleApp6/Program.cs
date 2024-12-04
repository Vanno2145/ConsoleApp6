namespace ConsoleApp6
{
    using System;

    public class Airplane
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int YearOfManufacture { get; set; }
        public string Type { get; set; }


        public Airplane()
        {
            Name = "Неизвестно";
            Manufacturer = "Неизвестно";
            YearOfManufacture = 0;
            Type = "Неизвестно";
        }

     
        public Airplane(string name, string manufacturer, int yearOfManufacture, string type)
        {
            Name = name;
            Manufacturer = manufacturer;
            YearOfManufacture = yearOfManufacture;
            Type = type;
        }

    
        public void InputData()
        {
            Console.Write("Введите название самолета: ");
            Name = Console.ReadLine();
        
        }

      
        public void PrintData()
        {
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Производитель: {Manufacturer}");
            Console.WriteLine($"Год выпуска: {YearOfManufacture}");
            Console.WriteLine($"Тип: {Type}");
        }

      
        public void PrintData(bool showYear)
        {
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Производитель: {Manufacturer}");
            if (showYear)
            {
                Console.WriteLine($"Год выпуска: {YearOfManufacture}");
            }
            Console.WriteLine($"Тип: {Type}");
        }
    }

    public class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
        public int PhoneCode { get; set; }
        public const int MaxDistricts = 10; 
        public string[] Districts { get; set; } = new string[MaxDistricts];

        public void InputData()
        {
            

            Console.WriteLine("Введите названия районов (через запятую, не более 10):");
            var districtsInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(districtsInput))
            {
                var districts = districtsInput.Split(',').Select(d => d.Trim()).ToArray();
                for (int i = 0; i < Math.Min(districts.Length, MaxDistricts); i++)
                {
                    Districts[i] = districts[i];
                }
            }
        }

        public void PrintData()
        {
         

            Console.WriteLine("Районы:");
            for (int i = 0; i < MaxDistricts; i++)
            {
                if (!string.IsNullOrEmpty(Districts[i]))
                {
                    Console.WriteLine($"- {Districts[i]}");
                }
            }
        }
    }

    public class Employee
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string JobDescription { get; set; }

        public void InputData()
        {
            Console.Write("Введите ФИО сотрудника: ");
            FullName = Console.ReadLine();

            Console.Write("Введите дату рождения (ДД.ММ.ГГГГ): ");
            if (DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime birthDate))
            {
                BirthDate = birthDate;
            }
            else
            {
                Console.WriteLine("Некорректный формат даты.");
            }

       
        }

        public void PrintData()
        {
            Console.WriteLine($"ФИО: {FullName}");
            Console.WriteLine($"Дата рождения: {BirthDate:dd.MM.yyyy}");
          
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
