using System;

namespace City
{
    class Program
    {
        static void Main(string[] args)
        {
            Buildings building1 = new Buildings("Primaria Oradea", "200 mp", "cladire administrativa");
            Buildings building2 = new Buildings("Biblioteca Gheorghe Sincai", "250mp", "biblioteca");
            Buildings building3 = new Buildings("Biserica cu Luna", "150 mp", "instituie religioasa");
            Buildings building4 = new Buildings("Teatrul Regina Maria", "350 mp", "teatru");

            Console.WriteLine("\n");
            Console.WriteLine("Detalii cladiri:");
            Console.WriteLine($"#1: {building1.BuildingName}, {building1.BuildingDimensions}, {building1.BuildingType}");
            Console.WriteLine($"#2: {building2.BuildingName}, {building2.BuildingDimensions}, {building2.BuildingType}");
            Console.WriteLine($"#3: {building3.BuildingName}, {building3.BuildingDimensions}, {building3.BuildingType}");
            Console.WriteLine($"#4: {building4.BuildingName}, {building4.BuildingDimensions}, {building4.BuildingType}");

            Cars car1 = new Cars("Lamborghini", "Huracan", "green", "sport", 2017);
            Cars car2 = new Cars("Ford", "Mustang", "purple", "sport", 2010);
            Cars car3 = new Cars("Subaru", "Outback", "blue", "station wagon", 2015);
            Cars car4 = new Cars("Volkswagen", "Golf", "red", "hatchback", 2018);
            Cars car5 = new Cars("Porsche", "911 Targa", "marine blue", "convertible", 2014);
            Cars car6 = new Cars("Honda", "Odyssey", "yellow", "minivan", 2020);
            Cars car7 = new Cars("Nissan", "Versa", "black", "sedan", 2007);
            Cars car8 = new Cars("Mercedes-Benz", "CLS", "diamond red", "coupe", 2020);

            Console.WriteLine("\n");
            Console.WriteLine("Detalii masini:");
            Console.WriteLine($"#1: {car1.Brand}, {car1.Model}, {car1.Color}, {car1.Type}, {car1.Year}");
            Console.WriteLine($"#2: {car2.Brand}, {car2.Model}, {car2.Color}, {car2.Type}, {car2.Year}");
            Console.WriteLine($"#3: {car3.Brand}, {car3.Model}, {car3.Color}, {car3.Type}, {car3.Year}");
            Console.WriteLine($"#4: {car4.Brand}, {car4.Model}, {car4.Color}, {car4.Type}, {car4.Year}");
            Console.WriteLine($"#5: {car5.Brand}, {car5.Model}, {car5.Color}, {car5.Type}, {car5.Year}");
            Console.WriteLine($"#6: {car6.Brand}, {car6.Model}, {car6.Color}, {car6.Type}, {car6.Year}");
            Console.WriteLine($"#7: {car7.Brand}, {car7.Model}, {car7.Color}, {car7.Type}, {car7.Year}");
            Console.WriteLine($"#8: {car8.Brand}, {car8.Model}, {car8.Color}, {car8.Type}, {car8.Year}");

            Streets streets1 = new Streets("Str. Revolutiei", 7);
            Streets streets2 = new Streets("Str. Nicolae Bolcas", 45);
            Streets streets3 = new Streets("Str. Republicii", 78);
            Streets streets4 = new Streets("Bd. Decebal", 180);

            Console.WriteLine("Detalii strazi:");
            Console.WriteLine($"#1: {streets1.StreetName}, {streets1.StreetNumber}");
            Console.WriteLine($"#2: {streets2.StreetName}, {streets2.StreetNumber}");
            Console.WriteLine($"#3: {streets3.StreetName}, {streets3.StreetNumber}");
            Console.WriteLine($"#4: {streets4.StreetName}, {streets4.StreetNumber}");

            Parks park1 = new Parks("Parcul Primaverii", "700 mp");
            Parks park2 = new Parks("Parcul Lalelelor", "1000 mp");

            Console.WriteLine("\n");
            Console.WriteLine("Detalii parcuri:");
            Console.WriteLine($"#1: {park1.ParkName}, {park1.ParkSurface}");
            Console.WriteLine($"#2: {park2.ParkName}, {park2.ParkSurface}");

            People person1 = new People("Pop Ion", 41, "M", "lawyer");
            People person2 = new People("Mircea Alexandru", 25, "M", "driver");
            People person3 = new People("Popescu Ioan", 55, "M", "doctor");
            People person4 = new People("Avramescu Elena", 22, "M", "student");
            People person5 = new People("Strava Beniamin", 24, "M", "electrician");

            Console.WriteLine("\n");
            Console.WriteLine("Detalii persoane:");
            Console.WriteLine($"#1: {person1.Name}, {person1.Age}, {person1.Genre}, {person1.Profession}");
            Console.WriteLine($"#2: {person2.Name}, {person2.Age}, {person2.Genre}, {person2.Profession}");
            Console.WriteLine($"#3: {person3.Name}, {person3.Age}, {person3.Genre}, {person3.Profession}");
            Console.WriteLine($"#4: {person4.Name}, {person4.Age}, {person4.Genre}, {person4.Profession}");
            Console.WriteLine($"#5: {person5.Name}, {person5.Age}, {person5.Genre}, {person5.Profession}");
        }
    }
}