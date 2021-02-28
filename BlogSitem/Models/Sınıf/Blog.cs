using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogSitem.Models.Sınıf
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Baslık { get; set; }
        public string BlogImg { get; set; }
        public string BlogOzet { get; set; }
        public string BlogYazı { get; set; }
        public DateTime Tarih { get; set; }
        public ICollection<Yorumlar> yorumlars { get; set; }
    }
}