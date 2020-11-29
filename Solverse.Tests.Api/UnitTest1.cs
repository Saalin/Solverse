using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using Solverse.Api;
using System.Net;
using System.Threading.Tasks;

namespace Solverse.Tests.Api
{
    public class Tests
    {
        [Test]
        public async Task Test1()
        {
            var factory = new WebApplicationFactory<Startup>();
            var client = factory.CreateClient();

            var response = await client.GetAsync("/home");
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var content = await response.Content.ReadAsStringAsync();
            Assert.That(content, Is.EqualTo("Development"));
        }
    }
}