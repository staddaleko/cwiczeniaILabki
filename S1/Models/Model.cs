using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace S1.Models
{
    public class Autor
    {
        [Key]
        public int Id_A { set; get; }
        [Required]
        public string Imie { set; get; }
        [Required]
        public string Nazwisko { set; get; }
        [Required]
        public DateTime Data_ur { set; get; }
        //public virtual KsiazkaAutor Ksiazki { set; get; }
    }

    public class Ksiazka
    {
        [Key]
        public int ID_K { set; get; }
        [Required]
        public string Tytul { set; get; }
        [Required]
        public int Rok_w { set; get; }
        [Required]
        public string Opis { set; get; }
        //public virtual KsiazkaAutor Autorzy { set; get; }
    }

    //public class KsiazkaAutor
    //{
    //    [Required]
    //    public virtual ICollection<Autor> Id_a { set; get; }
    //    [Required]
    //    public virtual ICollection<Ksiazka> Id_k { set; get; }
    //}

    public abstract class Autorzy
    {
        public abstract int Lp { get; }
        [Key]
        public int Id_A { set; get; }
        [Required]
        public string Imie { set; get; }
        [Required]
        public string Nazwisko { set; get; }
        [Required]
        public DateTime Data_ur { set; get; }
        
    }

    public abstract class Ksiazki
    {
        public abstract int Lp { get;}
        [Key]
        public int ID_K { set; get; }
        [Required]
        public string Tytul { set; get; }
        [Required]
        public int Rok_w { set; get; }
        [Required]
        public string Opis { set; get; }
    }

    public class AutorDataContext : DbContext
    {
        public AutorDataContext() : base("DB1")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>().ToTable("Autor");
        }

        public DbSet<Autor> Autorzy { set; get; }
    }

    public class KsiazkaDataContext : DbContext
    {
        public KsiazkaDataContext()
            : base("DB1")
        {

        }
        public DbSet<Ksiazka> Ksiazki { set; get; }
    }

    public class KsiazkaAutorDataContext : DbContext
    {
        // public DbSet<KsiazkaAutor> AsocjacjaKsiazkaAutor { set; get; }
    }

    public class VAutorDataContext : DbContext
    {
        public VAutorDataContext()
            : base("DB1")
        {

        }
        public DbSet<Autorzy> VAutorzy { set; get; }
    }

    public class VKsiazkiDataContext : DbContext
    {
        public VKsiazkiDataContext()
            : base("DB1")
        {

        }
        public DbSet<Ksiazki> VKsiazki { set; get; }
    }


}