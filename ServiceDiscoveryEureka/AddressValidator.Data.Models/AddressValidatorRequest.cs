using System;
using System.Collections.Generic;
using System.Text;
using AddressValidator.Data.Models.Enums;

namespace AddressValidator.Data.Models
{
    public class AddressValidatorRequest
    {
        public AddressValidatorType AddressValidator { get; set; }

        public List<Address> Addresses { get; set; }
    }
}
