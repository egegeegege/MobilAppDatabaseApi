using System.ComponentModel.DataAnnotations;

namespace DataBase.Models
{
    public abstract class BaseEntitiy
    {
        public int Id { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string Aktif { get; set; } 
    }
}
