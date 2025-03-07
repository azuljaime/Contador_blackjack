using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contador_blackjack.model
{
    class Calculo445
    {

        public static string calcularValor445(string valorInput, List<CartaDTO> cartas, Label label)
        {
            double cantidadCartasGrandes = 0;
            foreach (CartaDTO carta in cartas)
            {
                if (carta.valor == valorInput.ToLower())
                {
                    carta.cantidad -= 1;
                }

                if (esUnaCartaGrande(carta))
                {
                    cantidadCartasGrandes += carta.cantidad;
                }
            }

            return devolverValor445(cantidadCartasGrandes, label);
        }

        private static string devolverValor445(double cantidadCartasGrandes, Label label)
        {
            double valor = cantidadCartasGrandes / (double)80;
            if (valor == (double)1)
            {
                return "100%";
            }
            if (valor.ToString().Length > 4)
            {
                return valor.ToString().Substring(0, 4) + "%";
            }

            actualizarColorLabe445(valor, label);

            return valor.ToString() + "%";
        }


        private static void actualizarColorLabe445(double valor, Label label)
        {
            if (valor >= (double)0.70)
            {
                label.ForeColor = Color.Red;
            }
            else
            {
                label.ForeColor = Color.Green;
            }
        }

        private static bool esUnaCartaGrande(CartaDTO carta)
        {
            return carta.valor == "10" || carta.valor == "k" || carta.valor == "q" || carta.valor == "j";
        }


    }
}
