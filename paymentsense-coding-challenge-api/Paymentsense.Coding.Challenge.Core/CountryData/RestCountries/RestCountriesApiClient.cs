using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paymentsense.Coding.Challenge.Core.CountryData.RestCountries.DataContracts;
using Paymentsense.Coding.Challenge.Core.CountryData.RestCountries.Mappers;
using Paymentsense.Coding.Challenge.Core.Integrations;
using RestSharp;

namespace Paymentsense.Coding.Challenge.Core.CountryData.RestCountries
{
    public class RestCountriesApiClient : ApiClientBase, ICountryDataProvider
    {
        public RestCountriesApiClient(string baseAddress, IRestClient restClient)
            : base(baseAddress, restClient)
        { }

        public async Task<IReadOnlyCollection<Country>> GetAllCountries()
        {
            var request = new RestRequest("all", Method.GET);

            var countryDtos = await this.PerformRequest<IReadOnlyCollection<CountryDto>>(request);

            return CountryMapper.Map(countryDtos);
        }
    }
}
