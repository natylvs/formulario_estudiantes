using System;
using System.Windows.Forms;

namespace formulario_estudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtc.Enabled = false;
            txte.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }

        private void buttonc_Click(object sender, EventArgs e)
        {
            // Validar que los TextBox no estén vacíos y sean números
            if (!double.TryParse(txtn1.Text, out double n1) ||
                !double.TryParse(txtn2.Text, out double n2) ||
                !double.TryParse(txtn3.Text, out double n3) ||
                !double.TryParse(txtn4.Text, out double n4))
            {
                MessageBox.Show("Por favor ingresa todas las notas correctamente.");
                return; // Sale de la función
            }

            // Calcular promedio
            double promedio = (n1 + n2 + n3 + n4) / 4;
            txtp1.Text = promedio.ToString("F2"); // Mostramos promedio siempre

            // Reiniciar controles de completivo y extraordinario
            txtc.Enabled = false;
            txte.Enabled = false;

            // Evaluación inicial
            if (promedio >= 70)
            {
                txtf.Text = "Aprobado";
            }
            else
            {
                txtc.Enabled = true; // Activar completivo
                txtf.Text = "Reprobado"; // Nota provisional

                // Si ya hay nota de completivo
                if (double.TryParse(txtc.Text, out double completivo))
                {
                    double notaFinal = (promedio * 0.5) + (completivo * 0.5);

                    if (notaFinal >= 70)
                    {
                        txtf.Text = "Aprobado";
                    }
                    else
                    {
                        txte.Enabled = true; // Activar extraordinario

                        // Si ya hay nota de extraordinario
                        if (double.TryParse(txte.Text, out double extraordinario))
                        {
                            double notaExtra = (promedio * 0.3) + (extraordinario * 0.7);
                            txtf.Text = (notaExtra >= 70) ? "Aprobado" : "Reprobado";
                        }
                    }
                }
            }
        }


        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

