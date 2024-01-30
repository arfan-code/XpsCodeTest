using Microsoft.Extensions.Logging;

namespace XpsCodeTest.IO;

public class Screen : Input, IOutput
{
    private readonly ILogger<Screen> _log;

    public Screen(ILogger<Screen> log)
    {
        _log = log;
    }

    public override ushort Get()
    {
        ushort positiveNumber;

        try
        {
            Console.WriteLine("Enter any positive integer between 1 and 2000:");

            if (!ushort.TryParse(Console.ReadLine(), out positiveNumber) ||
                positiveNumber < 1 || positiveNumber > 2000)
            {
                throw new InvalidDataException("Invalid input");
            }
        }
        catch (IOException ex)
        {
            _log.LogError(ex.Message);
            throw;
        }

        return positiveNumber;
    }

    public void Print(string textToPrint)
    {
        Console.WriteLine($"Roman numeral: {textToPrint}");
    }
}
