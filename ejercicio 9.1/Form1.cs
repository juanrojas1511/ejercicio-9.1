namespace ejercicio_9._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int num3 = int.Parse(textBox3.Text);
            if (num1 != num2 && num1 != num3 && num2 != num3)
            {
                if ((num1 > num2) && (num1 > num3))
                {
                    lblresultado.Text = "El primer número es mayor";
                }

                else if ((num2 > num3) && (num2 > num1))
                {
                    lblresultado.Text = "El segundo número es mayor";
                }
                else
                {
                    lblresultado.Text = "El tercer número es mayor";
                }

            }
        }
    }
}