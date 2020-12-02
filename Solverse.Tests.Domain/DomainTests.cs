using Bogus;
using NSubstitute;
using NUnit.Framework;
using Solverse.Domain.DomainServices;
using Solverse.Domain.Interfaces;
using Solverse.Domain.Models;

namespace Solverse.Tests.Domain
{
    [TestFixture]
    public class DomainTests
    {
        [Test]
        public void DomainTest1()
        {
            var repository = Substitute.For<IExamplesRepository>();
            var domainService = new ExampleDomainService(repository);

            var name = new Faker().Random.String(10);
            domainService.CreateExample(name);
            repository.Received().AddExample(Arg.Is<Example>(x => x.Name == name));
        }

        [Test]
        public void EtenTest()
        {
            var c1 = new Carbon();
            var c2 = new Carbon();
            var bond = new Bond(c1, c2);
            c1.Bonds.Add(bond);
            c2.Bonds.Add(bond);
        }
    }
}
