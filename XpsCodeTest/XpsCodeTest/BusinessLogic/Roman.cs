using XpsCodeTest.BusinessLogic;
using Rule = XpsCodeTest.BusinessLogic.Rule;

namespace XpsCodeTest.Conversion;

public class Roman
{
    public string NumberToRoman(int number)
    {
        if (number == 0)
        {
            return string.Empty;
        }

        IList<Rule> rules = RomanRules.Get().Rules();

        foreach (var rule in rules)
        {
            if (rule.Number <= number)
            {
                return rule.RomanNumeral + NumberToRoman(number - rule.Number);
            }
        }

        return string.Empty;
    }
}