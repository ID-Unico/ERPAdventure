using CommonsCore.Assets.Enums;
using CommonsCore.Assets.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonsCore.Assets.Base
{
    public abstract class Asset : IIdentification, IClassification, IUnitMeasurement
    {
        [Key]
        public Guid Id { get; set; }
        //Piece = 0,
        //Equipament = 1,
        //Machine = 2,
        //Facilities = 3
        public EAssetType AssetTypeId { get; set; }

        [StringLength(20)]
        public string AssetType { get; set; }

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

        [StringLength(20)]
        public string ItemType { get; set; }

        [StringLength(60)]
        public string AssetCode { get; set; }
        [StringLength(255)]
        public string AssetDescription { get; set; }
        [StringLength(1000)]
        public string AssetComplement { get; set; }
        [StringLength(11)]
        public string NCM { get; set; }
        [StringLength(3)]
        public string ExIpi { get; set; }
        [StringLength(6)]
        public string UnitMeasurementCode { get; set; }
        [StringLength(255)]
        public string UnitMeasurementDescription { get; set; }
    }
}
