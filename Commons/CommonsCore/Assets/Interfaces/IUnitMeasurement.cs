using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonsCore.Assets.Interfaces
{
    public interface IUnitMeasurement
    {
        string UnitMeasurementCode { get; set; }
        string UnitMeasurementDescription { get; set; }
    }
}
