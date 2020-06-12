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
    public class ContactController : ControllerBase
    {
        private readonly IContactsService _contactsService;
        public ContactController(IContactsService contactsService)
        {
            _contactsService = contactsService;
        }

        [HttpPost]
        [Route("GetContacts")]
        [Authorize]
        public ActionResult GetContacts(int? phoneId)
        {
            if (phoneId == null)
                return Ok(new ServiceResponseModel { Success = false, Message = "Invalid request." });

            var contactList = _contactsService.GetListByPhoneId(phoneId);

            return Ok(new ServiceResponseModel { Success = true, Message = "Request successfully", Object = contactList });
        }

        [HttpPost]
        [Route("GetContactById")]
        [Authorize]
        public ActionResult GetContactById(int? contactId)
        {
            if (contactId == null)
                return Ok(new ServiceResponseModel { Success = false, Message = "Invalid request." });

            var contact = _contactsService.GetById(contactId);

            return Ok(new ServiceResponseModel { Success = true, Message = "Request successfully", Object = contact });
        }

        [HttpPost]
        [Route("InsertNewContact")]
        [Authorize]
        public ActionResult InsertNewContact(ContactModel request)
        {
            if (!ModelState.IsValid)
                return Ok(new ServiceResponseModel { Success = false, Message = "Invalid request." });

            _contactsService.Add(new Contacts 
            {
                PhoneId = request.PhoneId,
                FirstName = request.FirstName,
                MiddleName = request.MiddleName,
                LastName = request.LastName,
                Organization = request.Organization,
                Title = request.Title,
                MobilePhone = request.MobilePhone,
                HomePhone = request.HomePhone,
                Notes = request.Notes,
                HomeAddress = request.HomeAddress,
                NickName = request.NickName,
                WebSite = request.WebSite,
                BirthDay = request.BirthDay,
                Status = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            });

            return Ok(new ServiceResponseModel { Success = true, Message = "Request successfully" });
        }

        [HttpPost]
        [Route("UpdateContact")]
        [Authorize]
        public ActionResult UpdateContact(ContactModel request)
        {
            if (!ModelState.IsValid)
                return Ok(new ServiceResponseModel { Success = false, Message = "Invalid request." });

            _contactsService.Update(new Contacts 
            {
                ContactId = request.ContactId,
                PhoneId = request.PhoneId,
                FirstName = request.FirstName,
                MiddleName = request.MiddleName,
                LastName = request.LastName,
                Organization = request.Organization,
                Title = request.Title,
                MobilePhone = request.MobilePhone,
                HomePhone = request.HomePhone,
                Notes = request.Notes,
                HomeAddress = request.HomeAddress,
                NickName = request.NickName,
                WebSite = request.WebSite,
                BirthDay = request.BirthDay,
                Status = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            });

            return Ok(new ServiceResponseModel { Success = true, Message = "Request successfully" });
        }

        [HttpPost]
        [Route("DeleteContact")]
        [Authorize]
        public ActionResult DeleteContact(ContactModel request)
        {
            if (!ModelState.IsValid)
                return Ok(new ServiceResponseModel { Success = false, Message = "Invalid request." });

            _contactsService.Update(new Contacts 
            {
                ContactId = request.ContactId,
                PhoneId = request.PhoneId,
                FirstName = request.FirstName,
                MiddleName = request.MiddleName,
                LastName = request.LastName,
                Organization = request.Organization,
                Title = request.Title,
                MobilePhone = request.MobilePhone,
                HomePhone = request.HomePhone,
                Notes = request.Notes,
                HomeAddress = request.HomeAddress,
                NickName = request.NickName,
                WebSite = request.WebSite,
                BirthDay = request.BirthDay,
                Status = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            });

            return Ok(new ServiceResponseModel { Success = true, Message = "Request successfully" });
        }
    }
}
