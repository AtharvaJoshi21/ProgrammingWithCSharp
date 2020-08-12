using System;

namespace CaseConversion
{
    /// <summary>
    /// Program to Convert Camel case (SampleInput) to snake case (sample_input)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();

            Console.WriteLine(Solve(inputStr));

            Console.ReadLine();
        }

        static string Solve(string s)
        {
            string outStr = string.Empty;
            outStr = s[0].ToString().ToLower();
            for (int i = 1; i < s.Length; i++)
            {
                var charAscii = (int)s[i];
                if (charAscii >= 65 && charAscii <= 90)
                    outStr += string.Format("_{0}", s[i].ToString().ToLower());
                else
                    outStr += s[i].ToString();
            }

            return outStr;
        }
    }
}
