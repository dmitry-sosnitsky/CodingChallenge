using System.Collections.Generic;

namespace Paymentsense.Coding.Challenge.Core.CountryData
{
    public class Country
    {
        public string Name { get; internal set; }

        public string FlagImage { get; internal set; }

        public string CapitalCity { get; internal set; }

        public uint Population { get; internal set; }

        public IReadOnlyCollection<Country> BorderingCountries { get; internal set; }

        public IReadOnlyCollection<Currency> Currencies { get; internal set; }

        public IReadOnlyCollection<Language> Languages { get; internal set; }

        public IReadOnlyCollection<TimeZone> TimeZones { get; internal set; }        
    }
}
