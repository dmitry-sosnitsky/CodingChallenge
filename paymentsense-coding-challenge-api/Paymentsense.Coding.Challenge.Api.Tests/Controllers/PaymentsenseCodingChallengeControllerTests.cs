using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Paymentsense.Coding.Challenge.Api.Controllers;
using Xunit;

namespace Paymentsense.Coding.Challenge.Api.Tests.Controllers
{
    public class PaymentsenseCodingChallengeControllerTests
    {
        [Fact]
        public void Get_OnInvoke_ReturnsExpectedMessage()
        {
            // arrange
            var controller = new PaymentsenseCodingChallengeController();

            // act
            var result = controller.Get().Result as OkObjectResult;

            // assert
            result.StatusCode.Should().Be(StatusCodes.Status200OK);
            result.Value.Should().Be("Paymentsense Coding Challenge!");
        }
    }
}
