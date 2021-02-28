using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogSitem.Models.Sınıf
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string KullanıcıAdı { get; set; }
        public string Sifre { get; set; }

    }
}