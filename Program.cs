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

            #region EscapeCharacters
            Console.WriteLine("\nUse of the \\\\ escape character: \\");
            Console.WriteLine("Use of the \\n escape character: \nNew line");
            Console.WriteLine("Use of the \\t escape character: \t\t\t 3-tabbed line");
            Console.WriteLine("\"Quotes\" must be \"escaped\" tp avoid confusing the CLR");
            Console.WriteLine(@"Please stay out of the C:\Windows\System32");
            Console.ReadLine();
            #endregion

            #region StringFormatting
            String robot = "hover bot";
            int speed = 11;
            String str = String.Format("\nThe {0} is travelling at {1:N1}mph, going at {2:P1} of its max speed.\n", robot, speed, speed / 100.0);
            Console.WriteLine(str);
            Console.ReadLine();
            #endregion

            #region StringManipulation
            //String typo = "rbto";
            //typo = typo.Insert(1, "o");
            //typo = typo.Insert(3, "o");
            //typo = typo.Remove(typo.Length - 1);
            //Console.WriteLine("Edited typo: " + typo + "\n");

            //Console.WriteLine("Robot starts with \"first\": " + typo.StartsWith("first"));
            //Console.WriteLine("Robot ends with \"ot\": " + typo.EndsWith("ot"));
            //Console.ReadLine();

            //Console.WriteLine("Substring: " + typo.Substring(2));
            //Console.ReadLine();

            //Console.WriteLine("\"Robot\" contains \"o\": " + typo.Contains("o"));
            //typo = typo.Replace("o", "i");
            //Console.WriteLine("Not anymore, it doesn't! " + typo);
            //Console.ReadLine();

            //String spaceDelimitedString = "This is a space-delimited string. By which I mean a sentence.";
            //String[] stringArray = spaceDelimitedString.Split(new char[] { ' ' });
            //foreach (String s in stringArray)
            //{
            //    Console.Write(s + "-");
            //}
            //Console.WriteLine();
            #endregion
        }
    }
}