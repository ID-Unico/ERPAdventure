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
        EItemType ItemTypeId { get; set; }
        string ItemTypeName { get; set; }
        string ItemCode { get; set; }
        string ItemDescription { get; set; }
        string ItemComplement { get; set; }
        string ItemBarCode { get; set; }
    }
}
