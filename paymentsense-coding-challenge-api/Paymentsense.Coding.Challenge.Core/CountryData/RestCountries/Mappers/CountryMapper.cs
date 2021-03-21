using System.Collections.Generic;
using System.Linq;
using Paymentsense.Coding.Challenge.Core.CountryData.RestCountries.DataContracts;

namespace Paymentsense.Coding.Challenge.Core.CountryData.RestCountries.Mappers
{
    internal static class CountryMapper
    {
        public static IReadOnlyCollection<Country> Map(IReadOnlyCollection<CountryDto> countryDtos)
        {
            var result = countryDtos.Select(x => MapWithBorderingCounties(x, countryDtos)).ToList();

            return result;
        }

        private static Country MapWithBorderingCounties(CountryDto countryDto, IReadOnlyCollection<CountryDto> allCountryDtos)
        {
            var result = MapWithoutBorderingCounties(countryDto);

            result.BorderingCountries = countryDto.Borders.Select(x => MapByCountryCode(x, allCountryDtos)).ToList();

            return result;
        }

        private static Country MapWithoutBorderingCounties(CountryDto countryDto)
        {
            return new Country
            {
                Name = countryDto.Name,
                CapitalCity = countryDto.Capital,
                Population = countryDto.Population,
                FlagImage = countryDto.Flag,
                Languages = LanguageMapper.Map(countryDto.Languages),
                Currencies = CurrencyMapper.Map(countryDto.Currencies),
                TimeZones = TimeZoneMapper.Map(countryDto.TimeZones),
            };
        }

        private static Country MapByCountryCode(string countryCode, IReadOnlyCollection<CountryDto> allCountryDtos)
        {
            var dto = allCountryDtos.Single(x => x.Alpha3Code == countryCode);
            
            return MapWithoutBorderingCounties(dto);
        }
    }
}
