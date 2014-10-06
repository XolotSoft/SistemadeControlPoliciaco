using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemadeControlPoliciaco
{
    public partial class calculadora : Form
    {
        bool ceroinicial = true;    //para controlar el cero que tiene la calculadora al iniciar
        bool pdecimal = true;       //para controlar el punto decimal
        bool op = true;             //para controlar el resultado cuando se presiona cada signo aritmetico
        bool igual = true;          //para controlar el estado del boton de igualdad
        string operacion;           //variable usada en el case de la igualdad
        double numero1 = 0;         //variable para el primer valor
        double numero2 = 0;         //variabla para el segundo valor
        double temp = 0;            //variable para el resultado

        public calculadora()
        {
            InitializeComponent();
        }

        private void calculadora_Load(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (ceroinicial)
            {
                txtPantalla.Text = " ";
                txtPantalla.Text = "1";
                ceroinicial = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "1";
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (ceroinicial)
            {
                txtPantalla.Text = " ";
                txtPantalla.Text = "2";
                ceroinicial = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "2";
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (ceroinicial)
            {
                txtPantalla.Text = " ";
                txtPantalla.Text = "3";
                ceroinicial = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "3";
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (ceroinicial)
            {
                txtPantalla.Text = " ";
                txtPantalla.Text = "4";
                ceroinicial = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "4";
            }
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (ceroinicial)
            {
                txtPantalla.Text = " ";
                txtPantalla.Text = "5";
                ceroinicial = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "5";
            }
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (ceroinicial)
            {
                txtPantalla.Text = " ";
                txtPantalla.Text = "6";
                ceroinicial = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "6";
            }
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (ceroinicial)
            {
                txtPantalla.Text = " ";
                txtPantalla.Text = "7";
                ceroinicial = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "7";
            }
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (ceroinicial)
            {
                txtPantalla.Text = " ";
                txtPantalla.Text = "8";
                ceroinicial = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "8";
            }
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (ceroinicial)
            {
                txtPantalla.Text = " ";
                txtPantalla.Text = "9";
                ceroinicial = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "9";
            }
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {

            }
            else
            {
                if (ceroinicial)
                {
                    txtPantalla.Text = " ";
                    txtPantalla.Text = "0";
                    ceroinicial = false;
                }
                else
                {
                    txtPantalla.Text = txtPantalla.Text + "0";
                }

            }
        }

        private void btsum_Click(object sender, EventArgs e)
        {
            ceroinicial = true;
            pdecimal = true;

            if (op)   
            {
                numero1 = double.Parse(txtPantalla.Text);
                txtPrevio.Text = txtPrevio.Text + txtPantalla.Text + " + ";
                op = false;
            }
            else    
            {
                numero2 = double.Parse(txtPantalla.Text);
                txtPrevio.Text = txtPrevio.Text + txtPantalla.Text + " + ";

                switch (operacion)
                {
                    case "+":

                        temp = numero1 + numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);
                        break;

                    case "-":

                        temp = numero1 - numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);

                        break;

                    case "*":

                        temp = numero1 * numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);

                        break;

                    case "/":
                        if (numero2 == 0)
                        {

                            txtPantalla.Text = "Error";
                            break;
                        }
                        else
                        {

                            temp = numero1 / numero2;
                            txtPantalla.Text = temp.ToString();
                            numero1 = double.Parse(txtPantalla.Text);
                            break;
                        }

                }

            }
            operacion = "+";

        }

        private void btres_Click(object sender, EventArgs e)
        {
            ceroinicial = true;
            pdecimal = true;

            if (op)    
            {
                numero1 = double.Parse(txtPantalla.Text);
                txtPrevio.Text = txtPrevio.Text + txtPantalla.Text + " - ";
                op = false;
            }
            else    
            {
                numero2 = double.Parse(txtPantalla.Text);
                txtPrevio.Text = txtPrevio.Text + txtPantalla.Text + " - ";


                switch (operacion)
                {
                    case "+":

                        temp = numero1 + numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);
                        break;

                    case "-":

                        temp = numero1 - numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);

                        break;

                    case "*":

                        temp = numero1 * numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);

                        break;

                    case "/":
                        if (numero2 == 0)
                        {

                            txtPantalla.Text = "Error";
                            break;
                        }
                        else
                        {

                            temp = numero1 / numero2;
                            txtPantalla.Text = temp.ToString();
                            numero1 = double.Parse(txtPantalla.Text);
                            break;
                        }

                }

            }
            operacion = "-";
        }

        private void btmul_Click(object sender, EventArgs e)
        {
            ceroinicial = true;
            pdecimal = true;

            if (op)   
            {
                numero1 = double.Parse(txtPantalla.Text);
                txtPrevio.Text = txtPrevio.Text + txtPantalla.Text + " * ";
                op = false;
            }
            else   
            {
                numero2 = double.Parse(txtPantalla.Text);
                txtPrevio.Text = txtPrevio.Text + txtPantalla.Text + " * ";


                switch (operacion)
                {
                    case "+":

                        temp = numero1 + numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);
                        break;

                    case "-":

                        temp = numero1 - numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);

                        break;

                    case "*":

                        temp = numero1 * numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);

                        break;

                    case "/":
                        if (numero2 == 0)
                        {

                            txtPantalla.Text = "Error";
                            break;
                        }
                        else
                        {

                            temp = numero1 / numero2;
                            txtPantalla.Text = temp.ToString();
                            numero1 = double.Parse(txtPantalla.Text);
                            break;
                        }

                }

            }
            operacion = "*";
        }

        private void btdiv_Click(object sender, EventArgs e)
        {
            ceroinicial = true;
            pdecimal = true;

            if (op)   
            {
                numero1 = double.Parse(txtPantalla.Text);
                txtPrevio.Text = txtPrevio.Text + txtPantalla.Text + " / ";
                op = false;
            }
            else  
            {
                numero2 = double.Parse(txtPantalla.Text);
                txtPrevio.Text = txtPrevio.Text + txtPantalla.Text + " / ";


                switch (operacion)
                {
                    case "+":

                        temp = numero1 + numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);
                        break;

                    case "-":

                        temp = numero1 - numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);

                        break;

                    case "*":

                        temp = numero1 * numero2;
                        txtPantalla.Text = temp.ToString();
                        numero1 = double.Parse(txtPantalla.Text);

                        break;

                    case "/":
                        if (numero2 == 0)
                        {

                            txtPantalla.Text = "Error";
                            break;
                        }
                        else
                        {

                            temp = numero1 / numero2;
                            txtPantalla.Text = temp.ToString();
                            numero1 = double.Parse(txtPantalla.Text);
                            break;
                        }

                }
            }
            operacion = "/";
        }

        private void btigual_Click(object sender, EventArgs e)
        {
            
           ceroinicial = true;
           pdecimal = true;
           op = true;

           if (igual)   
           {
               numero2 = double.Parse(txtPantalla.Text);
               switch (operacion)
               {
                   case "+":
                       txtPrevio.Text = txtPrevio.Text + txtPantalla.Text;
                       temp = numero1 + numero2;
                       txtPantalla.Text = temp.ToString();
                       break;

                   case "-":
                       txtPrevio.Text = txtPrevio.Text + txtPantalla.Text;
                       temp = numero1 - numero2;
                       txtPantalla.Text = temp.ToString();
                       break;

                   case "*":
                       txtPrevio.Text = txtPrevio.Text + txtPantalla.Text;
                       temp = numero1 * numero2;
                       txtPantalla.Text = temp.ToString();
                       break;

                   case "/":
                       if (numero2 == 0)
                       {
                           txtPrevio.Text = txtPrevio.Text + txtPantalla.Text;
                           txtPantalla.Text = "Error";
                           break;
                       }
                       else
                       {
                           txtPrevio.Text = txtPrevio.Text + txtPantalla.Text;
                           temp = numero1 / numero2;
                           txtPantalla.Text = temp.ToString();
                           break;
                       }

               }
               igual = false;
           }

           else  
           {
               switch (operacion)
               {
                   case "+":
                       temp = temp + numero2;
                       txtPantalla.Text = temp.ToString();
                       break;

                   case "-":
                       temp = temp - numero2;
                       txtPantalla.Text = temp.ToString();
                       break;

                   case "*":
                       temp = temp * numero2;
                       txtPantalla.Text = temp.ToString();
                       break;

                   case "/":
                       if (numero2 == 0)
                       {
                           txtPrevio.Text = txtPrevio.Text + txtPantalla.Text;
                           txtPantalla.Text = "Error";
                           break;
                       }
                       else
                       {
                           temp = temp / numero2;
                           txtPantalla.Text = temp.ToString();
                           break;
                       }

               }

           }

           txtPrevio.Text = " "; 
        }

        private void btp_Click(object sender, EventArgs e)
        {
            if (ceroinicial) 
            {
                txtPantalla.Text = " ";
                txtPantalla.Text = "0";
                ceroinicial = false;
            }

            if (pdecimal)  
            {
                txtPantalla.Text = txtPantalla.Text + ".";
                pdecimal = false;
            }
        }

        private void btc_Click(object sender, EventArgs e)
        {
            ceroinicial = true;
            pdecimal = true;
            operacion = null;
            op = true;
            igual = true;
            numero1 = 0;
            numero2 = 0;

            temp = 0;
            txtPrevio.Text = " ";
            txtPantalla.Text = "0";
        }

        private void btce_Click(object sender, EventArgs e)
        {
            ceroinicial = true;
            pdecimal = true;
            txtPantalla.Text = "0";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtPantalla.Text);
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = " ";
            txtPantalla.Paste();  
        }
    }
}