using System;
using System.Globalization;
using System.Linq;

namespace CultureInfos
{
    internal class Program
    {
        private static void DutchCultures(CultureInfoRepository.CultureInfoRepository cir)
        {
            Console.WriteLine("-----DUTCH------");
            var cis = cir.CultureInfos.Where(c => c.EnglishName.ToLower().StartsWith("dutch"));

            foreach (var ci in cis)
            {
                WriteInfo(ci);
            }
        }

        private static void Main(string[] args)
        {
            var cir = new CultureInfoRepository.CultureInfoRepository();

            //DutchCultures(cir);
            //PortugueseCultures(cir);

            WriteInfo(cir.CultureInfos.First((c) => c.Name == "nl"));
            WriteInfo(cir.CultureInfos.First((c) => c.Name == "en"));

            Console.ReadLine();
        }

        private static void PortugueseCultures(CultureInfoRepository.CultureInfoRepository cir)
        {
            Console.WriteLine("-----PORTUGUESE------");
            var cis = cir.CultureInfos.Where(c => c.EnglishName.ToLower().StartsWith("portuguese"));

            foreach (var ci in cis)
            {
                WriteInfo(ci);
            }
        }

        private static void WriteInfo(CultureInfo ci)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"LCID: {ci.LCID}");
            Console.WriteLine($"ISO: {ci.TwoLetterISOLanguageName}");
            Console.WriteLine($"NativeName: {ci.NativeName}");
            Console.WriteLine($"Name: {ci.Name}");
            Console.WriteLine($"EnglishName: {ci.EnglishName}");
            Console.WriteLine($"ThreeLetterISO: {ci.ThreeLetterISOLanguageName}");
            Console.WriteLine($"Number Format:{string.Format(ci, "{0:C}", 123987239.87)}");
            Console.WriteLine();
        }
    }
}