using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paymentsense.Coding.Challenge.Core.CountryData.RestCountries.DataContracts;

namespace Paymentsense.Coding.Challenge.Core.CountryData.RestCountries.Mappers
{
    internal static class LanguageMapper
    {
        public static IReadOnlyCollection<Language> Map(IReadOnlyCollection<LanguageDto> languageDtos)
        {
            return languageDtos.Select(x => Map(x)).ToList();
        }

        private static Language Map(LanguageDto languageDto)
        {
            return new Language
            {
                Name = languageDto.Name,
                Code = languageDto.Iso6392Code,
            };
        }
    }
}
