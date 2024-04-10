namespace Wild_Building
{
  public class Building
  {
        private double _height;
        private int _floorCount;

            public Building(double height, int floorCount)
            {
                _height = height;
                _floorCount = floorCount;
            }

           
            public Building(int floorCount)
            {
                _floorCount = floorCount;
                _height = floorCount * 3; 
            }

            
            public double GetFloorMaxSize()
            {
                return _height / _floorCount;
            }

            
            public int GetFloorCount()
            {
                return _floorCount;
            }

         
            public double GetSize()
            {
                return _height;
            }
  }

        class Program
        {
            static void Main(string[] args)
            {
                
                Console.WriteLine("Welcome to the building project!");

                while (true)
                {
                    Console.WriteLine("\nWhat would you like to do?");
                    Console.WriteLine("1. Create a building with both height and floor count");
                    Console.WriteLine("2. Create a building with only floor count");
                    Console.WriteLine("3. Exit");

                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Console.WriteLine("Enter the height of the building:");
                        double height = double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the number of floors:");
                        int floorCount = int.Parse(Console.ReadLine());

                        Building building = new Building(height, floorCount);
                        DisplayBuildingInfo(building);
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("Enter the number of floors:");
                        int floorCount = int.Parse(Console.ReadLine());

                        Building building = new Building(floorCount);
                        DisplayBuildingInfo(building);
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("Exiting...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    }
                }
            }

            static void DisplayBuildingInfo(Building building)
            {
                Console.WriteLine("\nBuilding Information:");
                Console.WriteLine("Number of floors: " + building.GetFloorCount());
                Console.WriteLine("Height of each floor: " + building.GetFloorMaxSize() + " meters");
                Console.WriteLine("Total height of the building: " + building.GetSize() + " meters");
            }
        }
    
}
