using BandRateMileageTestApp;

internal class Program
{
    private static void Main(string[] args)
    {
        List<FareBand> FareBands = new List<FareBand> {
                new FareBand (1f, 10.0f ),
                new FareBand ( 5f, 2.0f ),
                new FareBand ( 10f, 3.0f ),
                new FareBand ( null, 1.0f ),
            };
        DriverFare driverFare = new DriverFare(FareBands);

        while (true)
        {
            Console.WriteLine("Enter the driven distance in miles:");
            string? input = Console.ReadLine();
            float distance;

            if (float.TryParse(input, out distance))
            {

                float? fare = driverFare.CalculateDriverFare(distance);
                Console.WriteLine($"The total fare for {distance} miles is: {fare} GBP");
            }
            else
            {
                Console.WriteLine("Please enter a valid distance in miles");
            }
            Console.WriteLine("Do you want to enter another distance? (yes/no)");
            string continueInput = Console.ReadLine().ToLower();

            if (continueInput != "yes")
            {
                break;
            }
        }
    }
}