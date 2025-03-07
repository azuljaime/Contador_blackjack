using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contador_blackjack.util
{
    class CalculosUtil
    {
        public static Label obtenerNuevoValor(Label label, bool seDebeRestarUno, bool seDebeSumarUno, bool seDebeRestarDos, bool seDebeSumarDos, bool seDebeSumarDoce)
        {
            if (seDebeRestarUno)
            {
                int v = int.Parse(label.Text) - 1;
                label.Text = v.ToString();
            }
            if (seDebeSumarUno)
            {
                int v = int.Parse(label.Text) + 1;
                label.Text = v.ToString();
            }

            if (seDebeRestarDos)
            {
                int v = int.Parse(label.Text) - 2;
                label.Text = v.ToString();
            }

            if (seDebeSumarDos)
            {
                int v = int.Parse(label.Text) + 2;
                label.Text = v.ToString();
            }

            if (seDebeSumarDoce)
            {
                int v = int.Parse(label.Text) + 12;
                label.Text = v.ToString();
            }
            return label;
        }


        public static bool estaDentroDeLaLista(string valor, List<string> lista)
        {
            foreach (string m in lista)
            {
                if (m == valor)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
