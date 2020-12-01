using AutoFixture;
using Bogus;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using Solverse.Api;
using Solverse.Application.Commands;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
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

        [Test]
        public async Task Test2()
        {
            var factory = new WebApplicationFactory<Startup>();
            var client = factory.CreateClient();

            var response = await client.GetAsync("/home/examples");
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var countBeforeAdd = JsonDocument.Parse(await response.Content.ReadAsStringAsync()).RootElement.GetArrayLength();
            Assert.That(countBeforeAdd, Is.Zero);

            var faker = new Faker("en");
            var createCommand = new Fixture().Build<CreateExampleCommand>()
                .With(x => x.Name).Do(x => x.Name = faker.Name.LastName()).Create();
            var response2 = await client.PostAsJsonAsync("/home/examples", createCommand);
            Assert.That(response2.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var response3 = await client.GetAsync("/home/examples");
            Assert.That(response3.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var countAfterAdd = JsonDocument.Parse(await response3.Content.ReadAsStringAsync()).RootElement.GetArrayLength();
            Assert.That(countAfterAdd, Is.EqualTo(1));
        }
    }
}