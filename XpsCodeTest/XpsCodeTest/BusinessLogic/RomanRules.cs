namespace XpsCodeTest.BusinessLogic;

public sealed class RomanRules
{
    private readonly IList<Rule> _rules;
    private static readonly RomanRules _romanRules = new();

    private RomanRules()
    {
        _rules = new List<Rule>
        {
            new Rule(1000, "M"),
            new Rule(900, "CM"),
            new Rule(500, "D"),
            new Rule(400, "CD"),
            new Rule(100, "C"),
            new Rule(90, "XC"),
            new Rule(50, "L"),
            new Rule(40, "XL"),
            new Rule(10, "X"),
            new Rule(9, "IX"),
            new Rule(5, "V"),
            new Rule(4, "IV"),
            new Rule(1, "I")
        };
    }

    public static RomanRules Get()
    {
        return _romanRules;
    }

    public IList<Rule> Rules()
    {
        return _rules;
    }
}
