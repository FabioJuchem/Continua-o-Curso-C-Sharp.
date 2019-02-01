using System;
using System.Collections.Generic;
using System.Text;
using FixacaoEnumComp01.Entities;
using FixacaoEnumComp01.Entities.Enums;

namespace FixacaoEnumComp01.Entities.Enums
{
    enum OrderStatus : int
    {
        PrendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
