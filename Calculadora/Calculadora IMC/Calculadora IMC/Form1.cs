using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;



namespace Calculadora_IMC

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



        private void panel1_Paint(object sender, PaintEventArgs e)

        {



        }



        private void label2_Click(object sender, EventArgs e)

        {



        }



        private void label4_Click(object sender, EventArgs e)

        {



        }



        private void label5_Click(object sender, EventArgs e)

        {



        }



        private void pictureBox2_Click(object sender, EventArgs e)

        {



        }



        private void label1_Click(object sender, EventArgs e)

        {



        }



        private void button13_Click(object sender, EventArgs e)

        {



        }

        private void AddNumber(object sender, EventArgs e)
        {
            if ((sender as Button).Text == ",")
            {
                if (txtPeso.BackColor == Color.Red)
                {
                    if (!txtPeso.Text.Contains(","))
                    {
                        txtPeso.Text += (sender as Button).Text;
                    }
                }
            }
            if (txtAltura.BackColor == Color.Red)
            {
                if (!txtAltura.Text.Contains(","))
                {
                    txtAltura.Text += (sender as Button).Text;
                }
            }
            else
            {
                if (txtPeso.BackColor == Color.Red)
                {
                    txtPeso.Text += ((Button)sender).Text;
                }
                else if (txtAltura.BackColor == Color.Red)
                {
                    txtAltura.Text += ((Button)sender).Text;
                }
            }
        }
        private void txtPeso_Enter(object sender, EventArgs e)
        {
            txtPeso.BackColor = Color.Red;
            txtAltura.BackColor = Color.White;
        }

        private void txtAltura_Enter(object sender,EventArgs e)
        {
            txtAltura.BackColor = Color.Red;
            txtPeso.BackColor = Color.White;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtPeso.BackColor ==Color.Red)
            {
                txtPeso.ResetText();
            }
            if (txtAltura.BackColor == Color.Red)
            {
                txtAltura.ResetText();
            }
        }
        private void txtIMC_TextChanged(object sender, EventArgs e)
            { txtIMC.BackColor = Color.Red;
        }
    } 
}