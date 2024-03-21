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
     
        string WarehouseUnitMeasurementCode { get; set; }
        string WarehouseUnitMeasurementDescription { get; set; }
        
        string PurchaseUnitMeasurementCode { get; set; }
        string PurchaseUnitMeasurementDescription { get; set; }
        
        string SaleUnitMeasurementCode { get; set; }
        string SaleUnitMeasurementDescription { get; set; }
        
        string DensityMeasurementCode { get; set; }
        string DensityMeasurementDescription { get; set; }
        decimal DensityFactor { get; set; }
    }
}
