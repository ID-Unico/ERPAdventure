using CommonsCore.Participants.Enums;
using CommonsCore.Participants.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonsCore.Participants.Abstracts
{
    public abstract class Participant : IParticipant
    {
        [Key]
        public Guid Id { get; }

        [StringLength(60)]
        public string Code { get; set; }

        [StringLength(60)]
        public string Name { get; set; }

        [StringLength(60)]
        public string Nickname { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(8)]
        public string ZipCode { get; set; }

        [StringLength(60)]
        public string Neighborhood { get; set; }

        [StringLength(60)]
        public string AddressName { get; set; }

        [StringLength(60)]
        public string AddressComplement { get; set; }

        [StringLength(60)]
        public string AddressNumber { get; set; }
        public int StateId { get; set; }

        [StringLength(60)]
        public string StateName { get; set; }
        public int CountryId { get; set; }

        [StringLength(60)]
        public string CountryName { get; set; }
        public int CityId { get; set; }

        [StringLength(60)]
        public string CityName { get; set; }

        [StringLength(255)]
        public string AddressRemarks { get; set; }
        public EParticipantType ParticipantType { get; set; }

        [StringLength(11)]
        public string CPF { get; set; }

        [StringLength(14)]
        public string CNPJ { get; set; }
    }
}
