﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator.Problem
{
    public class Itau
    {
        private readonly Pedido pedido;

        public Itau(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public Decimal ObterTaxaJuros()
        {
            var total = this.pedido.ObterPercentualJuros();
            return total * 15 / 100;
        }
    }
}
