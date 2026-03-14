namespace Modul3_103022400043
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textNilaiAwal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (cmbSatuanAwal.SelectedIndex == -1 || cmbSatuanAkhir.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih Satuan Terlebih dahulu!");
                return;
            }

            double nilaiAwal;

            if (!double.TryParse(textNilaiAwal.Text, out nilaiAwal))
            {
                MessageBox.Show("Masukkan Angka yang valid!");
                return;
            }

            string satuanAwal = cmbSatuanAwal.SelectedItem.ToString();
            string satuanAkhir = cmbSatuanAkhir.SelectedItem.ToString();

            double hasil = nilaiAwal;

            if (satuanAwal == "Fahrenheit")
            {
                hasil = (nilaiAwal - 32) * 5 / 9;
            }
            else if (satuanAwal == "Kelvin")
            {
                hasil = nilaiAwal - 273.15;
            }
            else if (satuanAwal == "Reamur")
            {
                hasil = nilaiAwal * 5 / 4;
            }

            if (satuanAwal == "Fahrenheit")
            {
                hasil = (hasil * 9 / 5) + 32;
            }
            else if (satuanAkhir == "Kelvin")
            {
                hasil = hasil + 273.15;
            }
            else if (satuanAkhir == "Reamur")
            {
                hasil = hasil * 4 / 5;
            }

            textNilaiAkhir.Text = hasil.ToString();
        }
    }
}
