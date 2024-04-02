namespace Password_Generator
{
    class Program
    {
        public static string RemVowels(string str)
        {
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            string result = "";

            foreach (char letter in str)
            {
                if (!vowels.Contains(letter))
                {
                    result += letter;
                }
            }
            return result;
        }

        public static string CapEveryOther(string str)
        {
            char[] charArray = str.ToCharArray();
            string result = "";
            int cycle = 1;
            foreach (char character in charArray)
            {
                string letter = character.ToString();
                if (cycle == 1)
                {
                    result += letter.ToUpper();
                    cycle = 2;
                }
                else if (cycle == 2)
                {
                    result += letter.ToLower();
                    cycle = 1;
                }
            }

            return result;
        }

        public static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("Enter site name:");
            string site = Console.ReadLine()!;
            
            int siteLength = site.Length;
            
            string abbrSite = (site[0].ToString() + site[1].ToString()).ToUpper();

            Console.Clear();
            Console.WriteLine("Enter site usage (Read books, watch videos, talk to friends, etc.):");
            string[] usageList = Console.ReadLine()!.ToLower().Split();
            List<string> usageDict = new List<string>();

            List<string> fillerWords = new List<string>() { "to", "a", "an", "and", "the" };

            foreach (string word in usageList)
            {
                if (!fillerWords.Contains(word))
                {
                    usageDict.Add(word);
                }
            }

            string abbrUsage = usageDict[0];
            string abbrSubject = RemVowels(usageDict[1].ToUpper());

            string password = $"{abbrSite} {siteLength} {abbrUsage} {abbrSubject} ";
            
            string finalPassword = "";

            if (password.Replace(" ", "").Length < 14)
            {
                finalPassword = password.Replace(" ", "?");
            }
            else if (password.Replace(" ", "").Length >= 14)
            {
                finalPassword = password.Replace(" ", "#");
            }

            Console.Clear();
            Console.WriteLine($"Your password for {site} is: \"{finalPassword}\"");
            Console.WriteLine($"Password length: {finalPassword.Length}");

            Console.WriteLine("\n\nPress enter to exit.");
            Console.ReadLine();
        }
    }
}
