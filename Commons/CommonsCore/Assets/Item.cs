using CommonsCore.Assets.Enums;
using CommonsCore.Assets.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonsCore.Assets
{
    internal class Item : IIdentification, IClassification, IUnitMeasurement
    {
        [Key]
        public Guid Id { get; set; }
        //00: Mercadoria para Revenda
        //01: Matéria-Prima
        //02: Embalagem
        //03: Produto em Processo
        //04: Produto Acabado
        //05: Subproduto
        //06: Produto Intermediário
        //07: Material de Uso e Consumo
        //08: Ativo Imobilizado
        //09: Serviços
        //10: Outros insumos
        //99: Outras
        public EItemType ItemTypeId { get; set; }

        [StringLength(60)]
        public string ItemTypeName { get; set; }

        //Codigo do item
        [StringLength(60)]
        public string ItemCode { get; set; }

        //Descrição do Item
        [StringLength(255)]
        public string ItemDescription { get; set; }

        [StringLength(1000)]
        public string ItemComplement { get; set; }

        //Codigo de barras do produto (opcional)
        public string ItemBarCode { get; set; }

        //Código NCM (Nomenclatura Comum do Mercosul) 
        [StringLength(8)]
        public string NCM { get; set; }
        //Código EX da TIPI (Tabela de Incidência do IPI)  
        [StringLength(3)]
        public string ExIpi { get; set; }

        [StringLength(6)]
        public string WarehouseUnitMeasurementCode { get; set; }

        [StringLength(60)]
        public string WarehouseUnitMeasurementDescription { get; set; }

        [StringLength(6)]
        public string PurchaseUnitMeasurementCode { get; set; }

        [StringLength(60)]
        public string PurchaseUnitMeasurementDescription { get; set; }

        [StringLength(6)]
        public string SaleUnitMeasurementCode { get; set; }

        [StringLength(60)]
        public string SaleUnitMeasurementDescription { get; set; }

        [StringLength(6)]
        public string DensityMeasurementCode { get; set; }

        [StringLength(60)]
        public string DensityMeasurementDescription { get; set; }
        public decimal DensityFactor { get; set; }
    }
}
