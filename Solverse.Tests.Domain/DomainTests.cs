﻿using Bogus;
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
    }
}
