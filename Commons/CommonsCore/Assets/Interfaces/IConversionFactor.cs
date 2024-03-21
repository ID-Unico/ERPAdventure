using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonsCore.Assets.Interfaces
{
    public interface IConversionFactor
    {
        string FromUnitMeasurementCode { get; set; }
        string FromUnitMeasurementDescription { get; set; }

        string ToUnitMeasurementCode { get; set; }
        string ToUnitMeasurementDescription { get; set; }

        decimal ToConversionFactor { get; set; }
    }
}
