using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Business.Abstract;
using Tests.MockObjects;
using WebApi.Controllers;
using Model.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;

namespace Tests
{
    [TestClass]
    public class ContactControllerTest
    {
        [TestMethod]
        public void Get_Contact_ById_IsSucceed()
        {
            var mockContactService = new Mock<IContactsService>();
            mockContactService.Setup(repo => repo.GetById(1))
            .Returns(ContactsMock.GetSampleContact());

            var contactController = new ContactController(mockContactService.Object);

            var result = contactController.GetContactById(1) as OkObjectResult;
            var resultObject = result.Value as ServiceResponseModel;

            Assert.AreEqual(true, resultObject.Success);
        }

        [TestMethod]
        public void Get_Contacts_IsSucceed()
        {
            var mockContactService = new Mock<IContactsService>();
            mockContactService.Setup(repo => repo.GetAll())
            .Returns(ContactsMock.GetSampleContactList());

            var contactController = new ContactController(mockContactService.Object);

            var result = contactController.GetContacts(1) as OkObjectResult;
            var resultObject = result.Value as ServiceResponseModel;

            Assert.AreEqual(true, resultObject.Success);
        }
    }
}
