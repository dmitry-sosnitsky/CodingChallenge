using System.Collections.Generic;
using System.Linq;

namespace Paymentsense.Coding.Challenge.Core.CountryData.RestCountries.Mappers
{
    internal static class TimeZoneMapper
    {
        public static IReadOnlyCollection<TimeZone> Map(IReadOnlyCollection<string> timeZones)
        {
            return timeZones.Select(x => new TimeZone { Name = x }).ToList();
        }
    }
}
