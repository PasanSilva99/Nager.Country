﻿using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Turkey
    /// </summary>
    public class TurkeyCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Turkey";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Turkey";
        ///<inheritdoc/>
        public string NativeName => "Türkiye";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.TR;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.TUR;
        ///<inheritdoc/>
        public int NumericCode => 792;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".tr" };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AM,
            Alpha2Code.AZ,
            Alpha2Code.BG,
            Alpha2Code.GE,
            Alpha2Code.GR,
            Alpha2Code.IR,
            Alpha2Code.IQ,
            Alpha2Code.SY,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new TryCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "90" };
    }
}
