public class Solution {
    public static readonly Dictionary<int, List<string>> RomanSymbolsMapping = new()
{
    [0] = new List<string> { "I", "V", "X" },
    [1] = new List<string>{"X", "L", "C"},
    [2] = new List<string>{"C", "D","M"},
    [3] = new List<string>{"M"}
};

    public string IntToRoman(int num) {
        var romanNumeral = String.Empty;
        var stringNum = Convert.ToString(num);
        var lengthOfNum = stringNum.Length;
        
        for(int i=0;i<lengthOfNum;i++)
        {
            var lastDigitOfCurrentNum = num%10;
            var comboOfIndices = ComboOfIndices(lastDigitOfCurrentNum);
            Console.WriteLine(comboOfIndices);
            if(comboOfIndices == null)
            { num = num/10;
                continue;
            }
            var romanNumeralSingle = ReturnRomanNumeral(i,comboOfIndices);
            Console.WriteLine(romanNumeralSingle);
            romanNumeral = romanNumeralSingle+romanNumeral;

            num = num/10;
        }

        return romanNumeral;
    }

    public string? ComboOfIndices(int singleDigit)
    {
        var returnString = String.Empty;
        if(singleDigit<4)
        {
            
            for(int i=0;i<singleDigit;i++)
            returnString = returnString + "0";
        }
        else if (singleDigit ==4)
        {
            return "01";
        }

        else if (singleDigit == 5)
        return "1";
        
        else if(singleDigit>5 && singleDigit<9)
        {
            returnString = "1";
            for(int i = 5;i<singleDigit;i++)
            returnString = returnString + "0";
        }
        
        else if(singleDigit == 9)
        return "02";
        
        else
        return null;

        return returnString;
    }
    public string ReturnRomanNumeral (int placeValue, string ComboOfIndices)
    {
        var romanNumeral = String.Empty;
        for(int i =0; i<ComboOfIndices.Length; i++)
        {
            
            var indice = ComboOfIndices[i] - '0';
            try{
            romanNumeral = romanNumeral + Convert.ToString(RomanSymbolsMapping[placeValue][indice]);
            }
            catch{
                Console.WriteLine($"{placeValue} and {indice}");
                Console.WriteLine($"{romanNumeral}");
            }

        }
        return romanNumeral;
    }
}