using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contador_blackjack.util
{
    class Constantes
    {

        public static List<string> MAS_UNO_HILO = new List<string> { "2", "3", "4", "5", "6" };
        public static List<string> MENOS_UNO_HILO = new List<string> { "A", "a", "J", "j", "Q", "q", "K", "k" };

        public static List<string> MAS_UNO_KO = new List<string> { "2", "3", "4", "5", "6", "7" };
        public static List<string> MENOS_UNO_KO = new List<string> { "10", "A", "a", "J", "j", "Q", "q", "K", "k" };

        public static List<string> MAS_UNO_OMEGA = new List<string> { "2", "3", "7" };
        public static List<string> MAS_DOS_OMEGA = new List<string> { "4", "5", "6" };
        public static List<string> MENOS_UNO_OMEGA = new List<string> { "9" };
        public static List<string> MENOS_DOS_OMEGA = new List<string> { "10", "J", "j", "Q", "q", "K", "k" };

        public static List<string> MAS_UNO_APM = new List<string> { "3", "4", "5", "6", "7" };
        public static List<string> MENOS_UNO_APM = new List<string> { "10", "A", "a", "J", "j", "Q", "q", "K", "k" };

        public static List<string> MAS_UNO_HI2 = new List<string> { "2", "3", "6", "7" };
        public static List<string> MAS_DOS_HI2 = new List<string> { "4", "5" };
        public static List<string> MENOS_DOS_HI2 = new List<string> { "10", "J", "j", "Q", "q", "K", "k" };


        public static List<string> MENOS_UNO_WH = new List<string> { "10", "J", "j", "Q", "q", "K", "k" };
        public static List<string> MENOS_MEDIO_WH = new List<string> { "8" };
        public static List<string> MAS_UNO_WH = new List<string> { "3", "4", "6" };
        public static List<string> MAS_UNO_Y_MEDIO_WH = new List<string> { "5" };
        public static List<string> MAS_MEDIO_WH = new List<string> { "2", "7"};
        public static List<string> MENOS_DOS_WH = new List<string> { "10", "J", "j", "Q", "q", "K", "k" };

        public static List<CartaDTO> cartas = new List<CartaDTO> {
            new CartaDTO("a", 20), new CartaDTO("1", 20), new CartaDTO("2", 20), new CartaDTO("3", 20), new CartaDTO("4", 20), new CartaDTO("5", 20), new CartaDTO("6", 20),
            new CartaDTO("7", 20), new CartaDTO("8", 20), new CartaDTO("9", 20), new CartaDTO("10", 20), new CartaDTO("j", 20), new CartaDTO("q", 20), new CartaDTO("k", 20),
        };
    }
}
