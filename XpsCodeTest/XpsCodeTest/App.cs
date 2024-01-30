using XpsCodeTest.Conversion;
using XpsCodeTest.IO;

namespace XpsCodeTest;

public class App
{
    private readonly Input _input;
    private readonly IOutput _output;
    private readonly Roman _roman = new();

    public App(Input inpute, IOutput output)
    {
        _input = inpute;
        _output = output;
    }

    public void Run(string[] args)
    {
        while (true)
        {
            ushort input = _input.Get();
            string romanNumeral = _roman.NumberToRoman(input);
            _output.Print(romanNumeral);
        }
    }
}