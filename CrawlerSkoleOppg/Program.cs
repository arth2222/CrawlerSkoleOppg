using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerSkoleOppg
{
    class Program
    {
        static void Main(string[] args)
        {
            //tester metoden
            var addresses = GenerateAllPossibleIPAddresses();
        }

        
        /// <summary>
        /// Generates all possible IP addresses
        /// </summary>
        /// <returns>List<string> containing all possible IP addresses</returns>
        private static List<string> GenerateAllPossibleIPAddresses()
        {
            List<string> list = new List<string>();
            for (int a = 0; a < 256; a++)
            {
                for (int b = 0; b < 256; b++)
                {
                    for (int c = 0; c < 256; c++)
                    {
                        for (int d = 0; d < 256; d++)
                        {
                            list.Add(a + "." + b + "." + c + "." + d);
                        }
                    }
                }
            }
            return list;
        }
    }
}
