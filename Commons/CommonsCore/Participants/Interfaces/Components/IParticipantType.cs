using CommonsCore.Participants.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonsCore.Participants.Interfaces.Components
{
    public interface IParticipantType : ITypeNatural, ITypeCorporate
    {
        EParticipantType ParticipantType { get; set; }



    }
}
