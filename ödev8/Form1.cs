namespace ödev8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                listBox1.Items.Clear();
                MessageBox.Show("Sayı Giriniz!");
                return;
            }
            else if (textBox2.Text == "")
            {
                listBox1.Items.Clear();
                MessageBox.Show("Sayı Giriniz!");
                return;
            }
            listBox1.Items.Clear();
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            if (sayi1 < sayi2)
            {
                for (int i = sayi1; i <= sayi2; i++)
                {
                    if (radioButton1.Checked && i % 2 == 0)
                    {
                        label3.Text = "2'nin Katları";
                        listBox1.Items.Add(i);
                    }
                    if (radioButton2.Checked && i % 3 == 0)
                    {
                        label3.Text = "3'ün Katları";
                        listBox1.Items.Add(i);
                    }
                    if (radioButton3.Checked && i % 5 == 0)
                    {
                        label3.Text = "5'in Katları";
                        listBox1.Items.Add(i);
                    }
                }
            }
            if (sayi1 > sayi2)
            {
                for (int i = sayi2; i <= sayi1; i++)
                {
                    if (radioButton1.Checked && i % 2 == 0)
                    {
                        label3.Text = "2'nin Katları";
                        listBox1.Items.Add(i);
                    }
                    if (radioButton2.Checked && i % 3 == 0)
                    {
                        label3.Text = "3'ün Katları";
                        listBox1.Items.Add(i);
                    }
                    if (radioButton3.Checked && i % 5 == 0)
                    {
                        label3.Text = "5'in Katları";
                        listBox1.Items.Add(i);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 0)
            {
                label5.Text = "";
                label7.Text = "";
                MessageBox.Show("Sayı Giriniz!");
                return;
            }
            int toplam = 0;
            int say = Convert.ToInt32(textBox3.Text);
            string text = say + "=";
            for (int i = 1; i < say; i++)
            {

                if (say % i == 0)
                {
                    text += i;
                    label5.Text = text;
                    text += "+";
                    toplam = toplam + i;
                    if (toplam == say)
                    {
                        label7.Text = "Mükemmel Sayı";
                    }
                    else
                    {
                        label5.Text = " ";
                        label7.Text = "Mükemmel Sayı Değil";
                    }
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" && textBox5.Text == "")
            {
                label11.Text = "";
                label13.Text = "";
                listBox2.Items.Clear();
                MessageBox.Show("Sayı Giriniz!");
                return;
            }
            if (textBox4.Text == "" || textBox5.Text == "")
            {
                label11.Text = "";
                label13.Text = "";
                listBox2.Items.Clear();
                MessageBox.Show("Sayı Giriniz!");
                return;
            }
            listBox2.Items.Clear();
            int sayi;
            int enb = 0;
            int enk = 100;
           int ilksay = Convert.ToInt32(textBox4.Text);
           int iksay = Convert.ToInt32(textBox5.Text);
            Random rnd = new Random();
            for(int i=1; i <= 10; i++)
            {
                if (ilksay < iksay) {
                    sayi = rnd.Next(ilksay, iksay);
                    listBox2.Items.Add(sayi);
                    if (sayi < enk) enk = sayi;
                    if (sayi > enb) enb = sayi;
                }
                if (iksay < ilksay) {
                    sayi = rnd.Next(iksay, ilksay);
                    listBox2.Items.Add(sayi);
                    if (sayi < enk) enk = sayi;
                    if (sayi > enb) enb = sayi;
                }
            }
            label11.Text = enb.ToString();
            label13.Text = enk.ToString();
        }
    }
}
