namespace Sort_Characters_By_Frequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string : ");
            string input = Console.ReadLine();
            Console.WriteLine($"Sort Characters By Frequency : {SortCharactersByFrequency.FrequencySort(input)}");
        }
    }
}
