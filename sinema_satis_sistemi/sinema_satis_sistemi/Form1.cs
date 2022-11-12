namespace sinema_satis_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int casetotal = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int ticket, popcorn, cola, juice, water, hotdog, total;
            ticket = Convert.ToInt16(comboBox1.Text);
            popcorn = Convert.ToInt16(comboBox2.Text);
            cola = Convert.ToInt16(comboBox3.Text);
            juice = Convert.ToInt16(comboBox4.Text);
            water = Convert.ToInt16(comboBox5.Text);
            hotdog = Convert.ToInt16(comboBox6.Text);

            total = ticket * 10 + popcorn * 5 + cola * 3 + juice * 2 + water * 1 + hotdog * 2;
            lblcalculation.Text = total.ToString() + " $";

            casetotal = casetotal + total;
            lbltotal.Text = casetotal.ToString() + " $";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
        }
    }
}