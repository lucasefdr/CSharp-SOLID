﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.Heranca
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int Numero, string Titular) : base(Numero, Titular)
        {
        }

        public decimal Limite { get; private set; }

        public void DescontaJutos()
        {

        }
    }
}
