using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using Paymentsense.Coding.Challenge.Core.CountryData.RestCountries;
using RestSharp;
using Xunit;

namespace Paymentsense.Coding.Challenge.Api.Tests.Services
{
    public class RestCountriesApiClientTests
    {
        [Fact]
        public async Task GetAllCountries_WhenInvoked_CallsCorrectEndpoint()
        {
            // arrange
            IRestRequest request = null;
            var restClientMock = new Mock<IRestClient>();
            restClientMock
                .Setup(x => x.ExecuteAsync(It.IsAny<IRestRequest>(), It.IsAny<CancellationToken>()))
                .Callback<IRestRequest, CancellationToken>((r, t) => request = r)
                .ReturnsAsync(new RestResponse { StatusCode = HttpStatusCode.OK, Content = "[]", ResponseStatus = ResponseStatus.Completed });
            var client = new RestCountriesApiClient("http://localhost", restClientMock.Object);

            // act
            var countries = await client.GetAllCountries();

            // assert
            request.Should().NotBeNull();
            request.Resource.Should().Be("all");
            request.Method.Should().Be(Method.GET);
        }

        [Fact]
        public async Task GetAllCountries_WhenRecveivesJsonData_MapsToModelCorrectly()
        {
            // arrange
            var restClientMock = new Mock<IRestClient>();
            restClientMock
                .Setup(x => x.ExecuteAsync(It.IsAny<IRestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse { StatusCode = HttpStatusCode.OK, Content = File.ReadAllText(@"TestData\RestCountriesSampleResponse.txt"), ResponseStatus = ResponseStatus.Completed });
            var client = new RestCountriesApiClient("http://localhost", restClientMock.Object);

            // act
            var countries = await client.GetAllCountries();

            // assert
            countries.Count.Should().Be(2);
            
            var firstCountry = countries.First();
            firstCountry.Name.Should().Be("Afghanistan");
            firstCountry.FlagImage.Should().Be("https://restcountries.eu/data/afg.svg");
            firstCountry.CapitalCity.Should().Be("Kabul");
            firstCountry.Languages.Count.Should().Be(3);
            firstCountry.BorderingCountries.Count.Should().Be(1);
            firstCountry.BorderingCountries.Single().Name.Should().Be("Albania");
            firstCountry.Currencies.Count.Should().Be(1);
            firstCountry.Currencies.Single().Name.Should().Be("Afghan afghani");

            var secondCountry = countries.Last();
            secondCountry.Name.Should().Be("Albania");
            secondCountry.FlagImage.Should().Be("https://restcountries.eu/data/alb.svg");
            secondCountry.CapitalCity.Should().Be("Tirana");
            secondCountry.Languages.Count.Should().Be(1);
            secondCountry.Languages.Single().Name.Should().Be("Albanian");
            secondCountry.BorderingCountries.Count.Should().Be(1);
            secondCountry.BorderingCountries.Single().Name.Should().Be("Afghanistan");
            secondCountry.Currencies.Count.Should().Be(1);            
        }
    }
}
