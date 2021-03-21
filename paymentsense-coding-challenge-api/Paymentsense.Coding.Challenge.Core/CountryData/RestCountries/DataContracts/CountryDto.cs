using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Paymentsense.Coding.Challenge.Core.CountryData.RestCountries.DataContracts
{
    internal class CountryDto
    {
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("alpha3Code", Required = Required.Always)]
        public string Alpha3Code { get; set; }

        [JsonProperty("capital", Required = Required.Always)]
        public string Capital { get; set; }

        [JsonProperty("population", Required = Required.Always)]
        public uint Population { get; set; }

        [JsonProperty("flag", Required = Required.Always)]
        public string Flag { get; set; }

        [JsonProperty("languages", Required = Required.Always)]
        public IReadOnlyCollection<LanguageDto> Languages { get; set; }

        [JsonProperty("currencies", Required = Required.Always)]
        public IReadOnlyCollection<CurrencyDto> Currencies { get; set; }

        [JsonProperty("timezones", Required = Required.Always)]
        public IReadOnlyCollection<string> TimeZones { get; set; }

        [JsonProperty("borders", Required = Required.Always)]
        public IReadOnlyCollection<string> Borders { get; set; }
    }




}
