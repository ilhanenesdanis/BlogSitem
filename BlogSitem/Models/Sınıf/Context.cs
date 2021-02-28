using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BlogSitem.Models.Sınıf
{
    public class Context:DbContext
    {
        public DbSet<Admin> admins { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<Hakkımda> hakkımdas { get; set; }
        public DbSet<Kategoriler> kategorilers { get; set; }
        public DbSet<Yorumlar> yorumlars { get; set; }
    }
}