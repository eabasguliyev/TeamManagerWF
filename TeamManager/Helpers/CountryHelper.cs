using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace TeamManager.Helpers
{
    public static class CountryHelper
    {
        public static List<CountryInfo> Countries { get; set; }


        static CountryHelper()
        {
            Countries = GetAllCountries(CultureTypes.SpecificCultures);
        }
        public static List<string> GetCountryList()
        {
            var countries = new List<string>();

            foreach (var countryInfo in Countries)
            {
                countries.Add(countryInfo.Region.EnglishName);
            }

            countries = countries.Distinct().ToList();
            countries.Sort();
            return countries;
        }

        private static List<CountryInfo> GetAllCountries(CultureTypes cultureTypes)
        {
            List<CountryInfo> Countries = new List<CountryInfo>();

            foreach (CultureInfo culture in CultureInfo.GetCultures(cultureTypes))
            {
                if (culture.LCID != 127)
                    Countries.Add(new CountryInfo()
                    {
                        Culture = culture,
                        Region = new RegionInfo(culture.TextInfo.CultureName)
                    });
            }
            return Countries;
        }

        private static string GetTwoLettersName(string countryName)
        {
            CountryInfo country = Countries
                .FirstOrDefault(info => info.Region.EnglishName == countryName);

            return (country != null) ? country.Region.TwoLetterISORegionName : string.Empty;
        }

        public static string GetCountryFlagUrl(string countryName)
        {
            var countryCode = GetTwoLettersName(countryName);

            if (countryCode == String.Empty)
                throw new InvalidOperationException("Country code could not find!");

            return $@"https://www.countryflags.io/{countryCode}/shiny/64.png";
        }

        public class CountryInfo
        {
            public CultureInfo Culture { get; set; }
            public RegionInfo Region { get; set; }
        }
    }
}