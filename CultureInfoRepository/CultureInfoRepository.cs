using System.Globalization;

namespace CultureInfoRepository
{
    public class CultureInfoRepository
    {
        public CultureInfoRepository()
        {
        }

        public CultureInfo[] CultureInfos
        {
            get
            {
                return CultureInfo.GetCultures(CultureTypes.AllCultures);
            }
        }
    }
}