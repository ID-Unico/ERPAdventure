using CommonsCore.Participants.Interfaces.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonsCore.Participants.Interfaces
{
    internal interface IParticipant : IInfo, IContact, IAddress, IParticipantType
    {
    }
}
