using DefinexAttributeOrnek;

namespace WinFormsAppAttribute
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci
            {
                Adi = textBox1.Text,
                Soyadi = textBox2.Text,
                Bolum = textBox3.Text
            };

            // Zorunlu alan doðrulama
            if (!ZorunluAlanAttribute.Dogrula(ogrenci))
            {
                MessageBox.Show("Öðrenci bilgileri doðrulamadan geçemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Form baþarýlý", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BÖLÜM_Click(object sender, EventArgs e)
        {

        }
    }
}
