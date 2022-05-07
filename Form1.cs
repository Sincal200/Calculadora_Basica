namespace Calculadora_Basica
{
    public partial class Form1 : Form
    {
        double num1 = 0, num2 = 0;
        char operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void escribir_numero(String datos)
        {
            if(Result.Text == "0")
            {
                Result.Text = "";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            String valor = btn0.Text;
            escribir_numero(valor);
            Result.Text += valor; 
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            String valor = btn1.Text;
            escribir_numero(valor);
            Result.Text += valor;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            String valor = btn2.Text;
            escribir_numero(valor);
            Result.Text += valor;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            String valor = btn3.Text;
            escribir_numero(valor);
            Result.Text += valor;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            String valor = btn4.Text;
            escribir_numero(valor);
            Result.Text += valor;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            String valor = btn5.Text;
            escribir_numero(valor);
            Result.Text += valor;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            String valor = btn6.Text;
            escribir_numero(valor);
            Result.Text += valor;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            String valor = btn7.Text;
            escribir_numero(valor);
            Result.Text += valor;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            String valor = btn8.Text;
            escribir_numero(valor);
            Result.Text += valor;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            String valor = btn9.Text;
            escribir_numero(valor);
            Result.Text += valor;
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            String valor = btnpunto.Text;
            escribir_numero(valor);
            Result.Text += valor;
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(Result.Text); 

            if(operacion == '+')
            {
                Result.Text = Convert.ToString((num1 + num2));  
                num1 = Convert.ToDouble(Result.Text);
            }else if(operacion == '-')
            { 
                Result.Text = Convert.ToString((num1 - num2));
                num1 = Convert.ToDouble(Result.Text);
            }else if(operacion== '*')
            {
                Result.Text = Convert.ToString((num1 * num2));
                num1 = Convert.ToDouble(Result.Text);
            }
            else if(operacion == '/')
            {
                if(Result.Text != "0")
                {
                    Result.Text = Convert.ToString((num1 / num2));
                    num1 = Convert.ToDouble(Result.Text);
                }
                else
                {
                    MessageBox.Show("No se puede dividir por cero");
                }
            }   
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Result.Text);
            operacion = '*';
            Result.Text = "0";
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Result.Text);
            operacion = '/';
            Result.Text = "0";
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Result.Text);
            operacion = '-';
            Result.Text = "0";
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            Result.Text = "0";

        }

        private void btnborrar1_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Result.Text);
            operacion = '+';
            Result.Text = "0";
        }
    }
}