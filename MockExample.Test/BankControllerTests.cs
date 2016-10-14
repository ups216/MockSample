using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using FluentAssert;
using MockSample;
using System.Collections.Generic;

namespace MockExample.Test
{
    [TestClass]
    public class BankControllerTests
    {
        [TestMethod]
        public void MockExample_BankController_GetBandList_ShuldRetureListOfBands()
        {
            List<Band> listOfBand = new List<Band>();
            listOfBand.Add(new Band()
            {
                Name = "Beyond",
                Origin = "Hongkong",
                Genre = "Rock",
                BestSong = "海阔天空"
            });
            Mock<MockSample.IRepository> mockRepo = new Mock<IRepository>();
            mockRepo.Setup(x => x.GetBand()).Returns(listOfBand);
            var bankController = new MockSample.BandController(mockRepo.Object);
            bankController.GetBandList();
            bankController.ShouldNotBeNull();
        }
    }
}
