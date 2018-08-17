using System;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;

namespace FizzBuzz.WebApi.Integration.Test
{
    public class ValuesRequest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public ValuesRequest(WebApplicationFactory<FizzBuzz.WebApi.Startup> factory)
        {
            _factory = factory;
        }
        [Theory]
        [InlineData(1, "1")]
        [InlineData(-1, "-1")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(10, "Buzz")]
        [InlineData(-9, "Fizz")]
        public async Task Get_IntegergRequest_ReponseSuccessAsync(int n, string expected)
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync($"/api/values/{n}");
            var actual = await response.Content.ReadAsStringAsync();
            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(expected, actual);
         
        }
    }
}
