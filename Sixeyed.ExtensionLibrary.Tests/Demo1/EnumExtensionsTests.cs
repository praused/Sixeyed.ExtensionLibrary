using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using componentModel = System.ComponentModel;

namespace Sixeyed.ExtensionLibrary.Tests.Demo1
{
    [TestClass]
    public class EnumExtensionsTests
    {
        [TestMethod]
        public void GetName()
        {
            var intro = Module.Intro;
            Assert.AreEqual("Intro", intro.ToString());
            Assert.AreEqual("Intro", Enum.GetName(typeof(Module), intro));
            Assert.AreEqual("Intro", intro.GetName());
        }

        [TestMethod]
        public void GetDescription()
        {
            Assert.AreEqual("Introducing Extension Methods", Module.Intro.GetDescription());
            Assert.AreEqual("Advanced", Module.Advanced.GetDescription());

            Assert.AreEqual("In Progress", ModuleStatus.InProgress.GetDescription());
            Assert.AreEqual("Done", ModuleStatus.Done.GetDescription());
        }

        public enum Module
        {
            [componentModel.Description("Introducing Extension Methods")]
            Intro,
            Advanced,
            Library

        }

        public enum ModuleStatus
        {
            ToDo,
            [componentModel.Description("In Progress")]
            InProgress,
            Done
        }
    }
}
