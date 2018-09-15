using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace TAHTSData.Models
{
    public class RegisteredUser
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string DBlood { get; set; }
        public string LCpr { get; set; }
        public int EventId { get; set; }
        public string PDFLink { get; set; }
        public int MType { get; set; }
        public string RegisterId { get; set; }
        public bool AcceptTerm { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Event Event { get; set; }
    }
}
