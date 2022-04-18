namespace Assignment2
{
    class Assignment2
    {
        public static void Main(string[] args)
        {
            var tesla = new TeslaModelX
            {
                Id = 1,
                Color = "Pitch Black",
                Name = "Model X",
                Range = 200,
                Features = "Vertical Door"
            };

            var yatri = new ElectricBikes
            {
                Id = 10,
                Color = "Black & White",
                Name = "Project 0",
                Range = 200
            };

            var yamaha = new PetrolBike
            {
                Id = 03,
                Color = "White",
                Name = "MT-09",
                Mileage = 30
            };

        }
        public class Cars
        {
            public int Id { get; set; }
            public string Color { get; set; }
            public string Name { get; set; }
        }

        public class Bikes
        {
            public int Id { get; set; }
            public string Color { get; set; }
            public string Name { get; set; }
        }
        public class ElectricCars : Cars, Charge
        {
            public int Range { get; set; }

            public void Charging()
            {
                Console.WriteLine("Car is Charging");
            }
        }

        public class TeslaModelX : ElectricCars
        {
            public string Features { get; set; }
        }
        public class ElectricBikes : Bikes, Charge
        {
            public int Range { get; set; }

            public void Charging()
            {
                Console.WriteLine("Bike is Charging");
            }
        }

        public class PetrolBike : Bikes, Fly
        {
            public decimal Mileage { get; set; }

            public void Flying()
            {
                Console.WriteLine("Bike is Flying");
            }
        }
        public interface Charge
        {
            void Charging();
        }

        public interface Fly
        {
            void Flying();
        }
    }
}