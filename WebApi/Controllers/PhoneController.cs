using System;
using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.DataTransferObjects;
using Model.Entities;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhoneController : ControllerBase
    {
        private readonly IPhonesService _phonesService;
        public PhoneController(IPhonesService phonesService)
        {
            _phonesService = phonesService;
        }

        [HttpPost]
        [Route("GetPhones")]
        [Authorize]
        public ActionResult GetPhones()
        {
            var phoneList = _phonesService.GetAll();

            return Ok(new ServiceResponseModel { Success = true, Message = "Request successfully.", Object = phoneList });
        }

        [HttpPost]
        [Route("GetPhoneByNumber")]
        [Authorize]
        public ActionResult GetPhoneByNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
                return Ok(new ServiceResponseModel { Success = false, Message = "Invalid request." });

            var phone = _phonesService.GetByPhoneNumber(phoneNumber);

            return Ok(new ServiceResponseModel { Success = true, Message = "Request successfully", Object = phone });
        }

        [HttpPost]
        [Route("InsertNewPhone")]
        [Authorize]
        public ActionResult InsertNewPhone(PhoneModel request)
        {
            if (!ModelState.IsValid)
                return Ok(new ServiceResponseModel { Success = false, Message = "Invalid request." });

            _phonesService.Add(new Phones
            {
                PhoneNumber = request.PhoneNumber,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Status = true
            });

            return Ok(new ServiceResponseModel { Success = true, Message = "Request successfully." });
        }

        [HttpPost]
        [Route("UpdatePhone")]
        [Authorize]
        public ActionResult UpdatePhone(PhoneModel request)
        {
            if (!ModelState.IsValid)
                return Ok(new ServiceResponseModel { Success = false, Message = "Invalid request." });

            _phonesService.Update(new Phones
            {
                PhoneId = request.PhoneId,
                PhoneNumber = request.PhoneNumber,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Status = true
            });

            return Ok(new ServiceResponseModel { Success = true, Message = "Request successfully" });
        }

        [HttpPost]
        [Route("DeletePhone")]
        [Authorize]
        public ActionResult DeletePhone(PhoneModel request)
        {
            if (!ModelState.IsValid)
                return Ok(new ServiceResponseModel { Success = false, Message = "Invalid request." });

            _phonesService.Update(new Phones
            {
                PhoneId = request.PhoneId,
                PhoneNumber = request.PhoneNumber,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Status = true
            });

            return Ok(new ServiceResponseModel { Success = true, Message = "Request successfully" });
        }
    }
}
