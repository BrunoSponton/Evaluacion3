using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apuestas.BE;

namespace Apuestas.FE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal Saldo = 0;
        decimal MontoDepositado = 0;
        private decimal[] TotalApostado = new decimal[5];
        decimal MontoApostado1 = 0;
        decimal MontoApostado2 = 0;
        decimal MontoApostado3 = 0;
        decimal MontoApostado4 = 0;
        decimal MontoApostado5 = 0;
        private bool seRealizoApuesta = false;


        //Se suma al saldo el dinero que se deposita para apostar
        private void btDepositar_Click_1(object sender, EventArgs e)
        {
            MontoDepositado = Convert.ToDecimal(textBoxDeposito.Text);
            Saldo = Saldo + MontoDepositado;
            lblSaldo.Text += Saldo.ToString();
            textBoxDeposito.Text = "";
            lblSaldo.Text = Saldo.ToString();
        }

        //Se registra la apuesta del primer partido
        private void btApostar1_Click(object sender, EventArgs e)
        {
            seRealizoApuesta = true;
            MontoApostado1 = Convert.ToDecimal(textBox1.Text);
            if (MontoApostado1 > Saldo)
            {
                MessageBox.Show("Saldo Insuficiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MontoApostado1 = 0;
            }
            else if (Saldo < 0)
            {
                Saldo = 0;
            }
            else if (Saldo >= MontoApostado1)
            {
                Saldo = Saldo - MontoApostado1;
                lblSaldo.Text = Convert.ToString(Saldo);
            }
        }

        //Se registra la apuesta del segundo partido
        private void btApostar2_Click_1(object sender, EventArgs e)
        {
            seRealizoApuesta = true;
            MontoApostado2 = Convert.ToDecimal(textBox2.Text);
            if (MontoApostado2 > Saldo)
            {
                MessageBox.Show("Saldo Insuficiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MontoApostado2 = 0;
            }
            else if (Saldo < 0)
            {
                Saldo = 0;
            }
            else if (Saldo >= MontoApostado2)
            {
                Saldo = Saldo - MontoApostado2;
                lblSaldo.Text = Convert.ToString(Saldo);
            }
        }

        //Se registra la apuesta del tercer partido
        private void btApostar3_Click_1(object sender, EventArgs e)
        {
            seRealizoApuesta = true;
            MontoApostado3 = Convert.ToDecimal(textBox3.Text);
            if (MontoApostado3 > Saldo)
            {
                MessageBox.Show("Saldo Insuficiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MontoApostado3 = 0;
            }
            else if (Saldo < 0)
            {
                Saldo = 0;
            }
            else if (Saldo >= MontoApostado3)
            {
                Saldo = Saldo - MontoApostado3;
                lblSaldo.Text = Convert.ToString(Saldo);
            }
        }

        //Se registra la apuesta del cuarto partido
        private void btApostar4_Click_1(object sender, EventArgs e)
        {
            seRealizoApuesta = true;
            MontoApostado4 = Convert.ToDecimal(textBox4.Text);
            if (MontoApostado4 > Saldo)
            {
                MessageBox.Show("Saldo Insuficiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MontoApostado4 = 0;
            }
            else if (Saldo < 0)
            {
                Saldo = 0;
            }
            else if (Saldo >= MontoApostado4)
            {
                Saldo = Saldo - MontoApostado4;
                lblSaldo.Text = Convert.ToString(Saldo);
            }
        }

        //Se registra la apuesta del quinto partido
        private void btApostar5_Click_1(object sender, EventArgs e)
        {
            seRealizoApuesta = true;
            MontoApostado5 = Convert.ToDecimal(textBox5.Text);
            if (MontoApostado5 > Saldo)
            {
                MessageBox.Show("Saldo Insuficiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MontoApostado5 = 0;
            }
            else if (Saldo < 0)
            {
                Saldo = 0;
            }
            else if (Saldo >= MontoApostado5)
            {
                Saldo = Saldo - MontoApostado5;
                lblSaldo.Text = Convert.ToString(Saldo);
            }
        }

        //Realiza calculos de montos apostados y elije un resultado de cada partido al azar,
        // tambien calcula la recompensa al acertar el resultado (La cual duplica el monto apostado)
        private void btResultados_Click_1(object sender, EventArgs e)
        {
            if (!seRealizoApuesta)
            {
                MessageBox.Show("Debes realizar al menos una apuesta antes de ver los resultados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random random = new Random();
            //Se genera resultado del partido 1
            Partido partido1 = new Partido();
            partido1.GenerarResultado(random);
            partido1.AsignarGanador();
            lblr1.Text = partido1.Resultado;
            //Se genera resultado del partido 2
            Partido partido2 = new Partido();
            partido2.GenerarResultado(random);
            partido2.AsignarGanador();
            lblr2.Text = partido2.Resultado;
            //Se genera resultado del partido 3
            Partido partido3 = new Partido();
            partido3.GenerarResultado(random);
            partido3.AsignarGanador();
            lblr3.Text = partido3.Resultado;
            //Se genera resultado del partido 4
            Partido partido4 = new Partido();
            partido4.GenerarResultado(random);
            partido4.AsignarGanador();
            lblr4.Text = partido4.Resultado;
            //Se genera resultado del partido 5
            Partido partido5 = new Partido();
            partido5.GenerarResultado(random);
            partido5.AsignarGanador();
            lblr5.Text = partido5.Resultado;

            // Verifica cuál radio button está seleccionado para cada groupbox

            //GROUPBOX1
            if (rbLocal1.Checked && partido1.Resultado == "Local")
            {
                MontoApostado1 *= 2;
            }
            else if (rbEmpate1.Checked && partido1.Resultado == "Empate")
            {
                MontoApostado1 *= 2;
            }
            else if (rbVisitante1.Checked && partido1.Resultado == "Visitante")
            {
                MontoApostado1 *= 2;
            }
            else
            {
                MontoApostado1 = 0;
            }


            //GROUPBOX2
            if (rbLocal2.Checked && partido2.Resultado == "Local")
            {
                MontoApostado2 *= 2;
            }
            else if (rbEmpate2.Checked && partido2.Resultado == "Empate")
            {
                MontoApostado2 *= 2;
            }
            else if (rbVisitante2.Checked && partido2.Resultado == "Visitante")
            {
                MontoApostado2 *= 2;
            }
            else
            {
                MontoApostado2 = 0;
            }

            //GROUPBOX3
            if (rbLocal3.Checked && partido3.Resultado == "Local")
            {
                MontoApostado3 *= 2;
            }
            else if (rbEmpate3.Checked && partido3.Resultado == "Empate")
            {
                MontoApostado3 *= 2;
            }
            else if (rbVisitante3.Checked && partido3.Resultado == "Visitante")
            {
                MontoApostado3 *= 2;
            }
            else
            {
                MontoApostado3 = 0;
            }

            //GROUPBOX4
            if (rbLocal4.Checked && partido4.Resultado == "Local")
            {
                MontoApostado4 *= 2;
            }
            else if (rbEmpate4.Checked && partido4.Resultado == "Empate")
            {
                MontoApostado4 *= 2;
            }
            else if (rbVisitante4.Checked && partido4.Resultado == "Visitante")
            {
                MontoApostado4 *= 2;
            }
            else
            {
                MontoApostado4 = 0;
            }

            //GROUPBOX5
            if (rbLocal5.Checked && partido5.Resultado == "Local")
            {
                MontoApostado5 *= 2;
            }
            else if (rbEmpate5.Checked && partido5.Resultado == "Empate")
            {
                MontoApostado5 *= 2;
            }
            else if (rbVisitante5.Checked && partido5.Resultado == "Visitante")
            {
                MontoApostado5 *= 2;
            }
            else
            {
                MontoApostado5 = 0;
            }

            // Actualiza el Saldo sumando el MontoApostado al Saldo actual
            TotalApostado[0] = MontoApostado1;
            TotalApostado[1] = MontoApostado2;
            TotalApostado[2] = MontoApostado3;
            TotalApostado[3] = MontoApostado4;
            TotalApostado[4] = MontoApostado5;

            for (int i = 0; i < TotalApostado.Length; i++)
            {
                Saldo += TotalApostado[i];
            }


            // Muestra el Saldo actualizado en lblSaldo
            lblSaldo.Text = Saldo.ToString();

            //Se reinician las variables para generar el proximo resultado desde 0
            MontoApostado1 = 0;
            MontoApostado2 = 0;
            MontoApostado3 = 0;
            MontoApostado4 = 0;
            MontoApostado5 = 0;
            seRealizoApuesta = false;
        }

   
    }
}
