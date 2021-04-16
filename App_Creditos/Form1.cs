using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Creditos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void buttonIniciarSolu_Click(object sender, EventArgs e)
        {
            Double monto = Double.Parse(textBoxMonto.Text);
            int cuotas = int.Parse(textBoxCuotas.Text);

            

            if(monto > 500000 && cuotas >= 1 && cuotas < 36)
            {
                if (cuotas >=1 && cuotas <= 12)
                {
                    Double montoTotal = monto + (monto*10/100 );
                    textBoxResultado.Text = "" + montoTotal;
                    Double CostoCuota = montoTotal / cuotas;
                    textBoxCostoCuota.Text = "" + CostoCuota; 
                }
                else if (cuotas >= 13 && cuotas <= 24)
                {
                    Double montoTotal = monto + (monto * 20 / 100);
                    textBoxResultado.Text = "" + montoTotal;
                    Double CostoCuota = montoTotal / cuotas;
                    textBoxCostoCuota.Text = "" + CostoCuota;
                }
                else if (cuotas >=24 && cuotas <= 36)
                {
                    Double montoTotal = monto + (monto * 35 / 100);
                    textBoxResultado.Text = "" + montoTotal;
                    Double CostoCuota = montoTotal / cuotas;
                    textBoxCostoCuota.Text = "" + CostoCuota;
                }
            }
            else
            {
                MessageBox.Show("Ingrese datos validos");
            }

            

            /*
              MEJORAS
              
            -Una mejora podria ser que los resultados del monto total y eso vengan con simbolos de peso y 
             con puntos para identificar mejor el monto. 

            -Que los montos tengan maximo 1 o 2 decimales.


              ¿Como guardar las simulaciones de crédito?

            Se podrian crear objetos llamados "SimulacionCredito" o algo mas corto xd, y crear un boton 
            que sea como "enviar" o algo que ponga esos datos en un objeto y que ese objeto se guarde 
            en una Coleccion, y asi poder consultarlas y eso, supongo que se puede.



            */


        }

        private void textBoxMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
