// See https://aka.ms/new-console-template for more information
using carbonQLBackend;

class carbonQL
{
    static void Main(string[] args)
    {
       
        do
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            Console.WriteLine($"Input should be of type carbonQL –modelName Etsy –vCPUHours 100 –ssdTBHours 200 –hddTBHours 300");
            // Write code to accept the arguments and pass the parameters to the backend 
            // Call EtsyCalculations.CalculateServerEmissions with CPU hours to get server emissions
            // Call EtsyCalculations.CalculateSSDStorageEmissions with SSD terrabyte Storage hours to get storage emissions
            // Call EtsyCalculations.CalculateHDDStorageEmissions with HDD terrabyte Storage hours to get storage emissions
            
            Console.WriteLine();
       
        } while (true);
        return;

       
    }
}