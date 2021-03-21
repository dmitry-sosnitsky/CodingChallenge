using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Paymentsense.Coding.Challenge.Core.CountryData;

namespace Paymentsense.Coding.Challenge.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryDataProvider countryDataProvider;

        public CountriesController(ICountryDataProvider countryDataProvider)
        {
            this.countryDataProvider = countryDataProvider ?? throw new ArgumentNullException(nameof(countryDataProvider));
        }

        [HttpGet]
        [ResponseCache(Duration = 60)]
        public async Task<IActionResult> Get()
        {
            var countries = await this.countryDataProvider.GetAllCountries();

            return this.Ok(countries);
        }
    }
}
