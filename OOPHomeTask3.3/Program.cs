using System;
using System.IO;
using System.Text;

namespace OOPHomeTask3._3
{
    class Program
    {
        static void Main()
        {
            var path = @"C:\Users\Public\Documents\Sample.txt";

            var sb = ReadFile(path);
            WriteToFile(sb);

            Console.ReadLine();
        }

        /// <summary>
        /// Get email from document
        /// </summary>
        /// <param name="path">Path to document</param>
        /// <returns></returns>
        static StringBuilder ReadFile(string path)
        {
            var sb = new StringBuilder();

            using (var sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    SearchMail(ref s);

                    if (!string.IsNullOrEmpty(s))
                    {
                        sb.Append(s + "\r");
                    }
                }
            }

            return sb;
        }

        /// <summary>
        /// Write email from document to file
        /// </summary>
        /// <param name="stringBuilder">All emails from document</param>
        static void WriteToFile(StringBuilder stringBuilder)
        {
            var path = @"C:\Users\Public\Documents\Result.txt";
            if (!File.Exists(path))
            {
                System.IO.File.WriteAllText(path,stringBuilder.ToString());
            }
        }

        /// <summary>
        /// parse line to find email
        /// </summary>
        /// <param name="s">Line to parse</param>
        static void SearchMail(ref string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return;
            }

            var arrFromS = s.Split("&");

            if (arrFromS.Length == 2)
            {
                s = arrFromS[1].Trim();
            }
        }
    }
}
