using Newtonsoft.Json;

namespace Paymentsense.Coding.Challenge.Core.CountryData.RestCountries.DataContracts
{
    internal class LanguageDto
    {
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("nativeName", Required = Required.Always)]
        public string NativeName { get; set; }

        [JsonProperty("iso639_2", Required = Required.Always)]
        public string Iso6392Code { get; set; }
    }
}
