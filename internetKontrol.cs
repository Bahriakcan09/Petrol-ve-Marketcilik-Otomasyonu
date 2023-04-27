using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Petrol_ve_Marketcilik_Otomasyonu
{
    public class internetKontrol
    {
        public static bool internet()
        {
            WebClient webClient = new WebClient();
            try
            {
                webClient.OpenRead("https://google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
