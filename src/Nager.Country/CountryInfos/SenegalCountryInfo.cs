﻿using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Senegal
    /// </summary>
    public class SenegalCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Senegal";
        ///<inheritdoc/>
        public string OfficialName => "Republic of Senegal";
        ///<inheritdoc/>
        public string NativeName => "Sénégal";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SN;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SEN;
        ///<inheritdoc/>
        public int NumericCode => 686;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".sn" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.GM,
            Alpha2Code.GN,
            Alpha2Code.GW,
            Alpha2Code.ML,
            Alpha2Code.MR,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new XofCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "221" };
    }
}
