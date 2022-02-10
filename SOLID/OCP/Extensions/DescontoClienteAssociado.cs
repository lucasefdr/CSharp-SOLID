﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Extensions
{
    public class DescontoClienteAssociado : PedidoOCP
    {
        public override double DescontaPedido(double valorFinal)
        {
            return valorFinal - 10;
        }
    }
}
