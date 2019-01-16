using MVCWebTest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWebTest.ViewModels
{
    public class ContactEditViewModel
    {
        [Required]
        public Contact Contact { get; set; }
        [Required]
        public List<CheckBoxListItem> Categories { get; set; }
        [Required]
        public List<PhoneNumber> PhoneNumbers { get; set; }
    }
}