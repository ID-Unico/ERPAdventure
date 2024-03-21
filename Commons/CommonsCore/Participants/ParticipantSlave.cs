using CommonsCore.Participants.Abstracts;
using CommonsCore.Participants.Enums;
using CommonsCore.Participants.Interfaces;
using CommonsCore.Participants.Interfaces.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonsCore.Participants
{
    public  class ParticipantSlave : Participant, IUser
    {
        [StringLength(60)]
        public string UserName { get; set; }

        [StringLength(500)]
        public string UserEmail { get; set; }

        [StringLength(1000)]
        public string UserPassword { get; set; }

        public Guid DomainID { get; set; }
    }
}
