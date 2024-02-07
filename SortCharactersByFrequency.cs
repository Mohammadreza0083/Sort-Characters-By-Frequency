using System.Text;

namespace Sort_Characters_By_Frequency
{
    public static class SortCharactersByFrequency
    {
        public static string FrequencySort(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "";
            }
            Stack<char> InputChars = new();
            foreach (char c in input) 
            { 
                InputChars.Push(c);
            }
            StringBuilder OutPut = new StringBuilder();
            foreach (char item in InputChars) 
            {
                OutPut.Append(item);
            }
            return OutPut.ToString();
        }
    }
}
