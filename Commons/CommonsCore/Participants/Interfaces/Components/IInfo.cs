using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonsCore.Participants.Interfaces.Components
{
    public interface IInfo
    {
        Guid Id { get; }
        string Code { get; set; }
        string Name { get; set; }
        string Nickname { get; set; }
    }
}
