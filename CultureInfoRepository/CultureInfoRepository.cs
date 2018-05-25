using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

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
