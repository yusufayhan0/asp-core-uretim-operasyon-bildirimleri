
using System;
using System.ComponentModel.DataAnnotations;
namespace UretimOperasyonBildirimleri.Models
{
    public class bildirim
    {
        [Key]
        public int IsNo{get;set;} 
        [DataType(DataType.DateTime)]
        public DateTime Baslangic {get;set;}
        [DataType(DataType.DateTime)]
        public DateTime Bitis {get;set;}
        [DataType(DataType.Time)]
        public DateTime ToplamSure {get;set;}
        public string Statu {get;set;}
        public String DurusNedeni {get;set;}
        
    }
}