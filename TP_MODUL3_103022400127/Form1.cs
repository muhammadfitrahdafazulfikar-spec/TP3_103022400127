namespace TP_MODUL3_103022400127
{
    public partial class Form1 : Form
    {
        private int total = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "output";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label1.Text))
            {
                total += int.Parse(label1.Text); // Menyimpan angka pertama
                label1.Text = ""; // Mengosongkan layar untuk angka berikutnya
            }
        }

        private void btnSamaDengan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label1.Text))
            {
                total += int.Parse(label1.Text); // Menambahkan angka terakhir
                label1.Text = total.ToString(); // Menampilkan hasil akhir
                total = 0; // Reset agar bisa menghitung ulang dari nol
            }
        }
    }
}
