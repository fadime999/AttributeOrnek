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

            // Zorunlu alan do�rulama
            if (!ZorunluAlanAttribute.Dogrula(ogrenci))
            {
                MessageBox.Show("��renci bilgileri do�rulamadan ge�emedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Form ba�ar�l�", "Ba�ar�l�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void B�L�M_Click(object sender, EventArgs e)
        {

        }
    }
}
