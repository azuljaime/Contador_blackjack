using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using contador_blackjack.model;
using contador_blackjack.util;

namespace contador_blackjack
{
    public partial class Form1 : Form
    {
        private string valorInput;

        private List<CartaDTO> cartas = Constantes.cartas;


        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            valorInput = this.textBox1.Text;
            
            ejecutarMetodoHiLo();      
            ejecutarMetodoKO();
            ejecutarMetodoOmega();
            ejecutarMetodoAPM();
            ejecutarMetodoHI2();
            ejecutarMetodoWH();
            ejecutarMetodo445();

            reiniciarTextBox();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.label1.Text = "0";
            this.label1.ForeColor = Color.Black;

            this.label4.Text = "0";
            this.label4.ForeColor = Color.Black;

            this.label6.Text = "0";
            this.label6.ForeColor = Color.Black;

            this.label8.Text = "100%";
            this.label8.ForeColor = Color.Black;

            this.label10.Text = "0";
            this.label10.ForeColor = Color.Black;

            this.label12.Text = "0";
            this.label12.ForeColor = Color.Black;

            this.label14.Text = "0";
            this.label14.ForeColor = Color.Black;

            this.cartas = Constantes.cartas;

            reiniciarTextBox();
        }


        /*################METODO HI-LO################*/
        private void ejecutarMetodoHiLo()
        {
            bool seDebeRestarUno = CalculosUtil.estaDentroDeLaLista(valorInput, Constantes.MENOS_UNO_HILO);
            bool seDebeSumarUno = CalculosUtil.estaDentroDeLaLista(valorInput, Constantes.MAS_UNO_HILO);

            actualizarLabel(obtenerNuevoValor(this.label1, seDebeRestarUno, seDebeSumarUno, false, false));
        }


        /*################METODO KO################*/
        private void ejecutarMetodoKO()
        {
            bool seDebeRestarUno = CalculosUtil.estaDentroDeLaLista(valorInput, Constantes.MENOS_UNO_KO);
            bool seDebeSumarUno = CalculosUtil.estaDentroDeLaLista(valorInput, Constantes.MAS_UNO_KO);

            actualizarLabel(obtenerNuevoValor(this.label4, seDebeRestarUno, seDebeSumarUno, false, false));
        }

        
        /*################METODO OMEGA################*/
        private void ejecutarMetodoOmega()
        {
            bool seDebeRestarUno = CalculosUtil.estaDentroDeLaLista(valorInput, Constantes.MENOS_UNO_OMEGA);
            bool seDebeSumarUno = CalculosUtil.estaDentroDeLaLista(valorInput, Constantes.MAS_UNO_OMEGA);
            bool seDebeRestarDos = CalculosUtil.estaDentroDeLaLista(valorInput, Constantes.MENOS_DOS_OMEGA);
            bool seDebeSumarDos = CalculosUtil.estaDentroDeLaLista(valorInput, Constantes.MAS_DOS_OMEGA);

            actualizarLabel(obtenerNuevoValor(this.label6, seDebeRestarUno, seDebeSumarUno, seDebeRestarDos, seDebeSumarDos));
        }


        /*################METODO 445################*/
        private void ejecutarMetodo445()
        {
            this.label8.Text = Calculo445.calcularValor445(valorInput, cartas, this.label8);
        }


        /*################METODO APM################*/
        private void ejecutarMetodoAPM()
        {
            bool seDebeRestarUno = CalculosUtil.estaDentroDeLaLista(valorInput, Constantes.MENOS_UNO_APM);
            bool seDebeSumarUno = CalculosUtil.estaDentroDeLaLista(valorInput, Constantes.MAS_UNO_APM);

            actualizarLabel(obtenerNuevoValor(this.label10, seDebeRestarUno, seDebeSumarUno, false, false));
        }


        /*################METODO HI2################*/
        private void ejecutarMetodoHI2()
        {
            bool seDebeSumarUno = CalculosUtil.estaDentroDeLaLista(valorInput, Constantes.MAS_UNO_HI2);
            bool seDebeSumarDos = CalculosUtil.estaDentroDeLaLista(valorInput, Constantes.MAS_DOS_HI2);
            bool seDebeRestarDos = CalculosUtil.estaDentroDeLaLista(valorInput, Constantes.MENOS_DOS_HI2);

            actualizarLabel(obtenerNuevoValor(this.label12, false, seDebeSumarUno, seDebeRestarDos, seDebeSumarDos));
        }

        /*################METODO WH################*/
        private void ejecutarMetodoWH()
        {
            
            bool seDebeRestarUno = CalculosUtil.estaDentroDeLaLista(valorInput, Constantes.MENOS_UNO_WH);
            bool seDebeRestarMedio = CalculosUtil.estaDentroDeLaLista(valorInput, Constantes.MENOS_MEDIO_WH);

            bool seDebeSumarMedio = CalculosUtil.estaDentroDeLaLista(valorInput, Constantes.MAS_MEDIO_WH);
            bool seDebeSumarUno = CalculosUtil.estaDentroDeLaLista(valorInput, Constantes.MAS_UNO_WH);

            bool seDebeSumarUnoYMedio = CalculosUtil.estaDentroDeLaLista(valorInput, Constantes.MAS_UNO_Y_MEDIO_WH);

            actualizarLabelWH(obtenerNuevoValorWH(this.label14, seDebeRestarMedio, seDebeRestarUno, seDebeSumarMedio, seDebeSumarUno, seDebeSumarUnoYMedio));
        }


        private void reiniciarTextBox()
        {
            this.textBox1.Clear();
            this.textBox1.Focus();
        }


        private void actualizarLabel(Label label)
        {
            string valor = label.Text;

            if (int.Parse(valor) > -2 && int.Parse(valor) < 2)
            {
                label.ForeColor = Color.Black;
            }

            if (int.Parse(valor) >= 2)
            {
                label.ForeColor = Color.Green;
            }

            if (int.Parse(valor) <= -2)
            {
                label.ForeColor = Color.Red;
            }
        }

        private void actualizarLabelWH(Label label)
        {
            string valor = label.Text;

            if (double.Parse(valor) > -2 && double.Parse(valor) < 2)
            {
                label.ForeColor = Color.Black;
            }

            if (double.Parse(valor) >= 2)
            {
                label.ForeColor = Color.Green;
            }

            if (double.Parse(valor) <= -2)
            {
                label.ForeColor = Color.Red;
            }
        }


        private Label obtenerNuevoValor(Label label, bool seDebeRestarUno, bool seDebeSumarUno, bool seDebeRestarDos, bool seDebeSumarDos)
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
           
            return label;
        }



        private Label obtenerNuevoValorWH(Label label, bool seDebeRestarMedio, bool seDebeRestarUno, bool seDebeSumarMedio, bool seDebeSumarUno, bool seDebeSumarUnoYMedio)
        {
            if (seDebeRestarMedio)
            {
                double v = double.Parse(label.Text) - 0.5;
                label.Text = v.ToString();
            }
            if (seDebeRestarUno)
            {
                double v = double.Parse(label.Text) - 1;
                label.Text = v.ToString();
            }

            if (seDebeSumarMedio)
            {
                double v = double.Parse(label.Text) + 0.5;
                label.Text = v.ToString();
            }

            if (seDebeSumarUno)
            {
                double v = double.Parse(label.Text) + 1;
                label.Text = v.ToString();
            }

            if (seDebeSumarUnoYMedio)
            {
                double v = double.Parse(label.Text) + 1.5;
                label.Text = v.ToString();
            }
            return label;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "1")
            {
                this.button1.Focus();
            }
        }
    }
}
