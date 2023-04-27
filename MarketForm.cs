using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_ve_Marketcilik_Otomasyonu
{
    public partial class MarketForm : Form
    {
        public MarketForm()
        {
            InitializeComponent();
        }
        internal class Urunler
        {
            public int Id { get; set; }
            public string Ad { get; set; }
            public int Adet { get; set; }
            public int Fiyat { get; set; }
        }
        Islemler islem = new Islemler();
        Urunler Urun = new Urunler();
        private void MarketForm_Load(object sender, EventArgs e)
        {

        }
        private void EkleBtn_click(object sender, EventArgs e)
        {
            islem.Ekleme(Convert.ToInt32(UrunIdTxt.Text),UrunAdTxt.Text,Convert.ToInt32(UrunAdetTxt.Text),Convert.ToInt32(UrunFiyatTxt.Text));
        }

        private void SilBtn_Click(object sender, EventArgs e, Islemler islem)
        {
            islem.Silme(Urun);
        }
        private void Guncellebtn_Click(object sender, EventArgs e)
        {
            Task<bool> task = islem.Guncelleme(Urun);
        }
        private void ListelemeBtn_Click(object sender, EventArgs e)
        {
            islem.Listeleme(DataGrid dataGridUrunler);
        }
    }
}
    

