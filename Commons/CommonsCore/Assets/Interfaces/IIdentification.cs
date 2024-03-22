using CommonsCore.Assets.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonsCore.Assets.Interfaces
{
    public interface IIdentification
    {
        Guid Id { get; set; }
        string AssetCode { get; set; }
        string AssetDescription { get; set; }
        string AssetComplement { get; set; }
    }
}
