using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.DataTransferObjects;
using Moq;
using Tests.MockObjects;
using WebApi.Controllers;

namespace Tests
{
    [TestClass]
    public class PhoneControllerTest
    {
        [TestMethod]
        public void Get_Phone_ByNumber_IsSucceed()
        {
            var mockPhoneService = new Mock<IPhonesService>();
            mockPhoneService.Setup(repo => repo.GetByPhoneNumber("+44 464854654654"))
            .Returns(PhonesMock.GetSamplePhone());

            var phoneController = new PhoneController(mockPhoneService.Object);

            var result = phoneController.GetPhoneByNumber("+44 464854654654") as OkObjectResult;
            var resultObject = result.Value as ServiceResponseModel;

            Assert.AreEqual(true, resultObject.Success);
        }

        [TestMethod]
        public void Get_Phones_IsSucceed()
        {
            var mockPhoneService = new Mock<IPhonesService>();
            mockPhoneService.Setup(repo => repo.GetAll())
            .Returns(PhonesMock.GetSamplePhoneList());

            var phoneController = new PhoneController(mockPhoneService.Object);

            var result = phoneController.GetPhones() as OkObjectResult;
            var resultObject = result.Value as ServiceResponseModel;

            Assert.AreEqual(true, resultObject.Success);
        }
    }
}
