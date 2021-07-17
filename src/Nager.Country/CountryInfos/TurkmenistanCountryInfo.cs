﻿using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Turkmenistan
    /// </summary>
    public class TurkmenistanCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Turkmenistan";
        ///<inheritdoc/>
        public string OfficialName => "Turkmenistan";
        ///<inheritdoc/>
        public string NativeName => "Türkmenistan";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.TM;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.TKM;
        ///<inheritdoc/>
        public int NumericCode => 795;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".tm" };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.CentralAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AF,
            Alpha2Code.IR,
            Alpha2Code.KZ,
            Alpha2Code.UZ,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new TmtCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "993" };
    }
}
