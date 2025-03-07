using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contador_blackjack
{
    class CartaDTO
    {
        public string valor;
        public int cantidad;

        public CartaDTO(string valor, int cantidad)
        {
            this.valor = valor;
            this.cantidad = cantidad;
        }
    }
}
