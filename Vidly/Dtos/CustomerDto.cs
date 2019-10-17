using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public byte Id { get; set; }
        [Required(ErrorMessage = "Please Enter Customer Name.")]
        [StringLength(255)]
        public string Name { get; set; }
        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
        public bool IsSubscribeToNewsLetter { get; set; }
        public MembershipTypeDto MembershipType { get; set; }          
        public byte MembershipTypeId { get; set; }
    }
}