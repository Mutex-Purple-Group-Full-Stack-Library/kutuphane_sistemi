﻿using System.ComponentModel.DataAnnotations;

namespace Purple_Kutphane_Sistemi.Data
{
    public class Gorevli : Kullanici
    {
        public int gorevli_id { get; set; }
        public bool ceza_durumu { get; set; }
        public int ceza_puani { get; set; }
    }
}
