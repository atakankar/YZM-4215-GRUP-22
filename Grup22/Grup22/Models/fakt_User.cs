using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Grup22.Models
{
    [Table("Fabrika Kullanıcısı")]
    public class fact_User
    {
        [Key]
        public int fact_Id { get; set; }
        [Required, MaxLength(30, ErrorMessage = "30 karakterden uzun olamaz."), DisplayName("E-posta Adresi")]
        public string fact_Email { get; set; }
        [Required, DisplayName("Şifre")]
        public string fact_Password { get; set; }
        [Required, MaxLength(50, ErrorMessage = "50 karakterden uzun olamaz."), DisplayName("Firma Adı")]
        public string fact_Name { get; set; }
        [Required, DisplayName("Adres")]
        public string fact_Adress { get; set; }
    }
}
