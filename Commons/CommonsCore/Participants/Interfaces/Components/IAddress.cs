using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonsCore.Participants.Interfaces.Components
{
    public interface IAddress
    {
        public string ZipCode { get; set; }
        public string Neighborhood { get; set; }
        public string AddressName { get; set; }
        public string AddressComplement { get; set; }
        public string AddressNumber { get; set; }
        public int StateId { get; set; }
        public string StateName { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string AddressRemarks { get; set; }
    }
}
