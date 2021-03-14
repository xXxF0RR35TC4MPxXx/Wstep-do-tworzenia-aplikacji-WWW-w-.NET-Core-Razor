using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AddressBook.Pages.Forms
{
    public class Address
    {
        [Display(Name = "Twoja ulubiona ulica")]
        [StringLength(30, MinimumLength = 2), Required(ErrorMessage ="Pole jest obowiązkowe!")]
        public string Street { get; set; }

        [StringLength(10, MinimumLength = 2), Required(ErrorMessage = "Podaj numer domu!")]
        public string Number { get; set; }

        [StringLength(10, MinimumLength = 4), Required(ErrorMessage = "Podaj kod pocztowy!")]
        public string ZipCode { get; set; }

        [StringLength(30, MinimumLength = 2), Required(ErrorMessage = "Nazwa miasta jest obowiązkowa!")]
        public string City { get; set; }


    }
}
