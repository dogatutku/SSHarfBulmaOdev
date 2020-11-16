using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesliSessizOdev.Service
{
    class SesliSessizHarfService
    {
        char[] _sesliHarfler = new char[] { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ç' };
        public string sesliHarfBul(string kelime)
        {
            string sonuc = "";
            kelime = kelime.ToLower();
            foreach (char karakter in kelime)
            {
                foreach (char harf in _sesliHarfler)
                {
                    if (harf==karakter)
                    {
                        if (!sonuc.Contains(karakter))
                            sonuc += karakter;
                         break;
                    }
                }
            }
            return sonuc;
        }
        public string sessizHarfBul(string kelime,string sesliHarfler)
        {
            string sonuc = "";
            bool sesliHarfBulundu;
            foreach (char karakter in kelime)
            {
                sesliHarfBulundu = false;
                foreach (char harf in sesliHarfler)
                {
                    if (karakter == harf)
                    {
                        sesliHarfBulundu = true;
                        break;
                    }
                }
                if (!sonuc.Contains(karakter) && !sesliHarfBulundu)
                    sonuc += karakter;
            }
            return sonuc;
        }
    }
}
