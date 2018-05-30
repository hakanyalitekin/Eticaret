using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eticaret.MVCWebUI.Entity
{
    public class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklama{ get; set; }
        public double Fiyat { get; set; }
        public int StokMiktar { get; set; }
        public bool iseAnasayfa { get; set; }
        public bool Aktif { get; set; }
        public int KategoriId{ get; set; }
        public Kategori Kategori{ get; set; }
    }
}