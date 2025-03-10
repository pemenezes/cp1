using System.Security.Cryptography.X509Certificates;

namespace defaulçtttt
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "rm97432@fiap.com.br" && textBox2.Text == "97432")
            {
                MessageBox.Show("usuário correto!", "Título da Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("usuário incorreto!", "Título da Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int numero))
            {
                if(numero >= 35)
                {
                    MessageBox.Show("está aposentado", "Título da Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ainda vai demorar para se aposentar XD", "Título da Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            }
        }
    }

