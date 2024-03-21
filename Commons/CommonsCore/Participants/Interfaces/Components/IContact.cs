using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonsCore.Participants.Interfaces.Components
{
    public interface IContact
    {
        string Email { get; set; }
        string PhoneNumber { get; set; }

    }
}
