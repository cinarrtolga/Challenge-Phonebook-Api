using System;
using System.ComponentModel.DataAnnotations;

namespace Model.DataTransferObjects
{
    public class ContactModel {
        public int ContactId {get; set;}
        [Required]
        public int PhoneId { get; set; }
        [Required]
        [StringLength(128)]
        public string FirstName { get; set; }
        [StringLength(128)]
        public string MiddleName { get; set; }
        [StringLength(128)]
        public string LastName { get; set; }
        [StringLength(256)]
        public string Organization { get; set; }
        [StringLength(256)]
        public string Title { get; set; }
        [StringLength(14)]
        public string MobilePhone { get; set; }
        [StringLength(14)]
        public string HomePhone { get; set; }
        [StringLength(512)]
        public string Notes { get; set; }
        [StringLength(256)]
        public string HomeAddress { get; set; }
        [StringLength(128)]
        public string NickName { get; set; }
        [StringLength(128)]
        public string WebSite { get; set; }
        public DateTime? BirthDay { get; set; }
        [Required]
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate {get; set;}
        [Required]
        public bool Status { get; set; }
    }
}