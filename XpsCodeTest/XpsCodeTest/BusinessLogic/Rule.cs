namespace XpsCodeTest.BusinessLogic;

public class Rule
{
    public ushort Number { get; private set; }

    public string RomanNumeral { get; private set; }

    public Rule(ushort number, string romanNumeral)
    {
        Number = number;
        RomanNumeral = romanNumeral;
    }
}
