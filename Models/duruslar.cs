
using System;
using System.ComponentModel.DataAnnotations;

namespace UretimOperasyonBildirimleri.Models
{
    public class duruslar
    {
        [Key]
        public int DurusId{get; set;}
        [DataType(DataType.Time)]
        public  DateTime Baslangic {get; set;}
        [DataType(DataType.Time)]
        public DateTime Bitis{get;set;}
        public string DurusNededi{get;set;}
    }
}