using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.ExtensionLibrary.Domain.Model;

namespace Sixeyed.Extensions.Samples.Tests
{
    [TestClass]
    public class ModelTests
    {
        [TestMethod]
        public void SaveChanges()
        {
            ////New version of EF does not have DomainModelContainer
            //using (var container = new DomainModelContainer())
            //{

            //}
        }
    }
}
