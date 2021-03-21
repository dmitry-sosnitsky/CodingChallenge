using System.Collections.Generic;
using System.Linq;
using Paymentsense.Coding.Challenge.Core.CountryData.RestCountries.DataContracts;

namespace Paymentsense.Coding.Challenge.Core.CountryData.RestCountries.Mappers
{
    internal static class CurrencyMapper
    {
        public static IReadOnlyCollection<Currency> Map(IReadOnlyCollection<CurrencyDto> currencyDtos)
        {
            return currencyDtos.Select(x => Map(x)).ToList();
        }

        private static Currency Map(CurrencyDto currencyDto)
        {
            return new Currency
            {
                Name = currencyDto.Name,
                Code = currencyDto.Code,
            };
        }
    }
}
