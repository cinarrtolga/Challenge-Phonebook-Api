using System;
using System.ComponentModel.DataAnnotations;

namespace Model.DataTransferObjects
{
    public class PhoneModel {
        public int PhoneId { get; set; }
        [Required]
        [StringLength(15)]
        public string PhoneNumber {get; set;}
        public DateTime CreatedDate {get; set;}
        public DateTime ModifiedDate {get; set;}
        public bool Status { get; set; }
    }
}