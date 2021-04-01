using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1180505018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Soru1_Click(object sender, EventArgs e)
        {
            long sayi = 123456;
            bool asalMi = true;

            for(long i = sayi; i >= 1; i--)
            {
                if(sayi % i == 0)
                {
                    for(long j = 2; j < i; j++)
                    {
                        if(i % j == 0)
                        {
                            asalMi = false;
                            break;
                        }
                    }

                    if (asalMi)
                    {
                        txtCevap.Text = i.ToString();
                        break;
                    }
                    asalMi = true;
                }
            }

        }

        private void Soru2_Click(object sender, EventArgs e)
        {

            // öklit algoritmasını oluşturuyoruz
            int GCD(int a, int b)
            {
                if(b == 0){ return a; }
                else{ return GCD(b, a % b); }
            }

            // öklit algoritamasını kullanarak en küçük ortak katı buluyoruz
            int LCM(int a, int b)
            {
                var gcd = GCD(a, b);
                return a * b / gcd;
            }

            int result = 1;
            string res;

            // 1 her sayıya bölündüğü için 2-20 arası en küçük ortak katı buluyoruz
            for(int n = 2; n < 20; n++)
            {
                result = LCM(result, n);
            }

            res = result.ToString();
            txtCevap.Text = res;
            

        }

        private void Soru3_Click(object sender, EventArgs e)
        {
            int length = 0;
            string  SayiToYazi(string sayi)
            {
                int max_basamak = 30;
                int a;
                string[] answer;
                string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
                string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
                string[] binler = { "oktilyon", "septilyon", "seksilyon", "kentilyon", "katrilyon", "trilyon", "milyar", "milyon", "bin", "" };
                int[] basamaklar = new int[3];
                string sonuc = "";
                //sayının kullanılmayan basamaklarını sıfırla doldur
                sayi = sayi.PadLeft(max_basamak, '0');
                //sayıyı üçerli basamaklara ayır
                for (int i = 0; i < max_basamak / 3; i++)
                {
                    string temp = "";
                    //yüzler basamağı
                    basamaklar[0] = (int)(sayi[i * 3] - '0');
                    //onlar basamağı
                    basamaklar[1] = (int)(sayi[i * 3 + 1] - '0');
                    //birler basamağı
                    basamaklar[2] = (int)(sayi[i * 3 + 2] - '0');

                    if (basamaklar[0] == 0)
                        temp = ""; //yüzler basamağı boş
                    else
                        if (basamaklar[0] == 1)
                        temp = "yüz"; //yüzler basamağında 1 varsa
                    else
                        temp = birler[basamaklar[0]] + "yüz";  // birleştir

                    //yüzler+onlar+birler basamağını birleştir
                    temp += onlar[basamaklar[1]] + birler[basamaklar[2]];

                    //basamak değeri oluşmadıysa yani 000 ise binler basamağını ekle
                    if (!string.IsNullOrEmpty(temp)) temp += binler[i];
                    //birbin olmaz
                    if ((i > 1) && (temp.Equals("birbin"))) temp = "bin";
                    if (temp != "") sonuc += temp + "";
                }
                if (string.IsNullOrEmpty(sonuc.Trim()))
                    sonuc = "sıfır";
                return sonuc.Trim();
            }

            for (int a = 0; a <= 1000; a++)
            {
                //Console.WriteLine(SayiToYazi(a.ToString()));
                length += SayiToYazi(a.ToString()).Length;
            }

            txtCevap.Text = length.ToString();
        }
    }
}
