using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paymentsense.Coding.Challenge.Core.CountryData
{
    public interface ICountryDataProvider
    {
        Task<IReadOnlyCollection<Country>> GetAllCountries();
    }
}
