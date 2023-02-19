namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EmptyOrNull 
            String nullString = null;
            String emptyString = "";

            Console.WriteLine($"nullString is null or empty: {String.IsNullOrEmpty(nullString)}");
            Console.WriteLine($"emptyString is null or empty: {String.IsNullOrEmpty(emptyString)}");
            #endregion
        }
    }
}