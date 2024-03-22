using CommonsCore.Participants.Base;
using CommonsCore.Participants.Interfaces.Components;
using System.ComponentModel.DataAnnotations;

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
