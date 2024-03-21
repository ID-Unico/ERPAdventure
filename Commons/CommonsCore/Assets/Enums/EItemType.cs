using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonsCore.Assets.Enums
{
    public enum EItemType
    {   
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
        GoodsForResale = 0,
        RawMaterial = 1,
        Packaging = 2,
        WorkInProgress = 3,
        FinishedProduct = 4,
        ByProduct = 5,
        IntermediateProduct = 6,
        SuppliesAndConsumables = 7,
        FixedAssets = 8,
        Services = 9,
        OtherInputs = 10,
        Others = 99
    }
}
