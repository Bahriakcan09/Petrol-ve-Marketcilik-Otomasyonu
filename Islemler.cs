using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Petrol_ve_Marketcilik_Otomasyonu.MarketForm;
using System.Windows.Forms;
using FireSharp.Response;
using Newtonsoft.Json;
using FireSharp.Interfaces;
using FireSharp.Config;

namespace Petrol_ve_Marketcilik_Otomasyonu
{
    internal class Islemler
    {
        SetResponse response = null;
        Urunler result = null;
        

        IFirebaseConfig config = new FirebaseConfig
        {
            // Firebase projesinin url adresi
            BasePath = "https://petrol-ve-marketcilik-default-rtdb.firebaseio.com",
            // Firebase setting sayfasindan aldigimiz secret key
            AuthSecret = "QIcj0RgPDtVzQFW919C9ojVnJkJDff7Ps4m7lqQq"
            };
        IFirebaseClient client;
        private void BaglantiKontrol()
        {
            Client = new FireSharp.FirebaseClient(config);

            if (Client != null)
            {
                MessageBox.Show("Bağlantı sağlandı.");
            }
        }
        public async void Ekleme(int Id_,string Ad_,int Adet_,int Fiyat_)
        {
            var Urun = new Urunler()
            {
                Id = Id_,
                Ad = Ad_,
                Adet = Adet_,
                Fiyat = Fiyat_

            };

            response = await Client.SetTaskAsync("Urunler/" + Urun.Id + "/",
                                                 Urun);
            result = response.ResultAs<Urunler>();

            if (result.Id != null)
                MessageBox.Show("Kaydedildi");
            else
                MessageBox.Show("Kaydedilemedi.");
        }
        internal async Task<bool> Silme(Urunler Urun)
        {
            var response = await Client.DeleteTaskAsync("Urunler/" + Urun.Id);

            if (!response.Success)
                return false;
            return true;
        }
        //Delete(new Urunler() {Id = 1});
        private async Task<bool> Guncelleme(Urunler Urun)
        {
            var response = await Client.UpdateTaskAsync("Urunler/" + Urun.Id, Urun);
            result = response.ResultAs<Urunler>();

            if (result.Id != null)
                return true;

            return false;
        }
        List<Urunler> listUrunler = new List<Urunler>();
        FirebaseResponse Response = null;

        public IFirebaseClient Client { get => client; set => client = value; }

        public async void Listeleme(DataGrid dataGridUrunler)
        {
            Response = await Client.GetTaskAsync("Urunler");
            var result = Response.Body;
            var data = JsonConvert.DeserializeObject<Dictionary<string, Urunler>>(result);

            foreach (var item in data)
            {
                Urunler value = item.Value;
                Urunler Urun = value;
                listUrunler.Add(Urun);
            }

            dataGridUrunler.ItemSource = listUrunler;
        }
      
    }
}
