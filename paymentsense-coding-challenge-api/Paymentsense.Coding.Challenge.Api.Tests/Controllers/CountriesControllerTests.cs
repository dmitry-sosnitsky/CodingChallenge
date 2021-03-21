using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Paymentsense.Coding.Challenge.Api.Controllers;
using Paymentsense.Coding.Challenge.Core.CountryData;
using Xunit;

namespace Paymentsense.Coding.Challenge.Api.Tests.Controllers
{
    public class CountriesControllerTests
    {
        [Fact]
        public async Task Get_OnInvoke_ReturnsCountriesFromCountryProvider()
        {
            // arrange
            var mockCountries = new Country[0];
            var countryDataProviderMock = new Mock<ICountryDataProvider>();
            countryDataProviderMock.Setup(x => x.GetAllCountries()).ReturnsAsync(mockCountries);

            var controller = new CountriesController(countryDataProviderMock.Object);

            // act
            var result = await controller.Get();

            // assert
            var okObjectResult = result.Should().BeOfType<OkObjectResult>().Subject;
            okObjectResult.Value.Should().Be(mockCountries);
        }
    }
}
