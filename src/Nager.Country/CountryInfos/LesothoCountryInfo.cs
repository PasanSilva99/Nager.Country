using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Lesotho
    /// </summary>
    public class LesothoCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Lesotho";
        ///<inheritdoc/>
        public string OfficialName => "Kingdom of Lesotho";
        ///<inheritdoc/>
        public string NativeName => "Lesotho";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.LS;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.LSO;
        ///<inheritdoc/>
        public int NumericCode => 426;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".ls" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.ZA,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new ICurrency[] { new LslCurrency(), new ZarCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "266" };
    }
}
