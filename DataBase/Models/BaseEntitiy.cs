using System.ComponentModel.DataAnnotations;

namespace DataBase.Models
{
    public abstract class BaseEntitiy //Diğer model sınıflarına miras vermek için bir base sınıf oluşturdum bu sınıfı hangi sınıfa miras verirsek bu sınıfın içindeki herşey
                                      //Miras vediğimiz sınıfada geçecektik bunu yapmamız için bu sınıfı abstract olarak işaretlememizde gerekir burdaki nilgileri diğer sınıflara 
                                      //defalarca yazmak istemediğim için miras alma yöntemini kullandım umarım anlamışsınızdır.
    {
        public int Id { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string Aktif { get; set; } 
    }
}
