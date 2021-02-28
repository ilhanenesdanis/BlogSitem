using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogSitem.Models.Sınıf
{
    public class Kategoriler
    {
        [Key]
        public int Id { get; set; }
        public string KategoriAd { get; set; }


    }
}