using System;
using System.Windows.Forms;

namespace WindowsCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double numero1, numero2, resultado;
        char operador;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "0";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "4";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "3";
               
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "6";
               
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "7";
        }

        private void btnu8_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtPainel.Text += ".";
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtPainel.Text); 
            txtPainel.Text += "+";
            operador = '+';
            lblCalculo.Text = txtPainel.Text;
            lblCalculo.Visible = true;
            txtPainel.Clear();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtPainel.Text);
            switch (operador)
            {
                case '+':
                    resultado = numero1 + numero2;

                break;

                case '/':
                    resultado = numero1 / numero2;

                    break;

                case '*':
                    resultado = numero1 * numero2;

                    break;
                case '-':
                    resultado = numero1 - numero2;

                    break;
            }
            lblCalculo.Text += numero2;
            txtPainel.Text = resultado.ToString();
        }

        private void btnSubitracao_Click(object sender, EventArgs e)
        {
            
            numero1 = Convert.ToDouble(txtPainel.Text);
            txtPainel.Text += "-";
            operador = '-';
            lblCalculo.Text = txtPainel.Text;
            lblCalculo.Visible = true;
            txtPainel.Clear();
        }

        private void btnMutiplicacao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtPainel.Text);
            txtPainel.Text += "*";
            operador = '*';
            lblCalculo.Text = txtPainel.Text;
            lblCalculo.Visible = true;
            txtPainel.Clear();


        }

        private void btnDivicao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtPainel.Text);
            txtPainel.Text += "/";
            operador = '/';
            lblCalculo.Text = txtPainel.Text;
            lblCalculo.Visible = true;
            txtPainel.Clear();


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPainel.Clear();
            lblCalculo.Text = string.Empty;

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txtPainel.Text!=string.Empty)
            {
                txtPainel.Text = txtPainel.Text.Remove(txtPainel.Text.Length - 1);
            }
            lblCalculo.Text = lblCalculo.Text.Remove(lblCalculo.Text.Length-1);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "0";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "4";
        }
    }
}
