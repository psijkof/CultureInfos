using System;
using System.Globalization;
using System.Linq;

namespace CultureInfos
{
    internal class Program
    {
        private static void DutchCultures(CultureInfoRepository.CultureInfoRepository cir)
        {
            Console.WriteLine("-----DUTCH (all)------");
            var cis = cir.CultureInfos.Where(c => c.EnglishName.ToLower().StartsWith("dutch"));

            foreach (var ci in cis)
            {
                WriteInfo(ci);
            }
        }

        private static void Main(string[] args)
        {
            var cir = new CultureInfoRepository.CultureInfoRepository();
            
            Console.WriteLine("---Just Dutch (nl)----");
            WriteInfo(cir.CultureInfos.First((c) => c.Name == "nl"));
            Console.WriteLine("---Just English (en)----");
            WriteInfo(cir.CultureInfos.First((c) => c.Name == "en"));
            DutchCultures(cir);
            EnglishCultures(cir);

            Console.WriteLine(Environment.NewLine);
            var list = CultureInfo.GetCultures(CultureTypes.AllCultures).Where(ci => ci.TwoLetterISOLanguageName.ToLower() == "nl").ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name},{item.NativeName},{item.DisplayName}, {item.EnglishName} ");
            }

            Console.ReadLine();
        }

        private static void EnglishCultures(CultureInfoRepository.CultureInfoRepository cir)
        {
            Console.WriteLine("-----ENGLISH (all)------");
            var cis = cir.CultureInfos.Where(c => c.EnglishName.ToLower().StartsWith("english"));

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