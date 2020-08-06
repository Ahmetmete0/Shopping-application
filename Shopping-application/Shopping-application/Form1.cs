using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev4
{

    public partial class Form1 : Form
    {      
        public Form1()
        {
            InitializeComponent();                      
        }
       
        public void Form1_Load(object sender, EventArgs e)
        {
                       
          //Kurucu fonskiyon ile atamalar yapıyoruz.
            CepTel Telefon1 = new CepTel("Cep Telefonu", "Apple", "Iphone 11", "Akıllı Telefon", 6000, 64, 4, 3046,Convert.ToInt32(numericUpDown1.Value));
            LedTV TV1 = new LedTV("Televizyon", "LG", " QE75Q90RATXTK", "4K QLED", 30000, 75, "4K Ultra HD", Convert.ToInt32(numericUpDown2.Value));           
            Buzdolabi buzdolabi1 = new Buzdolabi("Buzdolabı", "Bosch", "KGN56LW30N", "Beyaz", 7000, 560, "A++", Convert.ToInt32(numericUpDown3.Value));           
            Laptop Laptop1 = new Laptop("Laptop", "MSI", "GE63", "Oyun Bilgisayari", 15000, 1250, 16, 4400, 15,"1366x768", Convert.ToInt32(numericUpDown4.Value));

            //Ürünlerin hammadde ve stok adedi program açıldığında yazılması için.
            label18.Text = Convert.ToString(Telefon1.hamFiyat);
            label19.Text = Convert.ToString(Telefon1.stokAdedi);

            label20.Text = Convert.ToString(TV1.hamFiyat);
            label21.Text = Convert.ToString(TV1.stokAdedi);

            label22.Text = Convert.ToString(buzdolabi1.hamFiyat);
            label23.Text = Convert.ToString(buzdolabi1.stokAdedi);

            label24.Text = Convert.ToString(Laptop1.hamFiyat);
            label25.Text = Convert.ToString(Laptop1.stokAdedi);

            //Seçilen ürün adedinin en fazla stok adedine eşit olması, stok adedini aşmaması için.
            numericUpDown1.Maximum = Telefon1.stokAdedi;
            numericUpDown2.Maximum = TV1.stokAdedi;
            numericUpDown3.Maximum = buzdolabi1.stokAdedi;
            numericUpDown4.Maximum = Laptop1.stokAdedi;

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
           
            Sepet spt=new Sepet(); //Sepet classını kullanmak için oluşturduk.
            double A, B, C, D;
            A = B = C = D = 0;
            //Kurucu fonskiyon ile atamalar yapıyoruz.
            CepTel Telefon1 = new CepTel("Cep Telefonu", "Apple", "Iphone 11", "Akıllı Telefon", 6000, 64, 4, 3046, Convert.ToInt32(numericUpDown1.Value));
            LedTV TV1 = new LedTV("Televizyon", "LG", " QE75Q90RATXTK", "4K QLED", 30000, 75, "4K Ultra HD", Convert.ToInt32(numericUpDown2.Value));
            Buzdolabi buzdolabi1 = new Buzdolabi("Buzdolabı", "Bosch", "KGN56LW30N", "Beyaz", 7000, 560, "A++", Convert.ToInt32(numericUpDown3.Value));
            Laptop Laptop1 = new Laptop("Laptop", "MSI", "GE63", "Oyun Bilgisayari", 15000, 1250, 16, 4400, 15, "1366x768", Convert.ToInt32(numericUpDown4.Value));

            if (listBox1.Items.Count>0) //Sepet dolu ise uyarı verdirmesi için.
            {
                MessageBox.Show("Sepetiniz Dolu Lütfen Önce Boşaltınız...");
            }

            else
            {
                
                if (numericUpDown1.Value > 0) //Seçilen adet 0 dan büyük ise işlemleri yapması için.
                {
                    double kdvliCepTel;
                    string urunekle;
                    urunekle = spt.SepeteUrunEkle(Telefon1);
                 
                    kdvliCepTel = spt.KdvUygula(6000, Convert.ToDouble(numericUpDown1.Value), 1.20);
                    listBox1.Items.Add(numericUpDown1.Value); //Üründen kaç tane seçildiğini listBox1'e yazdırmak için.
                    listBox2.Items.Add(urunekle); //Seçilen ürün adını listBox2'ye yazdırmak için.
                    listBox3.Items.Add(kdvliCepTel); // Seçilen ürünün kdvli fiyatını listBox3'e yazdırmak için.
                    A = kdvliCepTel *Convert.ToDouble(numericUpDown1.Value);
                    label19.Text = Convert.ToString(Convert.ToInt32(label19.Text) - Convert.ToInt32(numericUpDown1.Value)); //Sepete ekleme yapıldığında stoktan eklenen adet kadar düşmesi için
                }

                if (numericUpDown2.Value > 0) //Seçilen adet 0 dan büyük ise işlemleri yapması için.
                {
                    double kdvliTV;
                    string urunekle;
                    urunekle = spt.SepeteUrunEkle(TV1);
                    kdvliTV = spt.KdvUygula(30000, Convert.ToDouble(numericUpDown2.Value), 1.18);
                    listBox1.Items.Add(numericUpDown2.Value); //Üründen kaç tane seçildiğini listBox1'e yazdırmak için.
                    listBox2.Items.Add(urunekle); //Seçilen ürün adını listBox2'ye yazdırmak için.
                    listBox3.Items.Add(kdvliTV); // Seçilen ürünün kdvli fiyatını listBox3'e yazdırmak için.
                    B = kdvliTV * Convert.ToDouble(numericUpDown2.Value);
                    label21.Text = Convert.ToString(Convert.ToInt32(label21.Text) - Convert.ToInt32(numericUpDown2.Value)); //Sepete ekleme yapıldığında stoktan eklenen adet kadar düşmesi için
                }

                if (numericUpDown3.Value > 0) //Seçilen adet 0 dan büyük ise işlemleri yapması için.
                {
                    double kdvliBuzdolabi;
                    string urunekle;
                    urunekle = spt.SepeteUrunEkle(buzdolabi1);
                    kdvliBuzdolabi = spt.KdvUygula(7000, Convert.ToDouble(numericUpDown3.Value), 1.05);
                    listBox1.Items.Add(numericUpDown3.Value); //Üründen kaç tane seçildiğini listBox1'e yazdırmak için.
                    listBox2.Items.Add(urunekle); //Seçilen ürün adını listBox2'ye yazdırmak için.
                    listBox3.Items.Add(kdvliBuzdolabi); // Seçilen ürünün kdvli fiyatını listBox3'e yazdırmak için.
                    C = kdvliBuzdolabi * Convert.ToDouble(numericUpDown3.Value);
                    label23.Text = Convert.ToString(Convert.ToInt32(label23.Text) - Convert.ToInt32(numericUpDown3.Value)); //Sepete ekleme yapıldığında stoktan eklenen adet kadar düşmesi için
                }
                 
                if (numericUpDown4.Value > 0) //Seçilen adet 0 dan büyük ise işlemleri yapması için.
                {
                    double kdvliLaptop;
                    string urunekle;
                    urunekle = spt.SepeteUrunEkle(Laptop1);
                    kdvliLaptop = spt.KdvUygula(15000, Convert.ToDouble(numericUpDown4.Value), 1.15);
                    listBox1.Items.Add(numericUpDown4.Value); //Üründen kaç tane seçildiğini listBox1'e yazdırmak için.
                    listBox2.Items.Add(urunekle); //Seçilen ürün adını listBox2'ye yazdırmak için.
                    listBox3.Items.Add(kdvliLaptop); // Seçilen ürünün kdvli fiyatını listBox3'e yazdırmak için.
                    D = kdvliLaptop * Convert.ToDouble(numericUpDown4.Value);
                    label25.Text = Convert.ToString(Convert.ToInt32(label25.Text) - Convert.ToInt32(numericUpDown4.Value)); //Sepete ekleme yapıldığında stoktan eklenen adet kadar düşmesi için
                }

                label17.Text = Convert.ToString(A + B + C + D); //KDVli toplam fiyatı ekrana yazdırmak için.
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            label19.Text = Convert.ToString(Convert.ToInt32(label19.Text) + Convert.ToInt32(numericUpDown1.Value)); //Sepete eklenen ürünlerin sepet temizlenince tekrar stok sayısına eklenmesi için.
            label21.Text = Convert.ToString(Convert.ToInt32(label21.Text) + Convert.ToInt32(numericUpDown2.Value)); //Sepete eklenen ürünlerin sepet temizlenince tekrar stok sayısına eklenmesi için.
            label23.Text = Convert.ToString(Convert.ToInt32(label23.Text) + Convert.ToInt32(numericUpDown3.Value)); //Sepete eklenen ürünlerin sepet temizlenince tekrar stok sayısına eklenmesi için.
            label25.Text = Convert.ToString(Convert.ToInt32(label25.Text) + Convert.ToInt32(numericUpDown4.Value)); //Sepete eklenen ürünlerin sepet temizlenince tekrar stok sayısına eklenmesi için.

            listBox1.Items.Clear(); //listBox1'i temizlemek için.
            listBox2.Items.Clear(); //listBox2'i temizlemek için.
            listBox3.Items.Clear(); //listBox3'i temizlemek için.
            label17.Text =string.Empty; //Toplam fiyatı temizlemek için.

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    

}
