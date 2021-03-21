using Newtonsoft.Json;

namespace Paymentsense.Coding.Challenge.Core.CountryData.RestCountries.DataContracts
{
    internal class CurrencyDto
    {
        [JsonProperty("name", Required = Required.Default)]
        public string Name { get; set; }

        [JsonProperty("code", Required = Required.Default)]
        public string Code { get; set; }
    }
}
