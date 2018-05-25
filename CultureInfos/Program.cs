using CultureInfoRepository;
using System;
using System.Globalization;
using System.Linq;

namespace CultureInfos
{
    class Program
    {
        static void Main(string[] args)
        {
            var cir = new CultureInfoRepository.CultureInfoRepository();
            DutchCultures(cir);
            PortugueseCultures(cir);
            Console.ReadLine();
        }

        private static void DutchCultures(CultureInfoRepository.CultureInfoRepository cir)
        {
            var cis = cir.CultureInfos.Where(c => c.EnglishName.ToLower().StartsWith("dutch"));

            foreach (var ci in cis)
            {
                WriteInfo(ci);
            }
        }

        private static void PortugueseCultures(CultureInfoRepository.CultureInfoRepository cir)
        {
            var cis = cir.CultureInfos.Where(c => c.EnglishName.ToLower().StartsWith("portuguese"));

            foreach (var ci in cis)
            {
                WriteInfo(ci);
            }
        }


        static private void WriteInfo(CultureInfo ci)
        {
            Console.WriteLine($"LCID: {ci.LCID}\n\rISO: {ci.TwoLetterISOLanguageName}\n\rNativeName: {ci.NativeName}\n\rName: {ci.Name}\n\rEnglishName: {ci.EnglishName}\n\rThreeLetterISO: {ci.ThreeLetterISOLanguageName}\n\r");

        }
    }
}
