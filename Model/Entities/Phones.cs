using System;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Model.Entities
{
    public class Phones : IEntity {
        [Key]
        public int PhoneId { get; set; }
        [Required]
        [StringLength(15)]
        public string PhoneNumber {get; set;}
        [Required]
        public DateTime CreatedDate {get; set;}
        public DateTime ModifiedDate {get; set;}
        [Required]
        public bool Status { get; set; }
    }
}