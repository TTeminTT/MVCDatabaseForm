using System.ComponentModel.DataAnnotations;

namespace MvcHadi.Models
{
    public class Ogrenci
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Tc'nizi lütfen boş bırakmayınız")]
        [StringLength(11)]
        public string TC { get; set; }
        [Required(ErrorMessage ="Ismi'nizi lütfen boş bırakmayınız")]
        [StringLength(20)]
        public string isim { get; set; }
        [Required(ErrorMessage ="Soyadınızı'nizi lütfen boş bırakmayınız")]
        [StringLength(20)]
        public string soyad { get; set; }
        [Required(ErrorMessage ="Okul No'yu boş bırakmayınız")]
        public int OkulNo { get; set; }
    }
}