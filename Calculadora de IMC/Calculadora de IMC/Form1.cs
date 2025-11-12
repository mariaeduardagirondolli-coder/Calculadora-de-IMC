using System.Diagnostics.Eventing.Reader;

namespace Calculadora_de_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void addNumber(object sender, EventArgs e)
        {
            if (txtPeso.BackColor == Color.Red)
            {
                if ((sender as Button).Text != "," || !txtPeso.Text.Contains(","))
                {
                    txtPeso.Text += (sender as Button).Text;
                }

            }
            else
            {
                if ((sender as Button).Text != "," || !txtAltura.Text.Contains(","))
                {
                    txtAltura.Text += (sender as Button).Text;
                }
            }
        }


                private void panel4_Paint(object sender, PaintEventArgs e)
                {

                }

        private void txtPeso_Enter(object sender, EventArgs e)
        {
            txtPeso.BackColor = Color.Red;
            txtAltura.BackColor = Color.White;
        }

        private void txtAltura_Enter(object sender, EventArgs e)
        {
            txtAltura.BackColor = Color.Red;
            txtPeso.BackColor = Color.White;
        }

        private void btncalcularIMC_Click(object sender, EventArgs e)
        {

        }

        private void txtIMC_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(txtPeso.BackColor == Color.Red)
            {
                txtPeso.ResetText();
            }
            if(txtAltura.BackColor == Color.Red) 
            { 
                txtAltura.ResetText();
            }
        }
    }
}
