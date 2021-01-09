/****************************************************************************
**					          SAKARYA ÜNİVERSİTESİ
**				     BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				           BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				          NESNEYE DAYALI PROGRAMLAMA DERSİ
**					          2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 3
**				ÖĞRENCİ ADI............: BÜNYAMİN ŞANLI
**				ÖĞRENCİ NUMARASI.......: B181210040
**                         DERSİN ALINDIĞI GRUP...: 1B
****************************************************************************/





using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Ndp3
{
    public partial class Hesaplayici : Form
    {
        public Hesaplayici()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            var nums = formulBox.Text.Split("/*-+".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var otps = Regex.Split(formulBox.Text, @"\d", RegexOptions.None).Where(p => p != "").ToArray<string>();
            List<string> sayilar = new List<string>();
            foreach (string sayi in nums)
            {
                sayilar.Add(sayi);
            }

            List<string> operators = new List<string>();
            foreach (string otp in otps)
            {
                operators.Add(otp);
            }

            double ilksayi = double.Parse(sayilar[0]);
            double deger = 0;
            for (int i = 0; i < operators.Count; i++)
            {
                switch (operators[i])
                {
                    case "*":
                        if (i + 1 < sayilar.Count)
                        {
                            deger = (double.Parse(sayilar[i]) * double.Parse(sayilar[i + 1]));
                            sayilar[i] = Convert.ToString(deger);
                            sayilar.RemoveAt(i + 1);
                            operators.Remove("*");
                            i = -1;
                        }
                        break;
                    case "/":
                        if (i + 1 < sayilar.Count)
                        {
                            deger = (double.Parse(sayilar[i]) / double.Parse(sayilar[i + 1]));
                            sayilar[i] = Convert.ToString(deger);
                            sayilar.RemoveAt(i + 1);
                            operators.Remove("/");
                            i = -1;
                        }
                        break;
                }
            }

            double toplam = 0;
            for (int i = 0; i < operators.Count; i++)
            {
                switch (operators[i])
                {
                    case "+":
                        if (i + 1 < sayilar.Count)
                        {
                            deger = (double.Parse(sayilar[i]) + double.Parse(sayilar[i + 1]));
                            sayilar[i] = Convert.ToString(deger);
                            sayilar.RemoveAt(i + 1);
                            operators.Remove("+");
                            i = -1;
                        }
                        break;
                    case "-":
                        if (i + 1 < sayilar.Count)
                        {
                            deger = (double.Parse(sayilar[i]) - double.Parse(sayilar[i + 1]));
                            sayilar[i] = Convert.ToString(deger);
                            sayilar.RemoveAt(i + 1);
                            operators.Remove("-");
                            i = -1;
                        }
                        break;
                }
            }

            sonucBox.Text = sayilar[0];
        }

        private void formulBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sonucBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}




